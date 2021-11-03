using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EmpleadoEntity : DBEntity
    {
        public EmpleadoEntity()
        {
            Id = Id ?? new TIEntity();
        }
        public int? IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int? IdTipoIdentificacion { get; set; }
        public virtual TIEntity Id { get; set; }
        public string Descripcion => Id?.Descripcion;
        public string Identificacion { get; set; }

    }
}
