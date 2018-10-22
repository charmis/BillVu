using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BillVu.WebApi.Models
{
    public class Bill
    {
        [Required]
        public Guid Id { get; set; }

        [Key, Column(Order = 0)]
        public string Name { get; set; }

        [Key, Column(Order = 1)]
        public string ServiceProviderName { get; set; }

        public double Amount { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime? ReminderDate { get; set; }

        public string OnlinePayUrl { get; set; }
    }
}