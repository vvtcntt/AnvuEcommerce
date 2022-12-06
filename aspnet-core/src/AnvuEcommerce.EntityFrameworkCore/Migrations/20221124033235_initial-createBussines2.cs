using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnvuEcommerce.Migrations
{
    public partial class initialcreateBussines2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PromotionUsageHistories",
                table: "PromotionUsageHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Promotions",
                table: "Promotions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PromotionProducts",
                table: "PromotionProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PromotionManufacturers",
                table: "PromotionManufacturers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PromotionCategories",
                table: "PromotionCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderTransactions",
                table: "OrderTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "PromotionUsageHistories",
                newName: "AppPromotionUsageHistories");

            migrationBuilder.RenameTable(
                name: "Promotions",
                newName: "AppPromotions");

            migrationBuilder.RenameTable(
                name: "PromotionProducts",
                newName: "AppPromotionProducts");

            migrationBuilder.RenameTable(
                name: "PromotionManufacturers",
                newName: "AppPromotionManufacturers");

            migrationBuilder.RenameTable(
                name: "PromotionCategories",
                newName: "AppPromotionCategories");

            migrationBuilder.RenameTable(
                name: "ProductCategories",
                newName: "AppProductCategories");

            migrationBuilder.RenameTable(
                name: "OrderTransactions",
                newName: "AppOrderTransactions");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "AppOrders");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AppPromotions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CouponCode",
                table: "AppPromotions",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "AppProductCategories",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SeoMetaDescription",
                table: "AppProductCategories",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AppProductCategories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoverPicture",
                table: "AppProductCategories",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "AppProductCategories",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "AppOrderTransactions",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPhoneNumber",
                table: "AppOrders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "AppOrders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerAddress",
                table: "AppOrders",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "AppOrders",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppPromotionUsageHistories",
                table: "AppPromotionUsageHistories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppPromotions",
                table: "AppPromotions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppPromotionProducts",
                table: "AppPromotionProducts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppPromotionManufacturers",
                table: "AppPromotionManufacturers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppPromotionCategories",
                table: "AppPromotionCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppProductCategories",
                table: "AppProductCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppOrderTransactions",
                table: "AppOrderTransactions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppOrders",
                table: "AppOrders",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppPromotionUsageHistories",
                table: "AppPromotionUsageHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppPromotions",
                table: "AppPromotions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppPromotionProducts",
                table: "AppPromotionProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppPromotionManufacturers",
                table: "AppPromotionManufacturers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppPromotionCategories",
                table: "AppPromotionCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppProductCategories",
                table: "AppProductCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppOrderTransactions",
                table: "AppOrderTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppOrders",
                table: "AppOrders");

            migrationBuilder.RenameTable(
                name: "AppPromotionUsageHistories",
                newName: "PromotionUsageHistories");

            migrationBuilder.RenameTable(
                name: "AppPromotions",
                newName: "Promotions");

            migrationBuilder.RenameTable(
                name: "AppPromotionProducts",
                newName: "PromotionProducts");

            migrationBuilder.RenameTable(
                name: "AppPromotionManufacturers",
                newName: "PromotionManufacturers");

            migrationBuilder.RenameTable(
                name: "AppPromotionCategories",
                newName: "PromotionCategories");

            migrationBuilder.RenameTable(
                name: "AppProductCategories",
                newName: "ProductCategories");

            migrationBuilder.RenameTable(
                name: "AppOrderTransactions",
                newName: "OrderTransactions");

            migrationBuilder.RenameTable(
                name: "AppOrders",
                newName: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Promotions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CouponCode",
                table: "Promotions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "ProductCategories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SeoMetaDescription",
                table: "ProductCategories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProductCategories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CoverPicture",
                table: "ProductCategories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "ProductCategories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "OrderTransactions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPhoneNumber",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerAddress",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PromotionUsageHistories",
                table: "PromotionUsageHistories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Promotions",
                table: "Promotions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PromotionProducts",
                table: "PromotionProducts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PromotionManufacturers",
                table: "PromotionManufacturers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PromotionCategories",
                table: "PromotionCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderTransactions",
                table: "OrderTransactions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");
        }
    }
}
