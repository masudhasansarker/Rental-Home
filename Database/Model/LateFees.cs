using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class LateFees
    {
        [Key]
        public string LateFeesId { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public string? UserId { get; set; }
        [Required]
        public string? HouseInformationId { get; set; }
        [Required]
        public double? LateFeeAmount { get; set; }
        public DateTime DueDate { get; set; } = DateTime.Now;
        public string? PaymentStatus { get; set; }
    }
}
  
