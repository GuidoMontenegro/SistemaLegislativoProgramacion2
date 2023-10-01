using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practico_1
{
    internal class Senador : Legislador
    {
        int NumAsientoCamaraAlta;

        public Senador() { }
        public Senador(int NumAsientoCamaraAlta, string PartidoPolitico, string DepartamentoQueRepresenta, int NumDespacho, string Nombre, string Apellido, int Edad, bool Casado) : base(PartidoPolitico,DepartamentoQueRepresenta,NumDespacho,Nombre,Apellido,Edad,Casado)
        {
            this.NumAsientoCamaraAlta = NumAsientoCamaraAlta;
        }
        public int getNumAsientoCamaraAlta() => NumAsientoCamaraAlta;
        public void setNumAsientoCamaraAlta(int NumAsientoCamaraAlta) => this.NumAsientoCamaraAlta = NumAsientoCamaraAlta;
        public override string getCamara() => "Senador";

        public override int getAsiento() => NumAsientoCamaraAlta;
        
        public override void presentarPropuestaLegislativa()
        {
            Console.WriteLine("El Senador: "+getApellido()+" "+getNombre()+" quiere presentar una propuesta "); //Preguntar
        }

        public override void votar()
        {
            Console.WriteLine("El Senador: " + getApellido() + " " + getNombre() + " vota ");
        }

        public override void participarDebate()
        {
            Console.WriteLine("El Senador: " + getApellido() + " " + getNombre() + " participa en el debate");
        }
    }
}
