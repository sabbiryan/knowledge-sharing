using Microsoft.EntityFrameworkCore.Migrations;

namespace KS.Migrations
{
    public partial class RatingValue_Added_On_Question_And_QuestionAnswer_Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "RatingValue",
                table: "Questionses",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "RatingValue",
                table: "QuestionAnswers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "QuestionAnswerRatings",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RatingValue",
                table: "Questionses");

            migrationBuilder.DropColumn(
                name: "RatingValue",
                table: "QuestionAnswers");

            migrationBuilder.DropColumn(
                name: "Reason",
                table: "QuestionAnswerRatings");
        }
    }
}
