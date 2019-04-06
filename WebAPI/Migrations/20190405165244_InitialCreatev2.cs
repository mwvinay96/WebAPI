using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class InitialCreatev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PaymentDetails",
                columns: new[] { "PMId", "CVV", "CardNumber", "CardOwnerName", "ExpirationDate" },
                values: new object[] { 1, "256", "1234567890123456", "Vinay Adiga", "12/12" });

            migrationBuilder.InsertData(
                table: "PaymentDetails",
                columns: new[] { "PMId", "CVV", "CardNumber", "CardOwnerName", "ExpirationDate" },
                values: new object[] { 2, "256", "0123456789987456", "Pushpendra Singh", "01/12" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaymentDetails",
                keyColumn: "PMId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentDetails",
                keyColumn: "PMId",
                keyValue: 2);
        }
    }
}
