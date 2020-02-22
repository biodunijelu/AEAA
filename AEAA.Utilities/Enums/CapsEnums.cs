﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace AEAA.Utilities
{
    public class AEAAEnums
    {
        public enum SizeUnits
        {
            Byte, KB, MB, GB, TB, PB, EB, ZB, YB
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum Gender
        {
            [EnumMember(Value = "M")]
            [Description("Male")]
            Male = 1,
            [EnumMember(Value = "F")]
            [Description("Female")]
            Female = 2,
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum BloodGroup
        {
            [Display(Name = "A+", Description = "")]
            Aplus = 1,
            [Display(Name = "O+", Description = "")]
            Oplus = 2,
            [Display(Name = "B+", Description = "")]
            Bplus = 3,
            [Display(Name = "AB+", Description = "")]
            ABplus = 4,
            [Display(Name = "A-", Description = "")]
            Anegative = 5,
            [Display(Name = "O-", Description = "")]
            Onegative = 6,
            [Display(Name = "B-", Description = "")]
            Bnegative = 7,
            [Display(Name = "AB-", Description = "")]
            ABnegative = 8,
        }


        public enum GenoType
        {
            [Display(Name = "AA", Description = "")]
            AA = 1,
            [Display(Name = "AO", Description = "")]
            AO = 2,
            [Display(Name = "BB", Description = "")]
            BB = 3,
            [Display(Name = "BO", Description = "")]
            BO = 4,
            [Display(Name = "AB", Description = "")]
            AB = 5,
            [Display(Name = "OO", Description = "")]
            OO = 6,
        }

        public enum FieldTypes
        {
            [Display(Name = "INPUT", Description = "")]
            INPUT = 1,
            [Display(Name = "TEXTAREA", Description = "")]
            TEXTAREA = 2,
            [Display(Name = "SELECT", Description = "")]
            SELECT = 3,
            [Display(Name = "RADIO", Description = "")]
            RADIO = 4
        }


        public enum InputTypes
        {
            [Display(Name = "month", Description = "")]
            month = 1,
            [Display(Name = "number", Description = "")]
            number = 2,
            [Display(Name = "radio", Description = "")]
            radio = 3,
            [Display(Name = "text", Description = "")]
            text = 4,
            [Display(Name = "week", Description = "")]
            week = 5
        }

        public enum PatientNumberSeparator
        {
            [Description("Forward Slash")]
            ForwardSlash = 1,
            [Description("Dash")]
            Dash = 2,
        }

        public enum EmailStatus
        {
            Sent = 0,
            Failed = 1001,
        }

        public enum YearEnum
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }

        public enum OptionTypes
        {
            [Display(Name = "rating", Description = "")]
            rating = 1,
            [Display(Name = "likert", Description = "")]
            likert = 2,
            [Display(Name = "radio", Description = "")]
            radio = 3,
            [Display(Name = "text", Description = "")]
            single = 4,
            [Display(Name = "week", Description = "")]
            week = 5
        }

        public enum BroadcastType
        {
            [Display(Name = "Email", Description = "")]
            email = 1,
            [Display(Name = "SMS", Description = "")]
            sms = 2,
        }

        public enum RecieverType
        {
            [Display(Name = "Patient", Description = "")]
            patient = 1,
            [Display(Name = "Employee", Description = "")]
            employee = 2,
        }

        public enum UserCategory
        {
            [Display(Name = "Applicant", Description = "")]
            applicant = 1,
            [Display(Name = "Regulator", Description = "")]
            regualtor = 2,
            [Display(Name = "Institution", Description = "")]
            insitution = 3
        }
    }
}
