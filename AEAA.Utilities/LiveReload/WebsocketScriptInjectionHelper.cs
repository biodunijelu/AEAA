﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AEAA.Utilities.LiveReload
{
    /// <summary>
    /// Helper class that handles the HTML injection into
    /// a string or byte array.
    /// </summary>
    public static class WebsocketScriptInjectionHelper
    {
        private const string STR_WestWindMarker = "<!-- AEAA Live Reload -->";
        private const string STR_BodyMarker = "</body>";

        private static readonly byte[] _bodyBytes = Encoding.UTF8.GetBytes(STR_BodyMarker);
        private static readonly byte[] _markerBytes = Encoding.UTF8.GetBytes(STR_WestWindMarker);


        /// <summary>
        /// Injects WebSocket Refresh code into JavaScript document
        /// just above the `</body>` tag.
        /// </summary>
        /// <param name="html"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string InjectLiveReloadScript(string html, HttpContext context)
        {
            if (html.Contains(STR_WestWindMarker))
                return html;

            string script = GetWebSocketClientJavaScript(context);
            html = html.Replace(STR_BodyMarker, script);

            return html;
        }


        /// <summary>
        /// Adds Live Reload WebSocket script into the page before the body tag.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="context"></param>
        /// <param name="baseStream">The raw Response Stream</param>
        /// <returns></returns>
        public static async Task InjectLiveReloadScriptAsync(byte[] buffer, HttpContext context, Stream baseStream)
        {
            var index = buffer.LastIndexOf(_markerBytes);

            if (index > -1)
            {
                await baseStream.WriteAsync(buffer, 0, buffer.Length);
                return;
            }

            index = buffer.LastIndexOf(_bodyBytes);
            if (index == -1)
            {
                await baseStream.WriteAsync(buffer, 0, buffer.Length);
                return;
            }

            var endIndex = index + _bodyBytes.Length;

            await baseStream.WriteAsync(buffer, 0, index - 1);
            var scriptBytes = Encoding.UTF8.GetBytes(GetWebSocketClientJavaScript(context));
            await baseStream.WriteAsync(scriptBytes, 0, scriptBytes.Length);
            await baseStream.WriteAsync(buffer, endIndex, buffer.Length - endIndex);
        }

        static int LastIndexOf<T>(this T[] array, T[] sought) where T : IEquatable<T> =>
            array.AsSpan().LastIndexOf(sought);

        /// <summary>
        /// Adds Live Reload WebSocket script into the page before the body tag.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        /// <param name="context"></param>
        /// <param name="baseStream">The raw Response Stream</param>
        /// <returns></returns>
        public static Task InjectLiveReloadScriptAsync(byte[] buffer, int offset, int count, HttpContext context, Stream baseStream)
        {
            Span<byte> currentBuffer = buffer;
            var curBuffer = currentBuffer.Slice(offset, count).ToArray();
            return InjectLiveReloadScriptAsync(curBuffer, context, baseStream);
        }


        public static string GetWebSocketClientJavaScript(HttpContext context)
        {
            var config = LiveReloadConfiguration.Current;

            var host = context.Request.Host;
            string hostString;
            if (!string.IsNullOrEmpty(config.WebSocketHost))
                hostString = config.WebSocketHost + config.WebSocketUrl;
            else
            {
                var prefix = context.Request.IsHttps ? "wss" : "ws";
                hostString = $"{prefix}://{host.Host}:{host.Port}" + config.WebSocketUrl;
            }

            string script = $@"
<!-- West Wind Live Reload -->
<script>
(function() {{
var retry = 0;
var connection = tryConnect();
function tryConnect(){{
    try{{
        var host = '{hostString}';
        connection = new WebSocket(host); 
    }}
    catch(ex) {{ console.log(ex); retryConnection(); }}
    if (!connection)
       return null;
    clearInterval(retry);
    connection.onmessage = function(message) 
    {{ 
        if (message.data == 'DelayRefresh') {{
                    alert('Live Reload Delayed Reload.');
            setTimeout( function() {{ location.reload(true); }},{config.ServerRefreshTimeout});
                }}
        if (message.data == 'Refresh') 
          location.reload(true); 
    }}    
    connection.onerror = function(event)  {{
        console.log('Live Reload Socket error.', event);
        retryConnection();
    }}
    connection.onclose = function(event) {{
        console.log('Live Reload Socket closed.');
        retryConnection();
    }}
    console.log('Live Reload socket connected.');
    return connection;  
}}
function retryConnection() {{   
   retry = setInterval(function() {{ 
                console.log('Live Reload retrying connection.'); 
                connection = tryConnect();  
                if(connection) location.reload(true);                    
            }},{config.ServerRefreshTimeout});
}}
}})();
</script>
<!-- End Live Reload -->
</body>";
            return script;
        }

    }
}
