using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class DALExtensions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("21295476-2a13-4056-b076-1362c6629009"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("93a766de-4df0-4e68-80b2-3520b975d2a3"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("2b8be284-6b05-4528-809f-21c22c11c9de"), new Guid("98e0002d-19e4-446c-aa10-9c408632375d"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque nec erat varius, accumsan eros vitae, sodales risus. Vivamus volutpat tellus id sapien lacinia, vel fringilla leo condimentum. Curabitur accumsan, nunc sed pellentesque faucibus, dolor elit eleifend ligula, nec blandit dolor eros ut libero. Etiam a nulla quis urna accumsan placerat id in nisi. Donec et nibh leo. Donec tempus neque urna. Vivamus pulvinar erat egestas rutrum malesuada. Donec urna quam, tristique eu faucibus molestie, semper ut dui. Mauris vitae congue tortor. Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Admin Test", new DateTime(2023, 1, 12, 11, 30, 12, 454, DateTimeKind.Local).AddTicks(4306), null, null, new Guid("ffb69adc-97ed-448e-80ee-b4e8659f9a87"), false, null, null, "Visual Studio Deneme Makalesi", 15 },
                    { new Guid("ebf8e8e4-7cd1-427c-be46-ad2f5baf4b5e"), new Guid("a26ffa43-78a3-414b-89e7-83af238d4bd4"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque nec erat varius, accumsan eros vitae, sodales risus. Vivamus volutpat tellus id sapien lacinia, vel fringilla leo condimentum. Curabitur accumsan, nunc sed pellentesque faucibus, dolor elit eleifend ligula, nec blandit dolor eros ut libero. Etiam a nulla quis urna accumsan placerat id in nisi. Donec et nibh leo. Donec tempus neque urna. Vivamus pulvinar erat egestas rutrum malesuada. Donec urna quam, tristique eu faucibus molestie, semper ut dui. Mauris vitae congue tortor. Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Admin Test", new DateTime(2023, 1, 12, 11, 30, 12, 454, DateTimeKind.Local).AddTicks(4300), null, null, new Guid("34592e9f-8d43-4218-97b9-9b9e5a90a1a6"), false, null, null, "Asp.net Core Deneme Makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("98e0002d-19e4-446c-aa10-9c408632375d"),
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 11, 30, 12, 454, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a26ffa43-78a3-414b-89e7-83af238d4bd4"),
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 11, 30, 12, 454, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("34592e9f-8d43-4218-97b9-9b9e5a90a1a6"),
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 11, 30, 12, 454, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ffb69adc-97ed-448e-80ee-b4e8659f9a87"),
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 11, 30, 12, 454, DateTimeKind.Local).AddTicks(4541));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2b8be284-6b05-4528-809f-21c22c11c9de"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ebf8e8e4-7cd1-427c-be46-ad2f5baf4b5e"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("21295476-2a13-4056-b076-1362c6629009"), new Guid("98e0002d-19e4-446c-aa10-9c408632375d"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque nec erat varius, accumsan eros vitae, sodales risus. Vivamus volutpat tellus id sapien lacinia, vel fringilla leo condimentum. Curabitur accumsan, nunc sed pellentesque faucibus, dolor elit eleifend ligula, nec blandit dolor eros ut libero. Etiam a nulla quis urna accumsan placerat id in nisi. Donec et nibh leo. Donec tempus neque urna. Vivamus pulvinar erat egestas rutrum malesuada. Donec urna quam, tristique eu faucibus molestie, semper ut dui. Mauris vitae congue tortor. Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Admin Test", new DateTime(2023, 1, 11, 14, 21, 54, 696, DateTimeKind.Local).AddTicks(6753), null, null, new Guid("ffb69adc-97ed-448e-80ee-b4e8659f9a87"), false, null, null, "Visual Studio Deneme Makalesi", 15 },
                    { new Guid("93a766de-4df0-4e68-80b2-3520b975d2a3"), new Guid("a26ffa43-78a3-414b-89e7-83af238d4bd4"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque nec erat varius, accumsan eros vitae, sodales risus. Vivamus volutpat tellus id sapien lacinia, vel fringilla leo condimentum. Curabitur accumsan, nunc sed pellentesque faucibus, dolor elit eleifend ligula, nec blandit dolor eros ut libero. Etiam a nulla quis urna accumsan placerat id in nisi. Donec et nibh leo. Donec tempus neque urna. Vivamus pulvinar erat egestas rutrum malesuada. Donec urna quam, tristique eu faucibus molestie, semper ut dui. Mauris vitae congue tortor. Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Admin Test", new DateTime(2023, 1, 11, 14, 21, 54, 696, DateTimeKind.Local).AddTicks(6746), null, null, new Guid("34592e9f-8d43-4218-97b9-9b9e5a90a1a6"), false, null, null, "Asp.net Core Deneme Makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("98e0002d-19e4-446c-aa10-9c408632375d"),
                column: "CreatedDate",
                value: new DateTime(2023, 1, 11, 14, 21, 54, 696, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a26ffa43-78a3-414b-89e7-83af238d4bd4"),
                column: "CreatedDate",
                value: new DateTime(2023, 1, 11, 14, 21, 54, 696, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("34592e9f-8d43-4218-97b9-9b9e5a90a1a6"),
                column: "CreatedDate",
                value: new DateTime(2023, 1, 11, 14, 21, 54, 696, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ffb69adc-97ed-448e-80ee-b4e8659f9a87"),
                column: "CreatedDate",
                value: new DateTime(2023, 1, 11, 14, 21, 54, 696, DateTimeKind.Local).AddTicks(7000));
        }
    }
}
