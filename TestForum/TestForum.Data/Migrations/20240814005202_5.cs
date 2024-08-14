using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestForum.Data.Migrations
{
    /// <inheritdoc />
    public partial class _5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_AspNetUsers_UserId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Forum_ForumId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_PostReply_AspNetUsers_UserId",
                table: "PostReply");

            migrationBuilder.DropForeignKey(
                name: "FK_PostReply_Post_PostId",
                table: "PostReply");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostReply",
                table: "PostReply");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post",
                table: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Forum",
                table: "Forum");

            migrationBuilder.RenameTable(
                name: "PostReply",
                newName: "PostReplys");

            migrationBuilder.RenameTable(
                name: "Post",
                newName: "Posts");

            migrationBuilder.RenameTable(
                name: "Forum",
                newName: "Forums");

            migrationBuilder.RenameIndex(
                name: "IX_PostReply_UserId",
                table: "PostReplys",
                newName: "IX_PostReplys_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_PostReply_PostId",
                table: "PostReplys",
                newName: "IX_PostReplys_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_UserId",
                table: "Posts",
                newName: "IX_Posts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_ForumId",
                table: "Posts",
                newName: "IX_Posts_ForumId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostReplys",
                table: "PostReplys",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Forums",
                table: "Forums",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PostReplys_AspNetUsers_UserId",
                table: "PostReplys",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PostReplys_Posts_PostId",
                table: "PostReplys",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_UserId",
                table: "Posts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Forums_ForumId",
                table: "Posts",
                column: "ForumId",
                principalTable: "Forums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostReplys_AspNetUsers_UserId",
                table: "PostReplys");

            migrationBuilder.DropForeignKey(
                name: "FK_PostReplys_Posts_PostId",
                table: "PostReplys");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_UserId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Forums_ForumId",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostReplys",
                table: "PostReplys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Forums",
                table: "Forums");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "Post");

            migrationBuilder.RenameTable(
                name: "PostReplys",
                newName: "PostReply");

            migrationBuilder.RenameTable(
                name: "Forums",
                newName: "Forum");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_UserId",
                table: "Post",
                newName: "IX_Post_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_ForumId",
                table: "Post",
                newName: "IX_Post_ForumId");

            migrationBuilder.RenameIndex(
                name: "IX_PostReplys_UserId",
                table: "PostReply",
                newName: "IX_PostReply_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_PostReplys_PostId",
                table: "PostReply",
                newName: "IX_PostReply_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post",
                table: "Post",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostReply",
                table: "PostReply",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Forum",
                table: "Forum",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_AspNetUsers_UserId",
                table: "Post",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Forum_ForumId",
                table: "Post",
                column: "ForumId",
                principalTable: "Forum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostReply_AspNetUsers_UserId",
                table: "PostReply",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostReply_Post_PostId",
                table: "PostReply",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
