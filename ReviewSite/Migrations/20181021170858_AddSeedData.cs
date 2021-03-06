﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewSite.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CategoryId", "Content", "ImageUrl", "Title" },
                values: new object[] { 3, 2, "Burnt type Corgis have mostly black fur with partial brown and white mixed in. In other words, you left your piece of bread in the toaster for far too long and it got burnt.", "/Images/blackCorgi.jpg", "Corgi Type: Burnt" });
        }
    }
}
