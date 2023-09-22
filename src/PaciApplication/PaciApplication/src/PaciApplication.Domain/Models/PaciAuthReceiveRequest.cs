using System;
using System.ComponentModel.DataAnnotations;

namespace PACIModel.Models
{
    public class PaciAuthReceiveRequest
    {
        [Key]
        public int PaciAuthenticationRecieveRequestId { get; set; }
        public string CivilId { get; set; }
        public string FullNameAr { get; set; }
        public string FullNameEn { get; set; }
        public string NationalityEn { get; set; }
        public string NationalityAr { get; set; }
        public string Gender { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PassportNumber { get; set; }
        public string RequestID { get; set; }
        public string RequestType { get; set; }
        public string ServiceProviderId { get; set; }
        public string Challenge { get; set; }
        public string AllJsonData { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ResultCode { get; set; }
        public string UserAction { get; set; }

        public string FlexField { get; set; }

        public DateTime BirthDate { get; set; }
        public string BloodGroup { get; set; }
        public string DocumentNumber { get; set; }
        public string GovData { get; set; }
        public string Address { get; set; }
    }
}
