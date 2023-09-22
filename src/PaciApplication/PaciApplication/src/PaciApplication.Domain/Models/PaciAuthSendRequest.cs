using System;
using System.ComponentModel.DataAnnotations;

namespace PACIModel.Models
{
    public class PaciAuthSendRequest
    {

        [Key]
        public int Id { get; set; }
        public long PaciAuthSendRequestId { get; set; }
        public int ApplicationId { get; set; }
        public string ApplicationGuidId { get; set; }
        public string ServiceProviderId { get; set; }
        public string RequestId { get; set; }
        public string CivilId { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationDescriptionAr { get; set; }
        public string ApplicationDescriptionEn { get; set; }
        public string ReasonAr { get; set; }
        public string ReasonEn { get; set; }
        public string Challange { get; set; }
        public string AdditionalData { get; set; }
        public string CallbackURL  { get; set; }
        public bool IsUserDetails { get; set; }
        public string AssuranceLevel { get; set; }
        public DateTime RequestDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

    }

}
