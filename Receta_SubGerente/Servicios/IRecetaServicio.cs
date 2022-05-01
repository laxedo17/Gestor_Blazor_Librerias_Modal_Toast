using System.Collections.Generic;
using DatosAccceso.Modelos;

namespace Receta_SubGerente.Servicios
{
    public interface IRecetaServicio
    {
        //OPERACIONS CRUD
        // Metodo crear (create)
        Receta Create(Receta receta);
        // Metodo Get
        Receta Get(int id);
        // Lista
        List<Receta> Lista();
        // Actualizar (Update)
        Receta Update(Receta receta);
        // Borrar (Delete)
        void Delete(int id);

    }
}