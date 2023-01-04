﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnvuEcommerce.Migrations
{
    public partial class ProductCategoryAddFieldProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "AppProducts",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategorySlug",
                table: "AppProducts",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "AppProducts");

            migrationBuilder.DropColumn(
                name: "CategorySlug",
                table: "AppProducts");
        }
    }
}
