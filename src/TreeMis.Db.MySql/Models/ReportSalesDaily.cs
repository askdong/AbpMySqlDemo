using System;
using System.Collections.Generic;

namespace TreeMis.Db.MySql.Models
{
    public partial class ReportSalesDaily
    {
        public int Id { get; set; }
        public string Ymd { get; set; }
        public int? ShopId { get; set; }
        public decimal? SaleSum { get; set; }
        public decimal? CostSum { get; set; }
        public decimal? EarnSum { get; set; }
        public int? ProductCount { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
