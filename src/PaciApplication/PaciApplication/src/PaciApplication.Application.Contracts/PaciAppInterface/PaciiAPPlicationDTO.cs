using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace PaciApplication.PaciAppInterface
{
    public class PaciiAPPlicationDTO: AuditedEntityDto<Guid>
    {

         public int PaciApplicationId { get; set;}
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
