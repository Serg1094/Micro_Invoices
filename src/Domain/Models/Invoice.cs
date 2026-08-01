using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Invoice
    {
        public string OrderNunmber { get; set; }
        public DateOnly OrderDate { get; set; }
        public DateOnly? ShipDate { get; set; }
        public int CustomerStateID { get; set; }
        public int ProdcutID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountAmount { get; set; }
        public string? PromotionCode { get; set; }

    }

}
