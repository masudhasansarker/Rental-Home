using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class RentalHistory
    {
        [Key]
        public string RentHistoryID { get; set; } = Guid.NewGuid().ToString();
        public string? HouseInformationId { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
        public double? RentAmount { get; set; }

        public string? ReasonForChange { get; set; }
    }
}
