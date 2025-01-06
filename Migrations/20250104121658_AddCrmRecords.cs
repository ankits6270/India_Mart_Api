using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace India_Mart_Api.Migrations
{
    /// <inheritdoc />
    public partial class AddCrmRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CrmRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UNIQUE_QUERY_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QUERY_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QUERY_TIME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SENDER_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SENDER_MOBILE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SENDER_EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SUBJECT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SENDER_COMPANY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SENDER_ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SENDER_CITY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SENDER_STATE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SENDER_PINCODE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SENDER_COUNTRY_ISO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SENDER_MOBILE_ALT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SENDER_PHONE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SENDER_PHONE_ALT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SENDER_EMAIL_ALT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QUERY_PRODUCT_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QUERY_MESSAGE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QUERY_MCAT_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CALL_DURATION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RECEIVER_MOBILE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RECEIVER_CATALOG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmRecords", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrmRecords");
        }
    }
}
