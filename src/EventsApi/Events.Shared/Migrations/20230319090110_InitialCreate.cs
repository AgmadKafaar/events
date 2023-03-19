using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Events.Shared.Migrations
{
    /// <summary>
    /// The initial create class
    /// </summary>
    /// <seealso cref="Migration"/>
    public partial class InitialCreate : Migration
    {
        /// <summary>
        /// Ups the migration builder
        /// </summary>
        /// <param name="migrationBuilder">The migration builder</param>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttendeesType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendeesType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    EndTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StartTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attendees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AttendeeTypeId = table.Column<int>(type: "INTEGER", nullable: true),
                    EmailAddress = table.Column<string>(type: "TEXT", nullable: false),
                    IsAttending = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendees_AttendeesType_AttendeeTypeId",
                        column: x => x.AttendeeTypeId,
                        principalTable: "AttendeesType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AttendeeEvent",
                columns: table => new
                {
                    AttendeesId = table.Column<int>(type: "INTEGER", nullable: false),
                    EventsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendeeEvent", x => new { x.AttendeesId, x.EventsId });
                    table.ForeignKey(
                        name: "FK_AttendeeEvent_Attendees_AttendeesId",
                        column: x => x.AttendeesId,
                        principalTable: "Attendees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttendeeEvent_Events_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttendeeEvent_EventsId",
                table: "AttendeeEvent",
                column: "EventsId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_AttendeeTypeId",
                table: "Attendees",
                column: "AttendeeTypeId");
        }

        /// <summary>
        /// Downs the migration builder
        /// </summary>
        /// <param name="migrationBuilder">The migration builder</param>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendeeEvent");

            migrationBuilder.DropTable(
                name: "Attendees");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "AttendeesType");
        }
    }
}