using System;
using System.ComponentModel.DataAnnotations;

namespace DatosAccceso.Modelos
{
    //Importante manter con nome singular porque para a BD usaremos o plural automaticamente

    /// <summary>
    /// A nosa entidade, nosa taboa da base de datos
    /// </summary>
    public class Receta
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, ErrorMessage = "Mensaxe demasiado extensa, por favor acorta. 200 caracteres maximo")]
        public string Titulo { get; set; }
        [Required]
        [StringLength(5000, ErrorMessage = "Mensaxe demasiado extensa, por favor acorta. 5000 caracteres maximo")]
        public string Descripcion { get; set; }
        public DateTime DataCreacion { get; set; }
        public DateTime DataActualizacion { get; set; }
    }
}