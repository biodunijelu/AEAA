using AEAA.Models.Domains.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AEAA.infrastructure
{
    public class AeaaContext : IdentityDbContext<BtUser, BtRole, string>
    {
        public AeaaContext(DbContextOptions<AeaaContext> options) : base(options)
        {

        }
        public AeaaContext()
        {


        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            ///<summary>
            /// Identity Remapping
            /// </summary>
            #region Identity Remapping
            builder.Entity<IdentityRoleClaim<string>>().ToTable("bt_role_claim");
            builder.Entity<IdentityUserClaim<string>>().ToTable("bt_user_claim");
            builder.Entity<IdentityUserToken<string>>().ToTable("bt_user_token");
            builder.Entity<IdentityUserRole<string>>().ToTable("bt_user_role");
            builder.Entity<IdentityUserLogin<string>>().ToTable("bt_user_login");
            #endregion
        }
    }
}
