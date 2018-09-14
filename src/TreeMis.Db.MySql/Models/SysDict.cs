using System;
using System.Collections.Generic;

namespace TreeMis.Db.MySql.Models
{
    public partial class SysDict
    {
        public int Id { get; set; }
        public int? Mtype { get; set; }
        public string DictKey { get; set; }
        public string DictText { get; set; }
        public int? OrderIndex { get; set; }
        public int? Status { get; set; }
        public int? ShopId { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
