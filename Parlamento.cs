using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_1
{
    internal class Parlamento
    {
        List<Legislador> Legisladores;

        public Parlamento() { }

        public Parlamento(List<Legislador> Legisladores)
        {
            this.Legisladores = Legisladores;
        }

        public List<Legislador> getLegisladores() => Legisladores;

        public void RegistrarLegislador(Legislador legislador)=> Legisladores.Add(legislador);

        public void ListarCamaras()
        {
            ListDiputados();
            Console.WriteLine("------------------");
            ListSenador();
            Console.WriteLine("------------------");

        }

        public void ListDiputados()
        {
            
            Console.WriteLine("Diputados: ");
            foreach (Legislador legislador in Legisladores)
            {
                if (legislador.getCamara() == "Diputado")
                {
                    
                    Console.WriteLine(" Nombre: " + legislador.getNombre() + " Apellido: " + legislador.getApellido()+ " Asiento: " + legislador.getAsiento()+ " Despacho: "+legislador.getNumDespachos());
                    
                }
            }
            
        }

        public void ListSenador()
        {
            
            Console.WriteLine("Senadores: ");
            foreach (Legislador legislador in Legisladores)
            {
                if (legislador.getCamara() == "Senador")
                {
                    
                    Console.WriteLine(" Nombre: " + legislador.getNombre() + " Apellido: " + legislador.getApellido() + " Asiento: "+legislador.getAsiento()+ " Despacho: "+legislador.getNumDespachos());
                    
                }
            }
            
        }

        public void CantidadLegisladoresPorTipo()
        {
            int cantSenadores = 0;
            int cantDiputados = 0;
            int cantLegisladores = 0;
            foreach (Legislador legislador in Legisladores)
            {
                if (legislador.getCamara() == "Senador")
                {
                    cantSenadores++;
                }
                else
                {
                    cantDiputados++;
                }
            }
            cantLegisladores = cantDiputados + cantSenadores;
            Console.WriteLine("Cantidad de Legisladores: "+cantLegisladores);
            Console.WriteLine("-------------------");
            Console.WriteLine("Se dividen en: ");
            Console.WriteLine("     Cantidad de Diputados: " + cantDiputados);
            Console.WriteLine("     Cantidad de Senadores: " + cantSenadores);
        }

        

    }
}
