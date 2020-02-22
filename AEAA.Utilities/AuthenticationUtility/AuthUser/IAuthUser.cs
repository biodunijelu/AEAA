using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace AEAA.Utilities.AuthenticationUtility.AuthUser
{
    public interface IAuthUser
    {
        string Name { get; }
        string EmailAddress { get; }
        string UserId { get; }
        //string MerchantId { get; }
        //long BranchID { get;  }
        string IPAddress { get; }
        string AffiliateCode { get; }
        string UserCategory { get; }
        string Browser { get; }
        bool Authenticated { get; }
        bool IsAuthenticated();
        IEnumerable<Claim> GetClaimsIdentity();
    }
}
