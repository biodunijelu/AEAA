using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AEAA.Infrastructure.ReverseEngineering
{
    public partial class AEAAPortalV2Context : DbContext
    {
        public AEAAPortalV2Context()
        {
        }

        public AEAAPortalV2Context(DbContextOptions<AEAAPortalV2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<BtCountry> BtCountry { get; set; }
        public virtual DbSet<BtLga> BtLga { get; set; }
        public virtual DbSet<BtPermissions> BtPermissions { get; set; }
        public virtual DbSet<BtRoleClaim> BtRoleClaim { get; set; }
        public virtual DbSet<BtRoles> BtRoles { get; set; }
        public virtual DbSet<BtState> BtState { get; set; }
        public virtual DbSet<BtSysConfiguration> BtSysConfiguration { get; set; }
        public virtual DbSet<BtUser> BtUser { get; set; }
        public virtual DbSet<BtUserClaim> BtUserClaim { get; set; }
        public virtual DbSet<BtUserLogin> BtUserLogin { get; set; }
        public virtual DbSet<BtUserLoginHistory> BtUserLoginHistory { get; set; }
        public virtual DbSet<BtUserRole> BtUserRole { get; set; }
        public virtual DbSet<TEmailLog> TEmailLog { get; set; }
        public virtual DbSet<TEmailToken> TEmailToken { get; set; }
        public virtual DbSet<TEmailtemplate> TEmailtemplate { get; set; }
        public virtual DbSet<TRegulator> TRegulator { get; set; }
        public virtual DbSet<TSmsToken> TSmsToken { get; set; }
        public virtual DbSet<TUserExt> TUserExt { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=L-BIJELU-HP\\MSSQL2012;Database=AEAAPortalV2;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BtCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("pk_country");

                entity.ToTable("bt_country");

                entity.HasComment("The various countries of the world registered on the system");

                entity.HasIndex(e => e.CountryCode)
                    .HasName("uq1_country")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("uq2_country")
                    .IsUnique();

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("country_code")
                    .HasMaxLength(3)
                    .HasComment("The official code of registered country");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(255)
                    .HasComment("The creator of the country into the database");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The date country was created into the database");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(128)
                    .HasComment("The country unique name");

                entity.Property(e => e.NationalCurrency)
                    .HasColumnName("national_currency")
                    .HasMaxLength(3)
                    .HasComment("The country official currency");

                entity.Property(e => e.Nationality)
                    .HasColumnName("nationality")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<BtLga>(entity =>
            {
                entity.HasKey(e => e.LgaId)
                    .HasName("pk_lga_code");

                entity.ToTable("bt_lga");

                entity.HasIndex(e => e.LgaCode)
                    .HasName("uq1_lga")
                    .IsUnique();

                entity.Property(e => e.LgaId).HasColumnName("lga_id");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.LgaCode)
                    .IsRequired()
                    .HasColumnName("lga_code")
                    .HasMaxLength(10);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128);

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasColumnName("state_code")
                    .HasMaxLength(10);

                entity.HasOne(d => d.StateCodeNavigation)
                    .WithMany(p => p.BtLga)
                    .HasPrincipalKey(p => p.StateCode)
                    .HasForeignKey(d => d.StateCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk1_lga");
            });

            modelBuilder.Entity<BtPermissions>(entity =>
            {
                entity.HasKey(e => e.PermissionId);

                entity.ToTable("bt_permissions");

                entity.HasIndex(e => e.RegId)
                    .HasName("uq1_permissions")
                    .IsUnique();

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(255);

                entity.Property(e => e.Permissions)
                    .IsRequired()
                    .HasColumnName("permissions");

                entity.Property(e => e.RegId).HasColumnName("reg_id");

                entity.HasOne(d => d.Reg)
                    .WithOne(p => p.BtPermissions)
                    .HasForeignKey<BtPermissions>(d => d.RegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk1_permissions");
            });

            modelBuilder.Entity<BtRoleClaim>(entity =>
            {
                entity.ToTable("bt_role_claim");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.BtRoleClaim)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<BtRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("bt_roles");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.ConcurrencyStamp).HasColumnName("concurrency_stamp");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSuperUser).HasColumnName("is_super_user");

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MerchantId).HasColumnName("merchant_id");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(255);

                entity.Property(e => e.PermissionsInRole).HasColumnName("permissions_in_role");

                entity.Property(e => e.RoleDesc)
                    .HasColumnName("role_desc")
                    .HasMaxLength(1024);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnName("role_name")
                    .HasMaxLength(256);

                entity.Property(e => e.RoleNameNormalised)
                    .HasColumnName("role_name_normalised")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<BtState>(entity =>
            {
                entity.HasKey(e => e.StateId)
                    .HasName("pk_state");

                entity.ToTable("bt_state");

                entity.HasIndex(e => e.Name)
                    .HasName("uq2_state")
                    .IsUnique();

                entity.HasIndex(e => e.StateCode)
                    .HasName("uq1_state")
                    .IsUnique();

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128);

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasColumnName("state_code")
                    .HasMaxLength(10);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.BtState)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk1_state");
            });

            modelBuilder.Entity<BtSysConfiguration>(entity =>
            {
                entity.HasKey(e => e.ConfigId)
                    .HasName("pk_sys_configuration_gnsys");

                entity.ToTable("bt_sys_configuration");

                entity.Property(e => e.ConfigId).HasColumnName("config_id");

                entity.Property(e => e.ConfigValue)
                    .IsRequired()
                    .HasColumnName("config_value")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ConfigValueDesc)
                    .IsRequired()
                    .HasColumnName("config_value_desc")
                    .HasMaxLength(1000);

                entity.Property(e => e.DefaultValue)
                    .IsRequired()
                    .HasColumnName("default_value")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnName("modified_by")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<BtUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("bt_user");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.ExpirationTime)
                    .HasColumnName("expiration_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ForcePwdChange).HasColumnName("force_pwd_change");

                entity.Property(e => e.HasBranch).HasColumnName("has_branch");

                entity.Property(e => e.LastLoginDate).HasColumnName("last_login_date");

                entity.Property(e => e.LastModified).HasColumnName("last_modified");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(255);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.PwdChangedDate)
                    .HasColumnName("pwd_changed_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PwdExpiryDate)
                    .HasColumnName("pwd_expiry_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RefreshToken)
                    .HasColumnName("refresh_token")
                    .HasMaxLength(1000);

                entity.Property(e => e.Token).HasColumnName("token");

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<BtUserClaim>(entity =>
            {
                entity.ToTable("bt_user_claim");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BtUserClaim)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_bt_user_claim_bt_users_UserId");
            });

            modelBuilder.Entity<BtUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey })
                    .HasName("PK_t_app_user_login");

                entity.ToTable("bt_user_login");

                entity.Property(e => e.Discriminator).IsRequired();

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("user_id")
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BtUserLogin)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_t_app_user_login_t_application_users_user_id");
            });

            modelBuilder.Entity<BtUserLoginHistory>(entity =>
            {
                entity.HasKey(e => e.LoginhistId)
                    .HasName("PK_t_user_login_history");

                entity.ToTable("bt_user_login_history");

                entity.Property(e => e.LoginhistId).HasColumnName("loginhist_id");

                entity.Property(e => e.Browser)
                    .HasColumnName("browser")
                    .HasMaxLength(50);

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasColumnName("ip_address")
                    .HasMaxLength(50);

                entity.Property(e => e.Operation)
                    .IsRequired()
                    .HasColumnName("operation")
                    .HasMaxLength(50);

                entity.Property(e => e.SessionDate)
                    .HasColumnName("session_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TenantId).HasColumnName("tenant_id");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("user_id")
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<BtUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.ToTable("bt_user_role");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Discriminator).IsRequired();

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.BtUserRole)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BtUserRole)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_bt_user_role_bt_users_user_id");
            });

            modelBuilder.Entity<TEmailLog>(entity =>
            {
                entity.HasKey(e => e.EmaillogId)
                    .HasName("pk_email_log");

                entity.ToTable("t_email_log");

                entity.HasComment("The various email logs on the system");

                entity.Property(e => e.EmaillogId).HasColumnName("emaillog_id");

                entity.Property(e => e.AttachmentLoc).HasColumnName("attachment_loc");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnName("body");

                entity.Property(e => e.CanSend)
                    .IsRequired()
                    .HasColumnName("can_send")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetosend)
                    .HasColumnName("datetosend")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailBcc)
                    .HasColumnName("email_bcc")
                    .IsUnicode(false);

                entity.Property(e => e.EmailCc)
                    .HasColumnName("email_cc")
                    .IsUnicode(false);

                entity.Property(e => e.FailedSending).HasColumnName("failed_sending");

                entity.Property(e => e.From)
                    .IsRequired()
                    .HasColumnName("from")
                    .IsUnicode(false);

                entity.Property(e => e.HasAttachment).HasColumnName("has_attachment");

                entity.Property(e => e.LastFailed)
                    .HasColumnName("last_failed")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastmodified)
                    .HasColumnName("lastmodified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Sendimmediately).HasColumnName("sendimmediately");

                entity.Property(e => e.Sent).HasColumnName("sent");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnName("subject")
                    .HasMaxLength(300);

                entity.Property(e => e.To)
                    .IsRequired()
                    .HasColumnName("to")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TEmailToken>(entity =>
            {
                entity.HasKey(e => e.EmailtokenId)
                    .HasName("pk_t_email_token");

                entity.ToTable("t_email_token");

                entity.HasComment("This table holds the tokens that can be used wile composing email");

                entity.Property(e => e.EmailtokenId).HasColumnName("emailtoken_id");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailToken)
                    .IsRequired()
                    .HasColumnName("email_token")
                    .HasMaxLength(100);

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(255);

                entity.Property(e => e.PreviewName)
                    .IsRequired()
                    .HasColumnName("preview_name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TEmailtemplate>(entity =>
            {
                entity.HasKey(e => e.EtemplateId)
                    .HasName("pk_emailtemplate");

                entity.ToTable("t_emailtemplate");

                entity.Property(e => e.EtemplateId).HasColumnName("etemplate_id");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnName("body");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnName("subject")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TRegulator>(entity =>
            {
                entity.HasKey(e => e.RegId);

                entity.ToTable("t_regulator");

                entity.Property(e => e.RegId).HasColumnName("reg_id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(1000);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(256);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(256);

                entity.Property(e => e.RegCode)
                    .IsRequired()
                    .HasColumnName("reg_code")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TSmsToken>(entity =>
            {
                entity.HasKey(e => e.SmstokenId);

                entity.ToTable("t_sms_token");

                entity.HasComment("This table holds the tokens that can be used wile composing sms");

                entity.Property(e => e.SmstokenId).HasColumnName("smstoken_id");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(255);

                entity.Property(e => e.PreviewName)
                    .IsRequired()
                    .HasColumnName("preview_name")
                    .HasMaxLength(200);

                entity.Property(e => e.SmsToken)
                    .IsRequired()
                    .HasColumnName("sms_token")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TUserExt>(entity =>
            {
                entity.HasKey(e => e.UserextId);

                entity.ToTable("t_user_ext");

                entity.HasComment("This table holds the users on the systems");

                entity.Property(e => e.UserextId).HasColumnName("userext_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(128);

                entity.Property(e => e.GsuserId)
                    .IsRequired()
                    .HasColumnName("gsuser_id")
                    .HasMaxLength(450);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(128);

                entity.Property(e => e.LgaId).HasColumnName("lga_id");

                entity.Property(e => e.Middlename)
                    .HasColumnName("middlename")
                    .HasMaxLength(128);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(255);

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.Property(e => e.UserCategory)
                    .IsRequired()
                    .HasColumnName("user_category")
                    .HasMaxLength(1);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TUserExt)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("fk1_user_ext");

                entity.HasOne(d => d.Gsuser)
                    .WithMany(p => p.TUserExt)
                    .HasForeignKey(d => d.GsuserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk4_user_ext");

                entity.HasOne(d => d.Lga)
                    .WithMany(p => p.TUserExt)
                    .HasForeignKey(d => d.LgaId)
                    .HasConstraintName("fk3_user_ext");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.TUserExt)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("fk2_user_ext");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
