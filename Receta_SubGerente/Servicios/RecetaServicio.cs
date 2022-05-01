using System;
using System.Collections.Generic;
using System.Linq;
using DatosAccceso.Datos;
using DatosAccceso.Modelos;

namespace Receta_SubGerente.Servicios
{
    public class RecetaServicio : IRecetaServicio
    {
        private readonly ApplicationDbContext _db;
        public RecetaServicio(ApplicationDbContext db)
        {
            _db = db;
        }
        public Receta Create(Receta receta)
        {
            receta.DataCreacion = DateTime.Now;
            //define a data de actualizacion
            receta.DataActualizacion = DateTime.Now;
            //engadir unha nova receta
            var novaReceta = _db.Recetas.Add(receta);
            //gardar
            _db.SaveChanges();
            //return a entidade da BD
            return novaReceta.Entity;
        }

        public void Delete(int id)
        {
            var receta = _db.Recetas.Find(id);

            if (receta != null)
            {
                _db.Remove(receta);
                _db.SaveChanges();
            }
        }

        public Receta Get(int id)
        {
            return _db.Recetas.Find(id);
        }

        public List<Receta> Lista()
        {
            //Lista mock, inda non implementada en BD
            var recetas = new List<Receta>
            {
                new Receta
                {
                    Id = 1,
                    Titulo = "Bocadillo",
                    Descripcion = "Un bocadillo de calamares anque non tan bó como o que fai a tua nai",
                    DataCreacion = DateTime.Now.AddDays(-2),
                    DataActualizacion = DateTime.Now.AddDays(-1)
                },
                new Receta
                {
                    Id = 2,
                    Titulo = "Tortilla",
                    Descripcion = "A tortilla francesa de toda a vida, non hai patacas hoxe para facer unha tortilla española",
                    DataCreacion = DateTime.Now.AddDays(-5),
                    DataActualizacion = DateTime.Now.AddDays(-4)
                },
                new Receta
                {
                    Id = 3,
                    Titulo = "Pato a la Orange",
                    Descripcion = "Unha comilona te podes dar de este manxar de alto nivel, nun restaurante solo apto para os paladares mais finos",
                    DataCreacion = DateTime.Now.AddDays(-7),
                    DataActualizacion = DateTime.Now
                }
            };

            //ordenado por data de actualizacion de forma descendente -mais recentes primeiro-
            return _db.Recetas.OrderByDescending(r => r.DataActualizacion).ToList();
        }

        public Receta Update(Receta receta)
        {
            var recetaBd = _db.Recetas.Find(receta.Id);

            if (recetaBd != null)
            {
                recetaBd = receta;
                recetaBd.DataActualizacion = DateTime.Now;
                _db.SaveChanges();
            }
            return recetaBd;
        }
    }
}