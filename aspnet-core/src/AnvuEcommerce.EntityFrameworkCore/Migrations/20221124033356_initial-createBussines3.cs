using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnvuEcommerce.Migrations
{
    public partial class initialcreateBussines3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Manufacturers",
                table: "Manufacturers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InventoryTickets",
                table: "InventoryTickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InventoryTicketItems",
                table: "InventoryTicketItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories");

            migrationBuilder.RenameTable(
                name: "Manufacturers",
                newName: "AppManufacturers");

            migrationBuilder.RenameTable(
                name: "InventoryTickets",
                newName: "AppInventoryTickets");

            migrationBuilder.RenameTable(
                name: "InventoryTicketItems",
                newName: "AppInventoryTicketItems");

            migrationBuilder.RenameTable(
                name: "Inventories",
                newName: "AppInventories");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "AppManufacturers",
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
                table: "AppManufacturers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoverPicture",
                table: "AppManufacturers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "AppManufacturers",
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
                table: "AppInventoryTickets",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SKU",
                table: "AppInventoryTicketItems",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BatchNumber",
                table: "AppInventoryTicketItems",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SKU",
                table: "AppInventories",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppManufacturers",
                table: "AppManufacturers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppInventoryTickets",
                table: "AppInventoryTickets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppInventoryTicketItems",
                table: "AppInventoryTicketItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppInventories",
                table: "AppInventories",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppManufacturers",
                table: "AppManufacturers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppInventoryTickets",
                table: "AppInventoryTickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppInventoryTicketItems",
                table: "AppInventoryTicketItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppInventories",
                table: "AppInventories");

            migrationBuilder.RenameTable(
                name: "AppManufacturers",
                newName: "Manufacturers");

            migrationBuilder.RenameTable(
                name: "AppInventoryTickets",
                newName: "InventoryTickets");

            migrationBuilder.RenameTable(
                name: "AppInventoryTicketItems",
                newName: "InventoryTicketItems");

            migrationBuilder.RenameTable(
                name: "AppInventories",
                newName: "Inventories");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Manufacturers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Manufacturers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CoverPicture",
                table: "Manufacturers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Manufacturers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "InventoryTickets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SKU",
                table: "InventoryTicketItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "BatchNumber",
                table: "InventoryTicketItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SKU",
                table: "Inventories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manufacturers",
                table: "Manufacturers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InventoryTickets",
                table: "InventoryTickets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InventoryTicketItems",
                table: "InventoryTicketItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories",
                column: "Id");
        }
    }
}
