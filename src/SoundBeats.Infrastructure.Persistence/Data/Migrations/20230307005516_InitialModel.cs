using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoundBeats.Infrastructure.Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISO2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISO3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastDeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastDeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Musician",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastDeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musician", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReviewerProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastDeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewerProfile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastDeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artist_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Album",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    CoverUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastDeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Album_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupMember",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JoinInYear = table.Column<int>(type: "int", nullable: false),
                    LeftYear = table.Column<int>(type: "int", nullable: false),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    MusicianId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastDeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupMember_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupMember_Musician_MusicianId",
                        column: x => x.MusicianId,
                        principalTable: "Musician",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Song",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrackNumber = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Length = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastDeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Song_Album_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Song_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SongReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ranking = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SongId = table.Column<int>(type: "int", nullable: false),
                    ReviewerProfileId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastDeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SongReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SongReview_ReviewerProfile_ReviewerProfileId",
                        column: x => x.ReviewerProfileId,
                        principalTable: "ReviewerProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SongReview_Song_SongId",
                        column: x => x.SongId,
                        principalTable: "Song",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeleteDate", "ISO2", "ISO3", "IsDeleted", "LastDeletedBy", "LastModifiedBy", "LastModifiedDate", "NameEn", "NameEs" },
                values: new object[,]
                {
                    { 1, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5748), null, "AD", "AND", false, null, null, null, " ", "Andorra" },
                    { 2, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5777), null, "AE", "ARE", false, null, null, null, " ", "Emiratos Árabes Unidos" },
                    { 3, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5783), null, "AF", "AFG", false, null, null, null, " ", "Afganistán" },
                    { 4, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5788), null, "AG", "ATG", false, null, null, null, " ", "Antigua y Barbuda" },
                    { 5, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5793), null, "AI", "AIA", false, null, null, null, " ", "Anguila" },
                    { 6, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5799), null, "AL", "ALB", false, null, null, null, " ", "Albania" },
                    { 7, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5804), null, "AL", "ALB", false, null, null, null, " ", "Albania" },
                    { 8, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5810), null, "AM", "ARM", false, null, null, null, " ", "Armenia" },
                    { 9, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5816), null, "AN", "ANT", false, null, null, null, " ", "Antillas Holandesas" },
                    { 10, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5821), null, "AO", "AGO", false, null, null, null, " ", "Angola" },
                    { 11, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5827), null, "AQ", "ATA", false, null, null, null, " ", "Antártida" },
                    { 12, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5834), null, "AR", "ARG", false, null, null, null, " ", "Argentina" },
                    { 13, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5839), null, "AS", "ASM", false, null, null, null, " ", "Samoa Americana" },
                    { 14, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5844), null, "AT", "AUT", false, null, null, null, " ", "Austria" },
                    { 15, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5849), null, "AU", "AUS", false, null, null, null, " ", "Australia" },
                    { 16, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5855), null, "AW", "ABW", false, null, null, null, " ", "Aruba" },
                    { 17, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5861), null, "AX", "ALA", false, null, null, null, " ", "Islas Aland" },
                    { 18, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5866), null, "AZ", "AZE", false, null, null, null, " ", "Azerbaiyán" },
                    { 19, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5874), null, "BA", "BIH", false, null, null, null, " ", "Bosnia y Herzegovina" },
                    { 20, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5879), null, "BB", "BRB", false, null, null, null, " ", "Barbados" },
                    { 21, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5885), null, "BD", "BGD", false, null, null, null, " ", "Bangladesh" },
                    { 22, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5890), null, "BE", "BEL", false, null, null, null, " ", "Bélgica" },
                    { 23, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5896), null, "BF", "BFA", false, null, null, null, " ", "Burkina Faso" },
                    { 24, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5901), null, "BG", "BGR", false, null, null, null, " ", "Bulgaria" },
                    { 25, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5907), null, "BH", "BHR", false, null, null, null, " ", "Bahrein" },
                    { 26, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5912), null, "BI", "BDI", false, null, null, null, " ", "Burundi" },
                    { 27, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5918), null, "BJ", "BEN", false, null, null, null, " ", "Benín" },
                    { 28, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5923), null, "BM", "BMU", false, null, null, null, " ", "Bermudas" },
                    { 29, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5929), null, "BN", "BRN", false, null, null, null, " ", "Brunei" },
                    { 30, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5934), null, "BO", "BOL", false, null, null, null, " ", "Bolivia" },
                    { 31, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5940), null, "BR", "BRA", false, null, null, null, " ", "Brasil" },
                    { 32, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5945), null, "BS", "BHS", false, null, null, null, " ", "Bahamas" },
                    { 33, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5951), null, "BT", "BTN", false, null, null, null, " ", "Bután" },
                    { 34, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5956), null, "BV", "BVT", false, null, null, null, " ", "Isla Bouvet" },
                    { 35, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5961), null, "BW", "BWA", false, null, null, null, " ", "Botswana" },
                    { 36, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5966), null, "BY", "BLR", false, null, null, null, " ", "Bielorusia" },
                    { 37, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5972), null, "BZ", "BLZ", false, null, null, null, " ", "Belice" },
                    { 38, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5977), null, "CA", "CAN", false, null, null, null, " ", "Canadá" },
                    { 39, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5982), null, "CC", "CCK", false, null, null, null, " ", "Islas Cocos" },
                    { 40, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5988), null, "CD", "COD", false, null, null, null, " ", "Republica Democrática del Congo" },
                    { 41, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(5993), null, "CF", "CAF", false, null, null, null, " ", "República Centrofricana" },
                    { 42, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6020), null, "CG", "COG", false, null, null, null, " ", "República del Congo" },
                    { 43, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6026), null, "CH", "CHE", false, null, null, null, " ", "Suiza" },
                    { 44, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6032), null, "CI", "CIV", false, null, null, null, " ", "Costa de Marfil" },
                    { 45, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6038), null, "CK", "COK", false, null, null, null, " ", "Islas Cook" },
                    { 46, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6043), null, "CL", "CHL", false, null, null, null, " ", "Chile" },
                    { 47, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6048), null, "CM", "CMR", false, null, null, null, " ", "Camerún" },
                    { 48, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6053), null, "CN", "CHN", false, null, null, null, " ", "China" },
                    { 49, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6059), null, "CO", "COL", false, null, null, null, " ", "Colombia" },
                    { 50, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6064), null, "CR", "CRI", false, null, null, null, " ", "Costa Rica" },
                    { 51, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6070), null, "CU", "CUB", false, null, null, null, " ", "Cuba" },
                    { 52, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6075), null, "CV", "CPV", false, null, null, null, " ", "Cabo Verde" },
                    { 53, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6080), null, "CX", "CXR", false, null, null, null, " ", "Isla de Navidad" },
                    { 54, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6086), null, "CY", "CYP", false, null, null, null, " ", "Chipre" },
                    { 55, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6092), null, "CZ", "CZE", false, null, null, null, " ", "República Checa" },
                    { 56, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6097), null, "DE", "DEU", false, null, null, null, " ", "Alemania" },
                    { 57, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6102), null, "DJ", "DJI", false, null, null, null, " ", "Yibuti" },
                    { 58, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6108), null, "DK", "DNK", false, null, null, null, " ", "Dinamarca" },
                    { 59, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6113), null, "DM", "DMA", false, null, null, null, " ", "Dominica" },
                    { 60, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6119), null, "DO", "DOM", false, null, null, null, " ", "República Dominicana" },
                    { 61, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6124), null, "DZ", "DZA", false, null, null, null, " ", "Argelia" },
                    { 62, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6130), null, "EC", "ECU", false, null, null, null, " ", "Ecuador" },
                    { 63, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6135), null, "EE", "EST", false, null, null, null, " ", "Estonia" },
                    { 64, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6140), null, "EG", "EGY", false, null, null, null, " ", "Egipto" },
                    { 65, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6146), null, "EH", "ESH", false, null, null, null, " ", "Sahara Occidental" },
                    { 66, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6151), null, "ER", "ERI", false, null, null, null, " ", "Eritrea" },
                    { 67, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6157), null, "ES", "ESP", false, null, null, null, " ", "España" },
                    { 68, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6163), null, "ET", "ETH", false, null, null, null, " ", "Etiopía" },
                    { 69, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6168), null, "FI", "FIN", false, null, null, null, " ", "Finlandia" },
                    { 70, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6173), null, "FJ", "FJI", false, null, null, null, " ", "Fiji" },
                    { 71, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6179), null, "FK", "FLK", false, null, null, null, " ", "Islas Malvinas" },
                    { 72, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6184), null, "FM", "FSM", false, null, null, null, " ", "Micronesia" },
                    { 73, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6189), null, "FO", "FRO", false, null, null, null, " ", "Islas Faroe" },
                    { 74, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6195), null, "FR", "FRA", false, null, null, null, " ", "Francia" },
                    { 75, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6200), null, "GA", "GAB", false, null, null, null, " ", "Gabón" },
                    { 76, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6205), null, "GB", "GBR", false, null, null, null, " ", "Reino Unido" },
                    { 77, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6211), null, "GD", "GRD", false, null, null, null, " ", "Granada" },
                    { 78, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6216), null, "GE", "GEO", false, null, null, null, " ", "Georgia" },
                    { 79, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6221), null, "GF", "GUF", false, null, null, null, " ", "Guayana Francesa" },
                    { 80, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6227), null, "GG", "GGY", false, null, null, null, " ", "Guernsey" },
                    { 81, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6232), null, "GH", "GHA", false, null, null, null, " ", "Ghana" },
                    { 82, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6237), null, "GI", "GIB", false, null, null, null, " ", "Gibraltar" },
                    { 83, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6243), null, "GL", "GRL", false, null, null, null, " ", "Groenlandia" },
                    { 84, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6248), null, "GM", "GMB", false, null, null, null, " ", "Gambia" },
                    { 85, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6254), null, "GN", "GIN", false, null, null, null, " ", "Guinea" },
                    { 86, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6259), null, "GP", "GLP", false, null, null, null, " ", "Guadalupe" },
                    { 87, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6264), null, "GQ", "GNQ", false, null, null, null, " ", "Guinea Ecuatorial" },
                    { 88, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6269), null, "GR", "GRC", false, null, null, null, " ", "Grecia" },
                    { 89, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6275), null, "GS", "SGS", false, null, null, null, " ", "Georgia del Sur y las islas Sandwich" },
                    { 90, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6280), null, "GT", "GTM", false, null, null, null, " ", "Guatemala" },
                    { 91, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6285), null, "GU", "GUM", false, null, null, null, " ", "Guam" },
                    { 92, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6290), null, "GW", "GNB", false, null, null, null, " ", "Guinea-Bissau" },
                    { 93, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6296), null, "GY", "GUY", false, null, null, null, " ", "Guyana" },
                    { 94, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6302), null, "HK", "HKG", false, null, null, null, " ", "Hong Kong" },
                    { 95, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6308), null, "HM", "HMD", false, null, null, null, " ", "Islas Heard y McDonald" },
                    { 96, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6313), null, "HN", "HND", false, null, null, null, " ", "Honduras" },
                    { 97, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6320), null, "HR", "HRV", false, null, null, null, " ", "Croacia" },
                    { 98, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6325), null, "HT", "HTI", false, null, null, null, " ", "Haití" },
                    { 99, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6331), null, "HU", "HUN", false, null, null, null, " ", "Hungría" },
                    { 100, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6337), null, "ID", "IDN", false, null, null, null, " ", "Indonesia" },
                    { 101, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6342), null, "IE", "IRL", false, null, null, null, " ", "Irlanda" },
                    { 102, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6347), null, "IL", "ISR", false, null, null, null, " ", "Israel" },
                    { 103, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6352), null, "IM", "IMN", false, null, null, null, " ", "Isla de Man" },
                    { 104, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6358), null, "IN", "IND", false, null, null, null, " ", "India" },
                    { 105, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6363), null, "IO", "IOT", false, null, null, null, " ", "Terrirorio Británico del Océano Índico" },
                    { 106, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6384), null, "IQ", "IRQ", false, null, null, null, " ", "Irak" },
                    { 107, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6390), null, "IR", "IRN", false, null, null, null, " ", "Irán" },
                    { 108, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6395), null, "IS", "ISL", false, null, null, null, " ", "Islandia" },
                    { 109, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6401), null, "IT", "ITA", false, null, null, null, " ", "Italia" },
                    { 110, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6406), null, "JE", "JEY", false, null, null, null, " ", "Jersey" },
                    { 111, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6411), null, "JM", "JAM", false, null, null, null, " ", "Jamaica" },
                    { 112, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6417), null, "JO", "JOR", false, null, null, null, " ", "Jordania" },
                    { 113, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6422), null, "JP", "JPN", false, null, null, null, " ", "Japón" },
                    { 114, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6427), null, "KE", "KEN", false, null, null, null, " ", "Kenia" },
                    { 115, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6433), null, "KG", "KGZ", false, null, null, null, " ", "Kirguistán" },
                    { 116, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6438), null, "KH", "KHM", false, null, null, null, " ", "Camboya" },
                    { 117, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6443), null, "KI", "KIR", false, null, null, null, " ", "Kiribati" },
                    { 118, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6449), null, "KM", "COM", false, null, null, null, " ", "Comoras" },
                    { 119, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6454), null, "KN", "KNA", false, null, null, null, " ", "San Cristóbal y Nieves" },
                    { 120, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6459), null, "KP", "PRK", false, null, null, null, " ", "República Democrática de Corea" },
                    { 121, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6465), null, "KR", "KOR", false, null, null, null, " ", "República de Corea" },
                    { 122, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6471), null, "KW", "KWT", false, null, null, null, " ", "Kuwait" },
                    { 123, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6477), null, "KY", "CYM", false, null, null, null, " ", "Islas Caimán" },
                    { 124, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6482), null, "KZ", "KAZ", false, null, null, null, " ", "Kasajistán" },
                    { 125, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6488), null, "LA", "LAO", false, null, null, null, " ", "Laos" },
                    { 126, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6493), null, "LB", "LBN", false, null, null, null, " ", "Líbano" },
                    { 127, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6498), null, "LC", "LCA", false, null, null, null, " ", "Santa Lucía" },
                    { 128, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6504), null, "LI", "LIE", false, null, null, null, " ", "Liechtenstein" },
                    { 129, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6509), null, "LK", "LKA", false, null, null, null, " ", "Sri Lanka" },
                    { 130, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6515), null, "LR", "LBR", false, null, null, null, " ", "Liberia" },
                    { 131, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6520), null, "LS", "LSO", false, null, null, null, " ", "Lesotho" },
                    { 132, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6525), null, "LT", "LTU", false, null, null, null, " ", "Lituana" },
                    { 133, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6531), null, "LU", "LUX", false, null, null, null, " ", "Luxembur " },
                    { 134, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6536), null, "LV", "LVA", false, null, null, null, " ", "Letonia" },
                    { 135, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6542), null, "LY", "LBY", false, null, null, null, " ", "Libia" },
                    { 136, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6547), null, "MA", "MAR", false, null, null, null, " ", "Marruecos" },
                    { 137, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6552), null, "MC", "MCO", false, null, null, null, " ", "Mónaco" },
                    { 138, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6557), null, "MD", "MDA", false, null, null, null, " ", "Moldavia" },
                    { 139, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6563), null, "ME", "MNE", false, null, null, null, " ", "Montenegro" },
                    { 140, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6568), null, "MG", "MDG", false, null, null, null, " ", "Madagascar" },
                    { 141, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6574), null, "MH", "MHL", false, null, null, null, " ", "Islas Marschall" },
                    { 142, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6579), null, "MK", "MKD", false, null, null, null, " ", "Macedonia" },
                    { 143, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6584), null, "ML", "MLI", false, null, null, null, " ", "Malí" },
                    { 144, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6589), null, "MM", "MMR", false, null, null, null, " ", "Myanmar" },
                    { 145, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6594), null, "MN", "MNG", false, null, null, null, " ", "Mon lia" },
                    { 146, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6600), null, "MO", "MAC", false, null, null, null, " ", "Macao" },
                    { 147, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6605), null, "MP", "MNP", false, null, null, null, " ", "Islas Marianas del Norte" },
                    { 148, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6611), null, "MQ", "MTQ", false, null, null, null, " ", "Martinica" },
                    { 149, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6616), null, "MR", "MRT", false, null, null, null, " ", "Mauritania" },
                    { 150, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6622), null, "MS", "MSR", false, null, null, null, " ", "Montserrat" },
                    { 151, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6627), null, "MT", "MLT", false, null, null, null, " ", "Malta" },
                    { 152, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6632), null, "MU", "MUS", false, null, null, null, " ", "Mauricio" },
                    { 153, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6638), null, "MV", "MDV", false, null, null, null, " ", "Maldivas" },
                    { 154, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6643), null, "MW", "MWI", false, null, null, null, " ", "Malawi" },
                    { 155, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6648), null, "MX", "MEX", false, null, null, null, " ", "México" },
                    { 156, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6653), null, "MY", "MYS", false, null, null, null, " ", "Malasia" },
                    { 157, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6659), null, "MZ", "MOZ", false, null, null, null, " ", "Mozambique" },
                    { 158, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6664), null, "NA", "NAM", false, null, null, null, " ", "Namibia" },
                    { 159, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6669), null, "NC", "NCL", false, null, null, null, " ", "Nueva Caledonia" },
                    { 160, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6675), null, "NE", "NER", false, null, null, null, " ", "Níger" },
                    { 161, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6680), null, "NF", "NFK", false, null, null, null, " ", "Isla Norfolk" },
                    { 162, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6686), null, "NG", "NGA", false, null, null, null, " ", "Nigeria" },
                    { 163, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6691), null, "NI", "NIC", false, null, null, null, " ", "Nicaragua" },
                    { 164, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6697), null, "NL", "NLD", false, null, null, null, " ", "Países Bajos" },
                    { 165, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6702), null, "NO", "NOR", false, null, null, null, " ", "Noruega" },
                    { 166, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6707), null, "NP", "NPL", false, null, null, null, " ", "Nepal" },
                    { 167, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6713), null, "NR", "NRU", false, null, null, null, " ", "Naurú" },
                    { 168, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6718), null, "NU", "NIU", false, null, null, null, " ", "Niue" },
                    { 169, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6723), null, "NZ", "NZL", false, null, null, null, " ", "Nueva Zelanda" },
                    { 170, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6743), null, "OM", "OMN", false, null, null, null, " ", "Omán" },
                    { 171, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6748), null, "PA", "PAN", false, null, null, null, " ", "Panamá" },
                    { 172, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6754), null, "PE", "PER", false, null, null, null, " ", "Perú" },
                    { 173, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6759), null, "PF", "PYF", false, null, null, null, " ", "Polinesia Francesa" },
                    { 174, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6765), null, "PG", "PNG", false, null, null, null, " ", "Papúa-Nueva Guinea" },
                    { 175, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6770), null, "PH", "PHL", false, null, null, null, " ", "Filipinas" },
                    { 176, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6776), null, "PK", "PAK", false, null, null, null, " ", "Pakistán" },
                    { 177, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6783), null, "PL", "POL", false, null, null, null, " ", "Polonia" },
                    { 178, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6788), null, "PM", "SPM", false, null, null, null, " ", "San Pedro y Miquelón" },
                    { 179, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6794), null, "PN", "PCN", false, null, null, null, " ", "Pitcairn" },
                    { 180, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6799), null, "PR", "PRI", false, null, null, null, " ", "Puerto Rico" },
                    { 181, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6805), null, "PS", "PSE", false, null, null, null, " ", "Estado de Palestina" },
                    { 182, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6810), null, "PT", "PRT", false, null, null, null, " ", "Portugal" },
                    { 183, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6815), null, "PW", "PLW", false, null, null, null, " ", "Palau" },
                    { 184, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6821), null, "PY", "PRY", false, null, null, null, " ", "Paraguay" },
                    { 185, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6826), null, "QA", "QAT", false, null, null, null, " ", "Qatar" },
                    { 186, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6831), null, "RE", "REU", false, null, null, null, " ", "Reunión" },
                    { 187, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6836), null, "RO", "ROM", false, null, null, null, " ", "Rumania" },
                    { 188, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6842), null, "RS", "SRB", false, null, null, null, " ", "Serbia" },
                    { 189, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6847), null, "RU", "RUS", false, null, null, null, " ", "Rusia" },
                    { 190, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6853), null, "RW", "RWA", false, null, null, null, " ", "Ruanda" },
                    { 191, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6858), null, "SA", "SAU", false, null, null, null, " ", "Arabia Saudita" },
                    { 192, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6863), null, "SB", "SLB", false, null, null, null, " ", "Islas Salomón" },
                    { 193, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6868), null, "SC", "SYC", false, null, null, null, " ", "Seychelles" },
                    { 194, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6873), null, "SD", "SDN", false, null, null, null, " ", "Sudán" },
                    { 195, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6879), null, "SE", "SWE", false, null, null, null, " ", "Suecia" },
                    { 196, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6885), null, "SG", "SGP", false, null, null, null, " ", "Singapur" },
                    { 197, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6890), null, "SH", "SHN", false, null, null, null, " ", "Santa Helena" },
                    { 198, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6896), null, "SI", "SVN", false, null, null, null, " ", "Eslovenia" },
                    { 199, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6901), null, "SJ", "SJM", false, null, null, null, " ", "Svalbard y Jan Mayen" },
                    { 200, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6907), null, "SK", "SVK", false, null, null, null, " ", "Eslovaquia" },
                    { 201, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6912), null, "SL", "SLE", false, null, null, null, " ", "Sierra Leona" },
                    { 202, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6917), null, "SM", "SMR", false, null, null, null, " ", "San Marino" },
                    { 203, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6922), null, "SN", "SEN", false, null, null, null, " ", "Senegal" },
                    { 204, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6928), null, "SO", "SOM", false, null, null, null, " ", "Somalia" },
                    { 205, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6933), null, "SR", "SUR", false, null, null, null, " ", "Surinam" },
                    { 206, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6938), null, "ST", "STP", false, null, null, null, " ", "Santo Tomé y Príncipe" },
                    { 207, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6945), null, "SV", "SLV", false, null, null, null, " ", "El Salvador" },
                    { 208, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6951), null, "SY", "SYR", false, null, null, null, " ", "Siria" },
                    { 209, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6956), null, "SZ", "SWZ", false, null, null, null, " ", "Swazilandia" },
                    { 210, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6962), null, "TC", "TCA", false, null, null, null, " ", "Isla Turks y Caicos" },
                    { 211, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6967), null, "TD", "TCD", false, null, null, null, " ", "Chad" },
                    { 212, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6974), null, "TF", "ATF", false, null, null, null, " ", "Territorios Franceses del Sur" },
                    { 213, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6979), null, "TG", "TGO", false, null, null, null, " ", "Togo" },
                    { 214, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6986), null, "TH", "THA", false, null, null, null, " ", "Tailandia" },
                    { 215, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6993), null, "TJ", "TJK", false, null, null, null, " ", "Tajikistán" },
                    { 216, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(6999), null, "TK", "TKL", false, null, null, null, " ", "Tokelau" },
                    { 217, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7004), null, "TL", "TKM", false, null, null, null, " ", "Timor Este" },
                    { 218, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7009), null, "TM", "TUN", false, null, null, null, " ", "Turkmenistán" },
                    { 219, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7014), null, "TN", "TON", false, null, null, null, " ", "Tunicia" },
                    { 220, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7020), null, "TO", "TMP", false, null, null, null, " ", "Tonga" },
                    { 221, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7026), null, "TR", "TUR", false, null, null, null, " ", "Turquía" },
                    { 222, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7031), null, "TT", "TTO", false, null, null, null, " ", "Trinidad y Toba " },
                    { 223, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7036), null, "TV", "TUV", false, null, null, null, " ", "Tuvalú" },
                    { 224, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7041), null, "TW", "TWN", false, null, null, null, " ", "Taiwán" },
                    { 225, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7047), null, "TZ", "TZA", false, null, null, null, " ", "Tanzania" },
                    { 226, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7052), null, "UA", "UKR", false, null, null, null, " ", "Ucrania" },
                    { 227, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7057), null, "UG", "UGA", false, null, null, null, " ", "Uganda" },
                    { 228, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7063), null, "UM", "UMI", false, null, null, null, " ", "Islas Menores de Estados Unidos" },
                    { 229, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7070), null, "US", "USA", false, null, null, null, " ", "Estados Unidos" },
                    { 230, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7075), null, "UY", "URY", false, null, null, null, " ", "Uruguay" },
                    { 231, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7080), null, "UZ", "UZB", false, null, null, null, " ", "Uzbekistán" },
                    { 232, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7086), null, "VA", "VAT", false, null, null, null, " ", "El Vaticano" },
                    { 233, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7094), null, "VC", "VCT", false, null, null, null, " ", "San Vicente y Granadinas" },
                    { 234, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7115), null, "VE", "VEN", false, null, null, null, " ", "Venezuela" },
                    { 235, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7123), null, "VG", "VGB", false, null, null, null, " ", "Islas Vírgenes Británicas" },
                    { 236, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7129), null, "VI", "VIR", false, null, null, null, " ", "Islas Vírgenes de Estados Unidos" },
                    { 237, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7135), null, "VN", "VNM", false, null, null, null, " ", "Vietnam" },
                    { 238, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7141), null, "VU", "VUT", false, null, null, null, " ", "Vanuatu" },
                    { 239, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7147), null, "WF", "WLF", false, null, null, null, " ", "Wallis y Futuna" },
                    { 240, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7152), null, "WS", "WSM", false, null, null, null, " ", "Samoa" },
                    { 241, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7159), null, "YE", "YEM", false, null, null, null, " ", "Yemén" },
                    { 242, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7164), null, "YT", "MYT", false, null, null, null, " ", "Mayotte" },
                    { 243, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7169), null, "ZA", "ZAF", false, null, null, null, " ", "Suráfrica" },
                    { 244, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7175), null, "ZM", "ZMB", false, null, null, null, " ", "Zambia" },
                    { 245, "system", new DateTime(2023, 3, 6, 19, 55, 15, 525, DateTimeKind.Local).AddTicks(7180), null, "ZW", "ZWE", false, null, null, null, " ", "Zimbabwe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Album_ArtistId",
                table: "Album",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Artist_CountryId",
                table: "Artist",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMember_ArtistId",
                table: "GroupMember",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMember_MusicianId",
                table: "GroupMember",
                column: "MusicianId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_AlbumId",
                table: "Song",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_GenreId",
                table: "Song",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_SongReview_ReviewerProfileId",
                table: "SongReview",
                column: "ReviewerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_SongReview_SongId",
                table: "SongReview",
                column: "SongId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupMember");

            migrationBuilder.DropTable(
                name: "SongReview");

            migrationBuilder.DropTable(
                name: "Musician");

            migrationBuilder.DropTable(
                name: "ReviewerProfile");

            migrationBuilder.DropTable(
                name: "Song");

            migrationBuilder.DropTable(
                name: "Album");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
