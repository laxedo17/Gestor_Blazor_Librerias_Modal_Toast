using Microsoft.EntityFrameworkCore.Migrations;

namespace DatosAccceso.Migrations
{
    public partial class InsertarRecetas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            USE RecetaSubgerente;

INSERT INTO Recetas
	(   Id, Titulo,		[Descripcion],																																																DataCreacion,				DataActualizacion)
(SELECT	1, 'Bocadillo',	'Un bocadillo de calamares anque non tan bó como o que fai a tua nai.',																				'2021-09-04 12:03:00.000', '2021-09-05 18:30:00.000' WHERE NOT EXISTS (SELECT 1 FROM Recetas WHERE Id = 1)) UNION ALL
(SELECT	2, 'Tortilla',		'A tortilla francesa de toda a vida, non hai patacas hoxe para facer unha tortilla española.',												'2021-09-02 14:58:00.000', '2021-09-03 08:12:00.000' WHERE NOT EXISTS (SELECT 1 FROM Recetas WHERE Id = 2)) UNION ALL
(SELECT	3, 'Pato a la Orange',	'Unha comilona te podes dar de este manxar de alto nivel, nun restaurante solo apto para os paladares mais finos.',		'2021-08-31 11:39:00.000', '2021-09-01 09:40:00.000' WHERE NOT EXISTS (SELECT 1 FROM Recetas WHERE Id = 3));
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
