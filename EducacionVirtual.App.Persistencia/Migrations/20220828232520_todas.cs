using Microsoft.EntityFrameworkCore.Migrations;

namespace EducacionVirtual.App.Persistencia.Migrations
{
    public partial class todas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Max_Estudiantes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradoId = table.Column<int>(type: "int", nullable: true),
                    MateriaId = table.Column<int>(type: "int", nullable: true),
                    ProfesorId = table.Column<int>(type: "int", nullable: true),
                    Especializacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Profesor_GradoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_Grado_GradoId",
                        column: x => x.GradoId,
                        principalTable: "Grado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Grado_Profesor_GradoId",
                        column: x => x.Profesor_GradoId,
                        principalTable: "Grado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_ProfesorId",
                        column: x => x.ProfesorId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    profesorId = table.Column<int>(type: "int", nullable: true),
                    Calificacion = table.Column<float>(type: "real", nullable: false),
                    Actividad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materias_Personas_profesorId",
                        column: x => x.profesorId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materias_profesorId",
                table: "Materias",
                column: "profesorId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_GradoId",
                table: "Personas",
                column: "GradoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_MateriaId",
                table: "Personas",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Profesor_GradoId",
                table: "Personas",
                column: "Profesor_GradoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_ProfesorId",
                table: "Personas",
                column: "ProfesorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Materias_MateriaId",
                table: "Personas",
                column: "MateriaId",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materias_Personas_profesorId",
                table: "Materias");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Grado");

            migrationBuilder.DropTable(
                name: "Materias");
        }
    }
}
