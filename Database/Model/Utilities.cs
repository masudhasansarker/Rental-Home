using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Utilities
    {
        [Key]
        public string UtilityID { get; set; }=Guid.NewGuid().ToString();
        public string? HouseInformationId { get; set; }
        [Required]
        public string? UtilityType { get; set; }
        [Required]
        public double? UsageAmount { get; set; }
        public string? AmountDue { get; set; }
    }
}
