using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Invoice
    {
        public string OrderNumber { get; set; }
        public DateOnly OrderDate { get; set; }
        public DateOnly? ShipDate { get; set; }
        public int CustomerStateID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountAmount { get; set; }
        public string? PromotionCode { get; set; }

    }

}
