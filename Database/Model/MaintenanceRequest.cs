using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class MaintenanceRequest
    {
        [Key]
        public String MaintenanceRequestID{ get; set; }=Guid.NewGuid().ToString();
        [Required]
        public String? UserId { get; set; }
        [Required]
        public String? HouseInformationId { get; set; }
        public DateTime RequestDate { get; set; }=DateTime.Now;
        [Required]
        public String? IssueDescription {  get; set; }
        public DateTime ResolutionDate { get; set; } = DateTime.Now;

      }
}
