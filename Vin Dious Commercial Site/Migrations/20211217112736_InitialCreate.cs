using Microsoft.EntityFrameworkCore.Migrations;

namespace Vin_Dious_Commercial_Site.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderStatusBase",
                columns: table => new
                {
                    status_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatusBase", x => x.status_id);
                });

            migrationBuilder.CreateTable(
                name: "ProductBrandBase",
                columns: table => new
                {
                    brand_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBrandBase", x => x.brand_id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategoryBase",
                columns: table => new
                {
                    categoy_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategoryBase", x => x.categoy_id);
                });

            migrationBuilder.CreateTable(
                name: "RoleBase",
                columns: table => new
                {
                    role_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleBase", x => x.role_id);
                });

            migrationBuilder.CreateTable(
                name: "SupplierBase",
                columns: table => new
                {
                    supplier_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    zipcode = table.Column<int>(type: "int", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierBase", x => x.supplier_id);
                });

            migrationBuilder.CreateTable(
                name: "WebUserBase",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    role_id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebUserBase", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_WebUserBase_RoleBase_role_id1",
                        column: x => x.role_id1,
                        principalTable: "RoleBase",
                        principalColumn: "role_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductBase",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    creation_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    supplier_id1 = table.Column<int>(type: "int", nullable: true),
                    category_idcategoy_id = table.Column<int>(type: "int", nullable: true),
                    brand_id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBase", x => x.product_id);
                    table.ForeignKey(
                        name: "FK_ProductBase_ProductBrandBase_brand_id1",
                        column: x => x.brand_id1,
                        principalTable: "ProductBrandBase",
                        principalColumn: "brand_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductBase_ProductCategoryBase_category_idcategoy_id",
                        column: x => x.category_idcategoy_id,
                        principalTable: "ProductCategoryBase",
                        principalColumn: "categoy_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductBase_SupplierBase_supplier_id1",
                        column: x => x.supplier_id1,
                        principalTable: "SupplierBase",
                        principalColumn: "supplier_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddressBase",
                columns: table => new
                {
                    address_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zipcode = table.Column<int>(type: "int", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firstname = table.Column<int>(type: "int", nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddressBase", x => x.address_id);
                    table.ForeignKey(
                        name: "FK_CustomerAddressBase_WebUserBase_user_id1",
                        column: x => x.user_id1,
                        principalTable: "WebUserBase",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdersBase",
                columns: table => new
                {
                    orders_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    order_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    status_id1 = table.Column<int>(type: "int", nullable: true),
                    user_id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersBase", x => x.orders_id);
                    table.ForeignKey(
                        name: "FK_OrdersBase_OrderStatusBase_status_id1",
                        column: x => x.status_id1,
                        principalTable: "OrderStatusBase",
                        principalColumn: "status_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdersBase_WebUserBase_user_id1",
                        column: x => x.user_id1,
                        principalTable: "WebUserBase",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DiscountBase",
                columns: table => new
                {
                    discount_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    discount_percent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false),
                    product_id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountBase", x => x.discount_id);
                    table.ForeignKey(
                        name: "FK_DiscountBase_ProductBase_product_id1",
                        column: x => x.product_id1,
                        principalTable: "ProductBase",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdersInventoryBase",
                columns: table => new
                {
                    inventory_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    supplier_id1 = table.Column<int>(type: "int", nullable: true),
                    product_id1 = table.Column<int>(type: "int", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    status_id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersInventoryBase", x => x.inventory_id);
                    table.ForeignKey(
                        name: "FK_OrdersInventoryBase_OrderStatusBase_status_id1",
                        column: x => x.status_id1,
                        principalTable: "OrderStatusBase",
                        principalColumn: "status_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdersInventoryBase_ProductBase_product_id1",
                        column: x => x.product_id1,
                        principalTable: "ProductBase",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdersInventoryBase_SupplierBase_supplier_id1",
                        column: x => x.supplier_id1,
                        principalTable: "SupplierBase",
                        principalColumn: "supplier_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdersDetailsBase",
                columns: table => new
                {
                    order_details_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_id1 = table.Column<int>(type: "int", nullable: true),
                    orders_id1 = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersDetailsBase", x => x.order_details_id);
                    table.ForeignKey(
                        name: "FK_OrdersDetailsBase_OrdersBase_orders_id1",
                        column: x => x.orders_id1,
                        principalTable: "OrdersBase",
                        principalColumn: "orders_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdersDetailsBase_ProductBase_product_id1",
                        column: x => x.product_id1,
                        principalTable: "ProductBase",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddressBase_user_id1",
                table: "CustomerAddressBase",
                column: "user_id1");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountBase_product_id1",
                table: "DiscountBase",
                column: "product_id1");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersBase_status_id1",
                table: "OrdersBase",
                column: "status_id1");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersBase_user_id1",
                table: "OrdersBase",
                column: "user_id1");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersDetailsBase_orders_id1",
                table: "OrdersDetailsBase",
                column: "orders_id1");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersDetailsBase_product_id1",
                table: "OrdersDetailsBase",
                column: "product_id1");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersInventoryBase_product_id1",
                table: "OrdersInventoryBase",
                column: "product_id1");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersInventoryBase_status_id1",
                table: "OrdersInventoryBase",
                column: "status_id1");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersInventoryBase_supplier_id1",
                table: "OrdersInventoryBase",
                column: "supplier_id1");

            migrationBuilder.CreateIndex(
                name: "IX_ProductBase_brand_id1",
                table: "ProductBase",
                column: "brand_id1");

            migrationBuilder.CreateIndex(
                name: "IX_ProductBase_category_idcategoy_id",
                table: "ProductBase",
                column: "category_idcategoy_id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductBase_supplier_id1",
                table: "ProductBase",
                column: "supplier_id1");

            migrationBuilder.CreateIndex(
                name: "IX_WebUserBase_role_id1",
                table: "WebUserBase",
                column: "role_id1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerAddressBase");

            migrationBuilder.DropTable(
                name: "DiscountBase");

            migrationBuilder.DropTable(
                name: "OrdersDetailsBase");

            migrationBuilder.DropTable(
                name: "OrdersInventoryBase");

            migrationBuilder.DropTable(
                name: "OrdersBase");

            migrationBuilder.DropTable(
                name: "ProductBase");

            migrationBuilder.DropTable(
                name: "OrderStatusBase");

            migrationBuilder.DropTable(
                name: "WebUserBase");

            migrationBuilder.DropTable(
                name: "ProductBrandBase");

            migrationBuilder.DropTable(
                name: "ProductCategoryBase");

            migrationBuilder.DropTable(
                name: "SupplierBase");

            migrationBuilder.DropTable(
                name: "RoleBase");
        }
    }
}
