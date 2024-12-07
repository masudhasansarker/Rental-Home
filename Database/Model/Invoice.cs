using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Invoice
    {
        [Key]
        public string InvoiceID { get; set; }=Guid.NewGuid().ToString();
        [Required]
        public string? UserId { get; set; }
        
        public string? HouseInformationId { get; set; }
        public double? AmountDue {  get; set; }
        public string? PaymentStatus {  get; set; }
        public DateTime InvoiceDate {  get; set; }  = DateTime.Now;

    }
}
