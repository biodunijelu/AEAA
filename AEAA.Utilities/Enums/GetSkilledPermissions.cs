using System;
using System.ComponentModel.DataAnnotations;

namespace AEAA.Utilities.Enums
{
    public enum AEAAPermissions : short
    {
        NotSet = 0, //error condition

        #region Country
        [Display(GroupName = "Country", Name = "Add New", Description = "Can add a Country")]
        CanAddCountry,
        [Display(GroupName = "Country", Name = "Update One", Description = "Can update a Country")]
        CanUpdateCountry,
        [Display(GroupName = "Country", Name = "Delete One", Description = "Can delete a Country")]
        CanDeleteOneCountry,
        #endregion

        #region State
        [Display(GroupName = "State", Name = "Add New", Description = "Can add a State")]
        CanAddState,
        [Display(GroupName = "State", Name = "Update One", Description = "Can update a State")]
        CanUpdateState,
        [Display(GroupName = "State", Name = "Delete One", Description = "Can delete a State")]
        CanDeleteOneState,
        #endregion

        #region Lga
        [Display(GroupName = "Lga", Name = "Add New", Description = "Can add new Lga")]
        CanAddLga,
        [Display(GroupName = "Lga", Name = "Update One", Description = "Can update one Lga")]
        CanUpdateLga,
        [Display(GroupName = "Lga", Name = "Delete One", Description = "Can delete one Lga")]
        CanDeleteOneLga,
        #endregion


        #region EmailTemplateLkup
        [Display(GroupName = "EmailTemplateLkup", Name = "Read All", Description = "Can read all EmailTemplateLkups")]
        CanReadEmailTemplateLkups,
        [Display(GroupName = "EmailTemplateLkup", Name = "Add New", Description = "Can add new EmailTemplateLkup")]
        CanAddEmailTemplateLkup,
        [Display(GroupName = "EmailTemplateLkup", Name = "Update One", Description = "Can update one EmailTemplateLkup")]
        CanUpdateEmailTemplateLkup,
        [Display(GroupName = "EmailTemplateLkup", Name = "Delete One", Description = "Can delete one EmailTemplateLkup")]
        CanDeleteOneEmailTemplateLkup,
        #endregion

        /// <summary>
        /// All Permissions for Merchant Endpoints
        /// </summary>
        #region Merchant Permissions

        #region MerchantBranch
        [Display(GroupName = "MerchantBranch", Name = "Read All", Description = "Can read all Merchant Branches")]
        CanReadMerchantBranches,
        [Display(GroupName = "MerchantBranch", Name = "Read All by Merchant", Description = "Can read Branches by merchant")]
        CanReadBranchesByMerchant,
        //[Display(GroupName = "MerchantBranch", Name = "Read All by Branch", Description = "Can read MerchantBranches by branch")]
        //CanReadMerchantBranchsByBranch,
        [Display(GroupName = "MerchantBranch", Name = "Read One", Description = "Can read a Merchant Branch")]
        CanReadOneMerchantBranch,
        [Display(GroupName = "MerchantBranch", Name = "Add New", Description = "Can add a Merchant Branch")]
        CanAddMerchantBranch,
        [Display(GroupName = "MerchantBranch", Name = "Update One", Description = "Can update a Merchant Branch")]
        CanUpdateMerchantBranch,
        [Display(GroupName = "MerchantBranch", Name = "Delete One", Description = "Can delete a Merchant Branch")]
        CanDeleteOneMerchantBranch,
        #endregion

        #endregion



        /// <summary>
        /// All Permissions for Message Endpoints
        /// </summary>
        #region Message Permissions

        #region EmailTemplate
        [Display(GroupName = "EmailTemplate", Name = "Read All by Merchant", Description = "Can read Email Templates by merchant")]
        CanReadEmailTemplatesByMerchant,
        [Display(GroupName = "EmailTemplate", Name = "Read One", Description = "Can read one Email Template")]
        CanReadOneGnsysEmailTemplate,
        [Display(GroupName = "EmailTemplate", Name = "Update One", Description = "Can update one Email Template")]
        CanUpdateGnsysEmailTemplate,
        #endregion

        #endregion
        //========================================================//


        #region Permission Permissions
        [Display(GroupName = "UserAdmin", Name = "Read Roles", Description = "Can list Role")]
        RoleRead = 50,
        [Display(GroupName = "UserAdmin", Name = "Change Role", Description = "Can create, update or delete a Role")]
        RoleChange = 51,
        [Display(GroupName = "UserAdmin", Name = "Read All", Description = "Can read all Permissions")]
        CanReadPermissions,
        [Display(GroupName = "UserAdmin", Name = "Assign Permissions", Description = "Can Assign and Remove Permissions")]
        CanChangeRolePermissions,
        [Display(GroupName = "UserAdmin", Name = "Read All", Description = "Can read all Userss")]
        CanReadUsers,
        [Display(GroupName = "UserAdmin", Name = "Add New", Description = "Can add new Users")]
        CanAddUser,
        [Display(GroupName = "UserAdmin", Name = "Update One", Description = "Can update one Users")]
        CanUpdateUser,
        [Display(GroupName = "UserAdmin", Name = "Delete One", Description = "Can delete one Users")]
        CanDeleteOneUser,
        [Display(GroupName = "UserAdmin", Name = "Read All", Description = "Can read all Students")]
        CanReadStudents,
        [Display(GroupName = "UserAdmin", Name = "Add New", Description = "Can add new Students")]
        CanAddStudent,
        [Display(GroupName = "UserAdmin", Name = "Update One", Description = "Can update one Students")]
        CanUpdateStudent,
        [Display(GroupName = "UserAdmin", Name = "Delete One", Description = "Can delete one Students")]
        CanDeleteOneStudent,
        [Display(GroupName = "UserAdmin", Name = "Read All", Description = "Can read all Supervisor")]
        CanReadSupervisors,
        [Display(GroupName = "UserAdmin", Name = "Assign", Description = "Can add new Supervisor")]
        CanAssignSupervisors,
        [Display(GroupName = "UserAdmin", Name = "Remove", Description = "Can update one Supervisor")]
        CanRemoveSupervisor,
        #endregion

        #region Courses, Category, and Tags, difficultlevel
        [Display(GroupName = "Courses", Name = "Read All", Description = "Can read all Courses")]
        CanReadCourses,
        [Display(GroupName = "Courses", Name = "Add new", Description = "Can add new Course")]
        CanAddCourse,
        [Display(GroupName = "Courses", Name = "Update", Description = "Can update one Course")]
        CanEditCourse,
        [Display(GroupName = "Courses", Name = "Read All", Description = "Can read all Course Categories")]
        CanReadCourseCategories,
        [Display(GroupName = "Courses", Name = "Add new", Description = "Can add new Course Category")]
        CanAddCourseCategory,
        [Display(GroupName = "Courses", Name = "Update", Description = "Can update one Course Category")]
        CanEditCourseCategory,
        [Display(GroupName = "Courses", Name = "Read All", Description = "Can read all Tags")]
        CanReadTags,
        [Display(GroupName = "Courses", Name = "Add new", Description = "Can add new Tag")]
        CanAddTag,
        [Display(GroupName = "Courses", Name = "Update", Description = "Can update one Tag")]
        CanEditTag,
        [Display(GroupName = "Courses", Name = "Read All", Description = "Can read all Difficulty Levels")]
        CanReadDifficultyLevels,
        [Display(GroupName = "Courses", Name = "Add new", Description = "Can add new Difficulty Level")]
        CanAddDifficultyLevel,
        [Display(GroupName = "Courses", Name = "Update", Description = "Can update one Difficulty Level")]
        CanEditDifficultyLevel,
        #endregion

        #region Affiliates, Category, and Tags, difficultlevel
        [Display(GroupName = "Affiliates", Name = "Read All", Description = "Can read all Affiliates")]
        CanReadAffiliates,
        [Display(GroupName = "Affiliates", Name = "Add new", Description = "Can Remove")]
        CanRemoveAffilate,
        [Display(GroupName = "Affiliates", Name = "Update", Description = "Can become Affiliates")]
        CanBecomeAffiliate,
        [Display(GroupName = "Affiliates", Name = "Read All", Description = "Can read all Course Commissions Percentage")]
        CanReadCourseComissions,
        [Display(GroupName = "Affiliates", Name = "Add new", Description = "Can add new Course Comissions Percentage")]
        CanAddCourseComissions,
        [Display(GroupName = "Affiliates", Name = "Update", Description = "Can update one Course Comissions Percentage")]
        CanEditCourseComissions,
        [Display(GroupName = "Affiliates", Name = "Read All", Description = "Can read all Tags")]
        CanReadReferrers,
        [Display(GroupName = "Student", Name = "Read All", Description = "Can do anything as student")]
        CanActAsStudent,
        //[Display(GroupName = "Affiliates", Name = "Add new", Description = "Can add new Difficulty Level")]
        //CanAddDifficultyLevel,
        //[Display(GroupName = "Affiliates", Name = "Update", Description = "Can update one Difficulty Level")]
        //CanEditDifficultyLevel,
        #endregion


        #region Centre Admin
        [Display(GroupName = "CentreAdmin", Name = "Take Attendance", Description = "Can Take Attendance")]
        CanTakeAttedance,
        [Display(GroupName = "CentreAdmin", Name = "Read", Description = "Can Read Today's Trainings")]
        CanReadTodaysTraining,
        [Display(GroupName = "CentreAdmin", Name = "Read", Description = "Can Read Upcomin Trainings")]
        CanReadUpcomingTraining,
        [Display(GroupName = "CentreAdmin", Name = "Read", Description = "Can Read Previous Trainings")]
        CanReadPreviousTraining,
        [Display(GroupName = "Report", Name = "Read", Description = "Can Read Any Reports")]
        CanReadAnyReport,
        #endregion
        [Display(GroupName = "SuperAdmin", Name = "AccessAll", Description = "This allows the user to access every feature")]
        AccessAll = Int16.MaxValue,
    }
}
