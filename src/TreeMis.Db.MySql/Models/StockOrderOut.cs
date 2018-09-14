using System;
using System.Collections.Generic;

namespace TreeMis.Db.MySql.Models
{
    public partial class StockOrderOut
    {
        public int Id { get; set; }
        public string StockNo { get; set; }
        public int? ProductId { get; set; }
        public decimal? SalePrice { get; set; }
        public int? OutNum { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
