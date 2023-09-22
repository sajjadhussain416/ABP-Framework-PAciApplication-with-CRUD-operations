using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace PaciApplication.PaciAppInterface
{
    public class PacciSettingDTO : AuditedEntityDto<Guid>
    {

        [Key]
        public int PaciSettingId { get; set; }
        [Required]
        public string SettingName { get; set; }
        [Required]
        public string SettingValue { get; set; }
        public Boolean IsDisabled { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string FlexColumn1 { get; set; }
        public string FlexColumn2 { get; set; }

    }
}
