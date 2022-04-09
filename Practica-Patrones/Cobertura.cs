using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public enum tipoCobertura { Maxima, Normal};
    public class Cobertura
    {
        public string Descripcion { get; set; }
        public string Empresa { get; set; }
        public byte CantidadMaximiGrupoFamiliar { get; set; }
        public double CostoBase { get; set; }
        public List<Enfermedad> EnfermedadesIncluidadas { get; set; }
        public tipoCobertura Tipo { get; set; }
        public double CalcularCostoEnfermedades()
        {
            double Acumulador = 0;

            foreach (Enfermedad enfermedad in EnfermedadesIncluidadas)
            {
                Acumulador += enfermedad.Costo;
            }

            return Acumulador;
        }
        public double CalcularCosto()
        {
            if (this.Tipo == tipoCobertura.Normal)
            {
                return CostoBase + (CalcularCostoEnfermedades() / EnfermedadesIncluidadas.Count());
            }
            else
            {
                return CalcularCostoEnfermedades();
            }
           
        }
    }
}
