using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public class Atencion
    {
        public int Numero { get; set; }
        public Enfermedad EnfermedadAsociada { get; set; }
        public Persona Atendido { get; set; }
        public Atencion(int numero, DateTime fecha, Enfermedad enfermedadAsociada, Persona atendido)
        {
            this.Numero = numero++;
            this.EnfermedadAsociada = enfermedadAsociada;
            this.Atendido = atendido;
        }
        
    }
}
