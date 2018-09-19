using System;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TreeMis.Db.MySql.Models
{
    public partial class SalesBookContext : AbpDbContext//DbContext
    {

        public SalesBookContext(DbContextOptions<SalesBookContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ReportSalesDaily> ReportSalesDaily { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }
        public virtual DbSet<ShopCart> ShopCart { get; set; }
        public virtual DbSet<ShopCategroy> ShopCategroy { get; set; }
        public virtual DbSet<ShopCustomer> ShopCustomer { get; set; }
        public virtual DbSet<ShopOrder> ShopOrder { get; set; }
        public virtual DbSet<ShopOrderProduct> ShopOrderProduct { get; set; }
        public virtual DbSet<ShopProduct> ShopProduct { get; set; }
        public virtual DbSet<ShopProductImage> ShopProductImage { get; set; }
        public virtual DbSet<ShopSpace> ShopSpace { get; set; }
        public virtual DbSet<ShopUser> ShopUser { get; set; }
        public virtual DbSet<StockOrderIn> StockOrderIn { get; set; }
        public virtual DbSet<StockOrderOut> StockOrderOut { get; set; }
        public virtual DbSet<SysAccount> SysAccount { get; set; }
        public virtual DbSet<SysDict> SysDict { get; set; }
        public virtual DbSet<SysUploadFile> SysUploadFile { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReportSalesDaily>(entity =>
            {
                entity.ToTable("report_sales_daily");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CostSum)
                    .HasColumnName("cost_sum")
                    .HasColumnType("decimal(8,2)");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EarnSum)
                    .HasColumnName("earn_sum")
                    .HasColumnType("decimal(8,2)");

                entity.Property(e => e.ProductCount)
                    .HasColumnName("product_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SaleSum)
                    .HasColumnName("sale_sum")
                    .HasColumnType("decimal(8,2)");

                entity.Property(e => e.ShopId)
                    .HasColumnName("shop_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ymd)
                    .HasColumnName("ymd")
                    .HasColumnType("char(8)");
            });

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.ToTable("shop");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasColumnType("varchar(512)");

                entity.Property(e => e.ShopType)
                    .HasColumnName("shop_type")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ShortName)
                    .HasColumnName("short_name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Site)
                    .HasColumnName("site")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ShopCart>(entity =>
            {
                entity.ToTable("shop_cart");

                entity.HasIndex(e => e.ProductId)
                    .HasName("FK_Reference_3");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShopId)
                    .HasColumnName("shop_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ShopCart)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Reference_3");
            });

            modelBuilder.Entity<ShopCategroy>(entity =>
            {
                entity.ToTable("shop_categroy");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.ShopId)
                    .HasColumnName("shop_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ShopCustomer>(entity =>
            {
                entity.ToTable("shop_customer");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("varchar(512)");

                entity.Property(e => e.Avatar)
                    .HasColumnName("avatar")
                    .HasColumnType("varchar(512)");

                entity.Property(e => e.Birthday)
                    .HasColumnName("birthday")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Qq)
                    .HasColumnName("qq")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.ShopId)
                    .HasColumnName("shop_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Wechat)
                    .HasColumnName("wechat")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<ShopOrder>(entity =>
            {
                entity.ToTable("shop_order");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("FK_Reference_8");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DealContent)
                    .HasColumnName("deal_content")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.DealMoney)
                    .HasColumnName("deal_money")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.OrderSn)
                    .HasColumnName("order_sn")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasColumnType("varchar(512)");

                entity.Property(e => e.ShopId)
                    .HasColumnName("shop_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SumMoney)
                    .HasColumnName("sum_money")
                    .HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ShopOrder)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Reference_8");
            });

            modelBuilder.Entity<ShopOrderProduct>(entity =>
            {
                entity.ToTable("shop_order_product");

                entity.HasIndex(e => e.OrderId)
                    .HasName("FK_Reference_5");

                entity.HasIndex(e => e.ProductId)
                    .HasName("FK_Reference_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.ShopOrderProduct)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Reference_5");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ShopOrderProduct)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Reference_4");
            });

            modelBuilder.Entity<ShopProduct>(entity =>
            {
                entity.ToTable("shop_product");

                entity.HasIndex(e => e.CateId)
                    .HasName("FK_Reference_2");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CateId)
                    .HasColumnName("cate_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Factory)
                    .HasColumnName("factory")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Html)
                    .HasColumnName("html")
                    .HasColumnType("varchar(4000)");

                entity.Property(e => e.HtmlText)
                    .HasColumnName("html_text")
                    .HasColumnType("text");

                entity.Property(e => e.PriceIn)
                    .HasColumnName("price_in")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.PriceOut)
                    .HasColumnName("price_out")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ShopId)
                    .HasColumnName("shop_id")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.StockNum)
                    .HasColumnName("stock_num")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Cate)
                    .WithMany(p => p.ShopProduct)
                    .HasForeignKey(d => d.CateId)
                    .HasConstraintName("FK_Reference_2");
            });

            modelBuilder.Entity<ShopProductImage>(entity =>
            {
                entity.ToTable("shop_product_image");

                entity.HasIndex(e => e.ProductId)
                    .HasName("FK_Reference_1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Index)
                    .HasColumnName("index")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasColumnType("varchar(1024)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ShopProductImage)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Reference_1");
            });

            modelBuilder.Entity<ShopSpace>(entity =>
            {
                entity.ToTable("shop_space");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActType)
                    .HasColumnName("act_type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Msg)
                    .HasColumnName("msg")
                    .HasColumnType("varchar(512)");

                entity.Property(e => e.ShopId)
                    .HasColumnName("shop_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ViewLevel)
                    .HasColumnName("view_level")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ShopUser>(entity =>
            {
                entity.ToTable("shop_user");

                entity.HasIndex(e => e.ShopId)
                    .HasName("FK_Reference_7");

                entity.HasIndex(e => e.UserId)
                    .HasName("FK_Reference_6");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsOwner)
                    .HasColumnName("is_owner")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShopId)
                    .HasColumnName("shop_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShopRole)
                    .HasColumnName("shop_role")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("varchar(128)");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.ShopUser)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_Reference_7");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ShopUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Reference_6");
            });

            modelBuilder.Entity<StockOrderIn>(entity =>
            {
                entity.ToTable("stock_order_in");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InNum)
                    .HasColumnName("in_num")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(512)");

                entity.Property(e => e.StockNo)
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.StockPrice)
                    .HasColumnName("stock_price")
                    .HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<StockOrderOut>(entity =>
            {
                entity.ToTable("stock_order_out");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OutNum)
                    .HasColumnName("out_num")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(512)");

                entity.Property(e => e.SalePrice)
                    .HasColumnName("sale_price")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.StockNo)
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<SysAccount>(entity =>
            {
                entity.ToTable("sys_account");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Avatar)
                    .HasColumnName("avatar")
                    .HasColumnType("varchar(512)");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UserPass)
                    .HasColumnName("user_pass")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<SysDict>(entity =>
            {
                entity.ToTable("sys_dict");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DictKey)
                    .HasColumnName("dict_key")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DictText)
                    .HasColumnName("dict_text")
                    .HasColumnType("varchar(512)");

                entity.Property(e => e.Mtype)
                    .HasColumnName("mtype")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderIndex)
                    .HasColumnName("order_index")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(512)");

                entity.Property(e => e.ShopId)
                    .HasColumnName("shop_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<SysUploadFile>(entity =>
            {
                entity.ToTable("sys_upload_file");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.FileExt)
                    .HasColumnName("file_ext")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FileName)
                    .HasColumnName("file_name")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasColumnType("varchar(512)");

                entity.Property(e => e.SecName)
                    .HasColumnName("sec_name")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");
            });
        }
    }
}
