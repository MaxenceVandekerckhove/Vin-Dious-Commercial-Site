// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vin_Dious_Commercial_Site.Models;

namespace Vin_Dious_Commercial_Site.Migrations
{
    [DbContext(typeof(VinDiousContext))]
    partial class VinDiousContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Vin_Dious_Commercial_Site.Models.CustomerAddressBase", b =>
                {
                    b.Property<int>("address_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("firstname")
                        .HasColumnType("int");

                    b.Property<string>("lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("user_id1")
                        .HasColumnType("int");

                    b.Property<int>("zipcode")
                        .HasColumnType("int");

                    b.HasKey("address_id");

                    b.HasIndex("user_id1");

                    b.ToTable("CustomerAddressBase");
                });

            modelBuilder.Entity("Vin_Dious_Commercial_Site.Models.DiscountBase", b =>
                {
                    b.Property<int>("discount_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("active")
                        .HasColumnType("bit");

                    b.Property<decimal>("discount_percent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("product_id1")
                        .HasColumnType("int");

                    b.HasKey("discount_id");

                    b.HasIndex("product_id1");

                    b.ToTable("DiscountBase");
                });

            modelBuilder.Entity("Vin_Dious_Commercial_Site.Models.OrderStatusBase", b =>
                {
                    b.Property<int>("status_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("status_id");

                    b.ToTable("OrderStatusBase");
                });

            modelBuilder.Entity("Vin_Dious_Commercial_Site.Models.OrdersBase", b =>
                {
                    b.Property<int>("orders_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("order_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int?>("status_id1")
                        .HasColumnType("int");

                    b.Property<int?>("user_id1")
                        .HasColumnType("int");

                    b.HasKey("orders_id");

                    b.HasIndex("status_id1");

                    b.HasIndex("user_id1");

                    b.ToTable("OrdersBase");
                });

            modelBuilder.Entity("Vin_Dious_Commercial_Site.Models.OrdersDetailsBase", b =>
                {
                    b.Property<int>("order_details_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("orders_id1")
                        .HasColumnType("int");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("product_id1")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("order_details_id");

                    b.HasIndex("orders_id1");

                    b.HasIndex("product_id1");

                    b.ToTable("OrdersDetailsBase");
                });

            modelBuilder.Entity("Vin_Dious_Commercial_Site.Models.OrdersInventoryBase", b =>
                {
                    b.Property<int>("inventory_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("product_id1")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int?>("status_id1")
                        .HasColumnType("int");

                    b.Property<int?>("supplier_id1")
                        .HasColumnType("int");

                    b.HasKey("inventory_id");

                    b.HasIndex("product_id1");

                    b.HasIndex("status_id1");

                    b.HasIndex("supplier_id1");

                    b.ToTable("OrdersInventoryBase");
                });

            modelBuilder.Entity("Vin_Dious_Commercial_Site.Models.ProductBase", b =>
                {
                    b.Property<int>("product_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("brand_id1")
                        .HasColumnType("int");

                    b.Property<int?>("category_idcategoy_id")
                        .HasColumnType("int");

                    b.Property<string>("creation_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int?>("supplier_id1")
                        .HasColumnType("int");

                    b.HasKey("product_id");

                    b.HasIndex("brand_id1");

                    b.HasIndex("category_idcategoy_id");

                    b.HasIndex("supplier_id1");

                    b.ToTable("ProductBase");
                });

            modelBuilder.Entity("Vin_Dious_Commercial_Site.Models.ProductBrandBase", b =>
                {
                    b.Property<int>("brand_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("brand_id");

                    b.ToTable("ProductBrandBase");
                });

            modelBuilder.Entity("Vin_Dious_Commercial_Site.Models.ProductCategoryBase", b =>
                {
                    b.Property<int>("categoy_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("categoy_id");

                    b.ToTable("ProductCategoryBase");
                });

            modelBuilder.Entity("Vin_Dious_Commercial_Site.Models.RoleBase", b =>
                {
                    b.Property<int>("role_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("role_id");

                    b.ToTable("RoleBase");
                });

            modelBuilder.Entity("Vin_Dious_Commercial_Site.Models.SupplierBase", b =>
                {
                    b.Property<int>("supplier_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("zipcode")
                        .HasColumnType("int");

                    b.HasKey("supplier_id");

                    b.ToTable("SupplierBase");
                });

            modelBuilder.Entity("Vin_Dious_Commercial_Site.Models.WebUserBase", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("role_id1")
                        .HasColumnType("int");

                    b.HasKey("user_id");

                    b.HasIndex("role_id1");

                    b.ToTable("WebUserBase");
                });

            modelBuilder.Entity("Vin_Dious_Commercial_Site.Models.CustomerAddressBase", b =>
                {
                    b.HasOne("Vin_Dious_Commercial_Site.Models.WebUserBase", "user_id")
                        .WithMany()
                        .HasForeignKey("user_id1");

                    b.Navigation("user_id");
                });

            modelBuilder.Entity("Vin_Dious_Commercial_Site.Models.DiscountBase", b =>
                {
                    b.HasOne("Vin_Dious_Commercial_Site.Models.ProductBase", "product_id")
                        .WithMany()
                        .HasForeignKey("product_id1");

                    b.Navigation("product_id");
                });

            modelBuilder.Entity("Vin_Dious_Commercial_Site.Models.OrdersBase", b =>
                {
                    b.HasOne("Vin_Dious_Commercial_Site.Models.OrderStatusBase", "status_id")
                        .WithMany()
                        .HasForeignKey("status_id1");

                    b.HasOne("Vin_Dious_Commercial_Site.Models.WebUserBase", "user_id")
                        .WithMany()
                        .HasForeignKey("user_id1");

                    b.Navigation("status_id");

                    b.Navigation("user_id");
                });

            modelBuilder.Entity("Vin_Dious_Commercial_Site.Models.OrdersDetailsBase", b =>
                {
                    b.HasOne("Vin_Dious_Commercial_Site.Models.OrdersBase", "orders_id")
                        .WithMany()
                        .HasForeignKey("orders_id1");

                    b.HasOne("Vin_Dious_Commercial_Site.Models.ProductBase", "product_id")
                        .WithMany()
                        .HasForeignKey("product_id1");

                    b.Navigation("orders_id");

                    b.Navigation("product_id");
                });

            modelBuilder.Entity("Vin_Dious_Commercial_Site.Models.OrdersInventoryBase", b =>
                {
                    b.HasOne("Vin_Dious_Commercial_Site.Models.ProductBase", "product_id")
                        .WithMany()
                        .HasForeignKey("product_id1");

                    b.HasOne("Vin_Dious_Commercial_Site.Models.OrderStatusBase", "status_id")
                        .WithMany()
                        .HasForeignKey("status_id1");

                    b.HasOne("Vin_Dious_Commercial_Site.Models.SupplierBase", "supplier_id")
                        .WithMany()
                        .HasForeignKey("supplier_id1");

                    b.Navigation("product_id");

                    b.Navigation("status_id");

                    b.Navigation("supplier_id");
                });

            modelBuilder.Entity("Vin_Dious_Commercial_Site.Models.ProductBase", b =>
                {
                    b.HasOne("Vin_Dious_Commercial_Site.Models.ProductBrandBase", "brand_id")
                        .WithMany()
                        .HasForeignKey("brand_id1");

                    b.HasOne("Vin_Dious_Commercial_Site.Models.ProductCategoryBase", "category_id")
                        .WithMany()
                        .HasForeignKey("category_idcategoy_id");

                    b.HasOne("Vin_Dious_Commercial_Site.Models.SupplierBase", "supplier_id")
                        .WithMany()
                        .HasForeignKey("supplier_id1");

                    b.Navigation("brand_id");

                    b.Navigation("category_id");

                    b.Navigation("supplier_id");
                });

            modelBuilder.Entity("Vin_Dious_Commercial_Site.Models.WebUserBase", b =>
                {
                    b.HasOne("Vin_Dious_Commercial_Site.Models.RoleBase", "role_id")
                        .WithMany()
                        .HasForeignKey("role_id1");

                    b.Navigation("role_id");
                });
#pragma warning restore 612, 618
        }
    }
}
