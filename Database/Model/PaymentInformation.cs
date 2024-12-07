using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class PaymentInformation
    {
        [Key]
        public string PaymentInformationID { get; set; }=Guid.NewGuid().ToString();
        [Required]
        public String ? UserId { get; set; }
        [Required]
        public string ? HouseInformationId { get; set; }
        [Required]
        public string? PaymentDate { get; set; }
        [Required]
        public double? Amount { get; set; }
        [Required]
        public string? PaymentStatus { get; set; }


    }
}
