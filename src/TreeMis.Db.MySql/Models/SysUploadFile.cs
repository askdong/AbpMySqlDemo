using System;
using System.Collections.Generic;

namespace TreeMis.Db.MySql.Models
{
    public partial class SysUploadFile
    {
        public string Id { get; set; }
        public string FileName { get; set; }
        public string SecName { get; set; }
        public string FileExt { get; set; }
        public string Path { get; set; }
        public int? Status { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
