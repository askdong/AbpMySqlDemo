using System;
using System.Collections.Generic;

namespace TreeMis.Db.MySql.Models
{
    public partial class ShopSpace
    {
        public int Id { get; set; }
        public int? ActType { get; set; }
        public string Msg { get; set; }
        public int? Status { get; set; }
        public int? ViewLevel { get; set; }
        public int? ShopId { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
