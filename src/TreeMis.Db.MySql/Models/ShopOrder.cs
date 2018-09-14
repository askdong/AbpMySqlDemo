using System;
using System.Collections.Generic;

namespace TreeMis.Db.MySql.Models
{
    public partial class ShopOrder
    {
        public ShopOrder()
        {
            ShopOrderProduct = new HashSet<ShopOrderProduct>();
        }

        public int Id { get; set; }
        public string OrderSn { get; set; }
        public decimal? SumMoney { get; set; }
        public decimal? DealMoney { get; set; }
        public string DealContent { get; set; }
        public int? CustomerId { get; set; }
        public int? ShopId { get; set; }
        public int? Status { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreateDate { get; set; }

        public ShopCustomer Customer { get; set; }
        public ICollection<ShopOrderProduct> ShopOrderProduct { get; set; }
    }
}
