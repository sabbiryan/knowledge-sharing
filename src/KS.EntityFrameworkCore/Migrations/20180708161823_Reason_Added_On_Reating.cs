using Microsoft.EntityFrameworkCore.Migrations;

namespace KS.Migrations
{
    public partial class Reason_Added_On_Reating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "QuestionRatings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuestionViewCounts_CreatorUserId",
                table: "QuestionViewCounts",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionses_CreatorUserId",
                table: "Questionses",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionRatings_CreatorUserId",
                table: "QuestionRatings",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionCategories_CreatorUserId",
                table: "QuestionCategories",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswers_CreatorUserId",
                table: "QuestionAnswers",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswerRatings_CreatorUserId",
                table: "QuestionAnswerRatings",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswerComments_CreatorUserId",
                table: "QuestionAnswerComments",
                column: "CreatorUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAnswerComments_AbpUsers_CreatorUserId",
                table: "QuestionAnswerComments",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAnswerRatings_AbpUsers_CreatorUserId",
                table: "QuestionAnswerRatings",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAnswers_AbpUsers_CreatorUserId",
                table: "QuestionAnswers",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionCategories_AbpUsers_CreatorUserId",
                table: "QuestionCategories",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionRatings_AbpUsers_CreatorUserId",
                table: "QuestionRatings",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionses_AbpUsers_CreatorUserId",
                table: "Questionses",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionViewCounts_AbpUsers_CreatorUserId",
                table: "QuestionViewCounts",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAnswerComments_AbpUsers_CreatorUserId",
                table: "QuestionAnswerComments");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAnswerRatings_AbpUsers_CreatorUserId",
                table: "QuestionAnswerRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAnswers_AbpUsers_CreatorUserId",
                table: "QuestionAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionCategories_AbpUsers_CreatorUserId",
                table: "QuestionCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionRatings_AbpUsers_CreatorUserId",
                table: "QuestionRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionses_AbpUsers_CreatorUserId",
                table: "Questionses");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionViewCounts_AbpUsers_CreatorUserId",
                table: "QuestionViewCounts");

            migrationBuilder.DropIndex(
                name: "IX_QuestionViewCounts_CreatorUserId",
                table: "QuestionViewCounts");

            migrationBuilder.DropIndex(
                name: "IX_Questionses_CreatorUserId",
                table: "Questionses");

            migrationBuilder.DropIndex(
                name: "IX_QuestionRatings_CreatorUserId",
                table: "QuestionRatings");

            migrationBuilder.DropIndex(
                name: "IX_QuestionCategories_CreatorUserId",
                table: "QuestionCategories");

            migrationBuilder.DropIndex(
                name: "IX_QuestionAnswers_CreatorUserId",
                table: "QuestionAnswers");

            migrationBuilder.DropIndex(
                name: "IX_QuestionAnswerRatings_CreatorUserId",
                table: "QuestionAnswerRatings");

            migrationBuilder.DropIndex(
                name: "IX_QuestionAnswerComments_CreatorUserId",
                table: "QuestionAnswerComments");

            migrationBuilder.DropColumn(
                name: "Reason",
                table: "QuestionRatings");
        }
    }
}
