using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities;

namespace PACIModel.Models
{
    public class PaciAuditLog:Entity<Guid>
    {
        [Key]
        public long PaciAuditLogId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string EventName { get; set; } //
        public string EventType { get; set; }
        public string Description { get; set; }
        public string CivilId { get; set; }
        public string ApplicationName { get; set; }
        public string RequestId { get; set; }
        public string Status { get; set; } // Success or Failed
        public string ReferenceId { get; set; } // both are AuthenticationSendRequestId or AuthenticationRecieveRequestId
        public string LogJSON { get; set; }
    }


}
