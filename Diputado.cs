using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_1
{
    internal class Diputado : Legislador
    {
        int NumAsientoCamaraBaja;
        
        public Diputado() { }
        public Diputado(int NumAsientoCamaraBaja, string PartidoPolitico, string DepartamentoQueRepresenta, int NumDespacho, string Nombre, string Apellido, int Edad, bool Casado) : base(PartidoPolitico,DepartamentoQueRepresenta,NumDespacho,Nombre,Apellido,Edad,Casado)
        {
            this.NumAsientoCamaraBaja = NumAsientoCamaraBaja;
        }
        public override string getCamara() => "Diputado";
        public override int getAsiento() => NumAsientoCamaraBaja;

        public override void presentarPropuestaLegislativa()
        {
            Console.WriteLine("El Diputado: " + getApellido() + " " + getNombre() + " quiere presentar una propuesta");
        }

        public override void votar()
        {
            Console.WriteLine("El Diputado: " + getApellido() + " " + getNombre() + " vota ");
        }

        public override void participarDebate()
        {
            Console.WriteLine("El Diputado: " + getApellido() + " " + getNombre() + " participa en el debate");
        }

    }
}
