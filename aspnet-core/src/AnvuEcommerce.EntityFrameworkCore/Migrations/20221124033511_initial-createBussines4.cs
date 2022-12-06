using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnvuEcommerce.Migrations
{
    public partial class initialcreateBussines4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductReviews",
                table: "ProductReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductAttributeVarchars",
                table: "ProductAttributeVarchars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductAttributeTexts",
                table: "ProductAttributeTexts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductAttributeInts",
                table: "ProductAttributeInts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductAttributeDecimals",
                table: "ProductAttributeDecimals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductAttributeDateTimes",
                table: "ProductAttributeDateTimes");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "AppTags");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "AppProducts");

            migrationBuilder.RenameTable(
                name: "ProductReviews",
                newName: "AppProductReviews");

            migrationBuilder.RenameTable(
                name: "ProductAttributeVarchars",
                newName: "AppProductAttributeVarchars");

            migrationBuilder.RenameTable(
                name: "ProductAttributeTexts",
                newName: "AppProductAttributeTexts");

            migrationBuilder.RenameTable(
                name: "ProductAttributeInts",
                newName: "AppProductAttributeInts");

            migrationBuilder.RenameTable(
                name: "ProductAttributeDecimals",
                newName: "AppProductAttributeDecimals");

            migrationBuilder.RenameTable(
                name: "ProductAttributeDateTimes",
                newName: "AppProductAttributeDateTimes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AppTags",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppTags",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ThumbnailPicture",
                table: "AppProducts",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "AppProducts",
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
                table: "AppProducts",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SKU",
                table: "AppProducts",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AppProducts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "AppProducts",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "AppProductReviews",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "AppProductAttributeVarchars",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppTags",
                table: "AppTags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppProducts",
                table: "AppProducts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppProductReviews",
                table: "AppProductReviews",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppProductAttributeVarchars",
                table: "AppProductAttributeVarchars",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppProductAttributeTexts",
                table: "AppProductAttributeTexts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppProductAttributeInts",
                table: "AppProductAttributeInts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppProductAttributeDecimals",
                table: "AppProductAttributeDecimals",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppProductAttributeDateTimes",
                table: "AppProductAttributeDateTimes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppTags",
                table: "AppTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppProducts",
                table: "AppProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppProductReviews",
                table: "AppProductReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppProductAttributeVarchars",
                table: "AppProductAttributeVarchars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppProductAttributeTexts",
                table: "AppProductAttributeTexts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppProductAttributeInts",
                table: "AppProductAttributeInts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppProductAttributeDecimals",
                table: "AppProductAttributeDecimals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppProductAttributeDateTimes",
                table: "AppProductAttributeDateTimes");

            migrationBuilder.RenameTable(
                name: "AppTags",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "AppProducts",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "AppProductReviews",
                newName: "ProductReviews");

            migrationBuilder.RenameTable(
                name: "AppProductAttributeVarchars",
                newName: "ProductAttributeVarchars");

            migrationBuilder.RenameTable(
                name: "AppProductAttributeTexts",
                newName: "ProductAttributeTexts");

            migrationBuilder.RenameTable(
                name: "AppProductAttributeInts",
                newName: "ProductAttributeInts");

            migrationBuilder.RenameTable(
                name: "AppProductAttributeDecimals",
                newName: "ProductAttributeDecimals");

            migrationBuilder.RenameTable(
                name: "AppProductAttributeDateTimes",
                newName: "ProductAttributeDateTimes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Tags",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ThumbnailPicture",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SeoMetaDescription",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SKU",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "ProductReviews",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "ProductAttributeVarchars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductReviews",
                table: "ProductReviews",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductAttributeVarchars",
                table: "ProductAttributeVarchars",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductAttributeTexts",
                table: "ProductAttributeTexts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductAttributeInts",
                table: "ProductAttributeInts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductAttributeDecimals",
                table: "ProductAttributeDecimals",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductAttributeDateTimes",
                table: "ProductAttributeDateTimes",
                column: "Id");
        }
    }
}
