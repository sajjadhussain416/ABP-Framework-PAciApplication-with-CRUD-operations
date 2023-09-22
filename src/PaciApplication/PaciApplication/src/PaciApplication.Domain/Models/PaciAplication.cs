using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace PACIModel.Models
{
    public class PaciAplication:FullAuditedAggregateRoot<Guid>
    {
        [Key]
        public int PaciApplicationId { get; set; }
        public string ApplicationGuidId { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationDescriptionAr { get; set; }
        public string ApplicationDescriptionEn { get; set; }
        public string ReasonAr { get; set; }
        public string ReasonEn { get; set; }
        public string Challange { get; set; }
        public Boolean IsEnabled { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
