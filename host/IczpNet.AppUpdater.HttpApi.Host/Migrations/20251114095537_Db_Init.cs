using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IczpNet.AppUpdater.Migrations
{
    /// <inheritdoc />
    public partial class Db_Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUpdater_AppClient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    AppId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DevDevices = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUpdater_AppClient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUpdater_AppDevice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    DeviceType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    DeviceId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUpdater_AppDevice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUpdater_AppVersion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Version = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VersionCode = table.Column<long>(type: "bigint", nullable: false),
                    AppId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Platform = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    Features = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PkgUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IssueDate = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsForce = table.Column<bool>(type: "bit", nullable: false),
                    IsWidget = table.Column<bool>(type: "bit", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUpdater_AppVersion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUpdater_AppVersion_AppUpdater_AppClient_AppClientId",
                        column: x => x.AppClientId,
                        principalTable: "AppUpdater_AppClient",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppUpdater_AppVersionDevice",
                columns: table => new
                {
                    AppDeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppVersionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUpdater_AppVersionDevice", x => new { x.AppVersionId, x.AppDeviceId });
                    table.ForeignKey(
                        name: "FK_AppUpdater_AppVersionDevice_AppUpdater_AppDevice_AppDeviceId",
                        column: x => x.AppDeviceId,
                        principalTable: "AppUpdater_AppDevice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUpdater_AppVersionDevice_AppUpdater_AppVersion_AppDeviceId",
                        column: x => x.AppDeviceId,
                        principalTable: "AppUpdater_AppVersion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUpdater_AppClient_AppId",
                table: "AppUpdater_AppClient",
                column: "AppId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUpdater_AppVersion_AppClientId",
                table: "AppUpdater_AppVersion",
                column: "AppClientId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUpdater_AppVersion_AppClientId_VersionCode",
                table: "AppUpdater_AppVersion",
                columns: new[] { "AppClientId", "VersionCode" },
                unique: true,
                descending: new[] { false, true },
                filter: "[AppClientId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AppUpdater_AppVersionDevice_AppDeviceId",
                table: "AppUpdater_AppVersionDevice",
                column: "AppDeviceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUpdater_AppVersionDevice");

            migrationBuilder.DropTable(
                name: "AppUpdater_AppDevice");

            migrationBuilder.DropTable(
                name: "AppUpdater_AppVersion");

            migrationBuilder.DropTable(
                name: "AppUpdater_AppClient");
        }
    }
}
