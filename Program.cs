using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practico_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            List<Legislador> listLegisladores = new List<Legislador>
           {
            new Diputado  (1, "Nacional", "Rocha", 1, "Pedro", "Lopez", 50, false),
            new Diputado  (2, "Nacional", "Maldonado", 2, "Alfredo", "Martinez", 42, false),
            new Diputado  (3, "Partido de los Trabajadores", "Canelones", 3, "Nicolas", "Pipo", 60, false),
            new Diputado  (4, "Nacional", "Artigas", 4, "Antonio", "Lopez", 18, false),
            new Senador(1, "Frente Amplio", "Maldonado", 5, "Fernando", "Rodriguez", 55, true),
            new Senador(2, "Partido de la Gente", "Maldonado", 6, "Fernando", "Rodriguez", 55, true),
            new Senador(3, "Nacional", "Maldonado", 7, "Sebastian", "Michelini", 65, true),
            new Senador(4, "Nacional", "Maldonado", 8, "Mohamed", "Pereyra", 55, true),

           };

            Parlamento parlamento = new Parlamento(listLegisladores);
            Menu(parlamento);
            //parlamento.ListarCamaras();
        }

        static public void Menu(Parlamento parlamento)
        {
            Console.Clear();
            int op;
            bool esNumero;

            do
            {
                Console.Clear();
                Console.WriteLine(" MENU");
                Console.WriteLine("1 - Registro Legisladores");
                Console.WriteLine("2 - Propuestas");
                Console.WriteLine("3 - Salir");
                Console.WriteLine("");
                Console.Write("Ingrese la opcion: ");
                esNumero = int.TryParse(Console.ReadLine(), out op);

                if (esNumero)
                {
                    switch (op)
                    {
                        case 1:
                            MenuRegistro(parlamento);
                            break;
                        case 2:
                            MenuPropuestas(parlamento);
                            break;
                        case 3:
                            break;
                        default:
                            Console.WriteLine("Opcion incorrecta, ingresela de nuevo: ");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opcion incorrecta, ingresela de nuevo: ");
                }
            } while (op != 3);





        }
        static public void MenuRegistro(Parlamento parlamento)
        {
            Console.Clear();
            int op;
            bool esNumero;

            do
            {
                Console.Clear();
                Console.WriteLine("MENU REGISTROS LEGISLADORES");
                Console.WriteLine("");
                Console.WriteLine("1 - Registrar nuevo Legislador");
                Console.WriteLine("2 - Mostrar lista legisladores");
                Console.WriteLine("3 - Volver al menu anterior");
                Console.WriteLine("");
                Console.Write("Ingrese la opcion: ");
                esNumero = int.TryParse(Console.ReadLine(), out op);

                if (esNumero)
                {
                    switch (op)
                    {
                        case 1:
                            RegistrarLegislador(parlamento);
                            break;
                        case 2:
                            MostrarListas(parlamento);
                            break;
                        default:
                            Console.WriteLine("Opcion incorrecta, ingresela de nuevo: ");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opcion incorrecta, ingresela de nuevo: ");
                }
            } while (op != 3);
           // Menu(parlamento);
        }
        public static void RegistrarLegislador(Parlamento parlamento)
        {
            bool esNumero = false;
            Console.Clear();
            Console.WriteLine("REGISTRAR LEGISLADOR");
            Console.WriteLine("");
            string camara = "0";
            //camara = Console.ReadLine();

            do
            {
                Console.WriteLine("1-Diputado");
                Console.WriteLine("2-Senador");
                Console.WriteLine("");
                Console.Write("Ingrese la opcion: ");
                camara = Console.ReadLine();
            } while ((camara != "1") && (camara != "2"));
            if (camara == "1") 
            {
                camara = "Diputado";
            }
            else
            {
                camara = "Senador";
            }

            
            string entrada = "forzar a entrar";
            //NOMBRE
            Console.Clear();
            while (!CadenaSinEspacio(entrada))
            {
                Console.Write("Ingrese el nombre: ");
                entrada = Console.ReadLine();
                entrada = entrada.ToLower();
            }
            string nombre = char.ToUpper(entrada[0]) + entrada.Substring(1);
            //NOMBRE

            entrada = "forzar a entrar";
            //APELLIDO
            Console.Clear();
            while (!CadenaSinEspacio(entrada))
            {
                Console.Write("Ingrese el apellido: ");
                entrada = Console.ReadLine();
                entrada = entrada.ToLower();
            }
            string apellido = char.ToUpper(entrada[0]) + entrada.Substring(1);
            //APELLIDO




            //EDAD
            Console.Clear();
            int edad = 0;
            if(camara == "Diputado")
            {
                while ((edad < 25)||(edad>90 || !esNumero))
                {
                    Console.Write("Ingrese la edad (>25) (<90): ");
                    esNumero = int.TryParse(Console.ReadLine(), out edad);
                }
            }
            else // Senador
            {
                while((edad < 30 )||(edad > 90))
                {
                    Console.Write("Ingrese la edad (>30) (<90): ");
                    esNumero = int.TryParse(Console.ReadLine(), out edad);
                }
            }
            //EDAD

            //PARTIDO
            Console.Clear();
            Console.WriteLine("1 - Partido Independiente");
            Console.WriteLine("2 - Partido de la Gente");
            Console.WriteLine("3 - Partido Nacional");
            Console.WriteLine("4 - Partido Colorado");
            Console.WriteLine("5 - Frente Amplio");
            Console.WriteLine("6 - Partido de los Trabajadores");
            Console.WriteLine("");
            Console.Write("Ingrese a que partido pertenece el nuevo " + camara + ": ");
            int partidoPolitico;
            esNumero = int.TryParse(Console.ReadLine(), out partidoPolitico);
            
            while(partidoPolitico<1 || partidoPolitico>6 || !esNumero)
            {
                Console.WriteLine("Ingreso incorrecto, ingreselo de nuevo");
                esNumero = int.TryParse(Console.ReadLine(), out partidoPolitico);
            }
            string partido=" ";
            switch (partidoPolitico)
            {
                case 1: partido = "Partido Independiente";
                    break;
                case 2: partido = "Partido de la Gente";
                    break;
                case 3: partido = "Partido Nacional";
                    break;
                case 4: partido = "Partido Colorado";
                    break;
                case 5: partido = "Frente Amplio";
                    break;
                case 6: partido = "Partido de los Trabajadores";
                    break;
                default:
                    break;
            }
            //PARTIDO

            //DEPARTAMENTO QUE REPRESENTA
            Console.Clear();
            int dep = 0;
            Console.WriteLine("1- Artigas");
            Console.WriteLine("2- Canelones");
            Console.WriteLine("3- Cerro Largo");
            Console.WriteLine("4- Colonia");
            Console.WriteLine("5- Durazno");
            Console.WriteLine("6- Flores");
            Console.WriteLine("7- Florida");
            Console.WriteLine("8- Lavalleja");
            Console.WriteLine("9- Maldonado");
            Console.WriteLine("10- Montevideo");
            Console.WriteLine("11- Paysandú");
            Console.WriteLine("12- Rio Negro");
            Console.WriteLine("13- Rivera");
            Console.WriteLine("14- Rocha");
            Console.WriteLine("15- Salto");
            Console.WriteLine("16- San José");
            Console.WriteLine("17- Soriano");
            Console.WriteLine("18- Tacuarembó");
            Console.WriteLine("19- Treinta y Tres");

            string departamento=" ";
            esNumero = false;
            while ((dep < 1) || (dep > 19 || !esNumero))
            {
                Console.Write("Ingrese el departamento que representa: ");
                esNumero=int.TryParse(Console.ReadLine(), out dep);
            }

            switch (dep)
            {
                case 1:
                    departamento = "Artigas";
                    break; 
                case 2:     
                    departamento = "Canelones";
                    break;
                case 3:
                    departamento = "Cerro Largo";
                    break;
                case 4:
                    departamento = "Colonia";
                    break;
                case 5:
                    departamento = "Durazno";
                    break;
                case 6:
                    departamento = "Flores";
                    break;
                case 7:
                    departamento = "Florida";
                    break;
                case 8:
                    departamento = "Lavalleja";
                    break;
                case 9:
                    departamento = "Maldonado";
                    break;
                case 10:
                    departamento = "Montevideo";
                    break;
                case 11:
                    departamento = "Paysandú";
                    break;
                case 12:
                    departamento = "Rio Negro";
                    break;
                case 13:
                    departamento = "Rivera";
                    break;
                case 14:
                    departamento = "Rocha";
                    break;
                case 15:
                    departamento = "Salto";
                    break;
                case 16:
                    departamento = "San José";
                    break;
                case 17:
                    departamento = "Soriano";
                    break;
                case 18:
                    departamento = "Tacuarembó";
                    break;
                case 19:
                    departamento = "Treinta y Tres";
                    break;
                default:
                    break;
            }
            //DEPARTAMENTO

            //NUMDESPACHO
            Console.Clear();
            int numDespacho = 0;
            do
            {
                Console.Clear();
            parlamento.ListarCamaras();
            Console.Write("Numero de despacho: ");
                Console.WriteLine("Recuerde que el Numero de despacho es unico:");
                esNumero =int.TryParse(Console.ReadLine(), out numDespacho);

            } while (numDespacho < 1 || numDespacho > 100 || !esNumero || DespachoOcupado(parlamento,numDespacho));
            //NUMDESPACHO

            //CASADO
            Console.Clear();
            entrada = "forzar la entrada";
            while ((entrada != "s") && (entrada != "n"))
            {
                Console.Write("Ingrese si es casado s/n: ");
                entrada = Console.ReadLine();
                entrada = entrada.ToLower();
            }
            bool casado;
            if(entrada == "s")
            {
                casado = true;
            }
            else
            {
                casado = false;
            }
            //CASADO
            Console.WriteLine(camara);

            //NUMASIENTO
            Console.Clear();
            int numAsiento = 0;
            if (camara == "Senador")
            {
                do
                {
                    parlamento.ListSenador();
                    Console.WriteLine("");
                    Console.Write("Ingrese el Numero de Asiento: ");
                    esNumero = int.TryParse(Console.ReadLine(), out numAsiento);
                } while (((numAsiento > 30) || (numAsiento < 1)) || !esNumero || (AsientoOcupado(parlamento, numAsiento, camara)));
            }
            else //diputado
            {
                parlamento.ListDiputados();
                Console.WriteLine("");
                do
                {
                Console.WriteLine("");
                Console.Write("Ingrese el Numero de Asiento: ");
                esNumero = int.TryParse(Console.ReadLine(), out numAsiento);

                } while (((numAsiento > 99) || (numAsiento < 1)) || !esNumero || (AsientoOcupado(parlamento, numAsiento, camara)));
            }


            //NUMASIENTO
            Console.Clear();
            Console.WriteLine("El "+camara+"\n Nombre: "+nombre+ "\n Apellido " + apellido+ "\n Edad: " + edad+ "\n Partido que pertenece: " + partido+ "\n Departamento: " + departamento + "\n Casado: "+entrada+"\n Numero de asiento: "+numAsiento);
            entrada = "forzar la entrada";
            while ((entrada != "s") && (entrada != "n"))
            {
                Console.Write("Confirma seleccion? s/n: ");
                entrada = Console.ReadLine();
                entrada = entrada.ToLower();
            }
            bool confirma;
            if (entrada == "s")
            {
                confirma = true;
            }
            else
            {
                confirma = false;
            }
            if (confirma == true)
            {
                if (camara == "Senador")
                {
                Senador nuevo= new Senador(numAsiento,partido,departamento,numDespacho,nombre,apellido,edad,casado);
                parlamento.RegistrarLegislador(nuevo);
                    //(NumAsientoCamaraBaja,PartidoPolitico, DepartamentoQueRepresenta,NumDespacho,Nombre,Apellido,Edad,Casado)
                }
                else //DIPUTADO
                {
                    Diputado nuevo = new Diputado(numAsiento, partido, departamento, numDespacho, nombre, apellido, edad, casado);
                    parlamento.RegistrarLegislador(nuevo);
                }
            }





        }
        public static void MostrarListas(Parlamento parlamento)
        {
            int op;
            bool esNumero;

            do
            {
                Console.Clear();
                Console.WriteLine("MOSTRAR LISTAS");
                Console.WriteLine("");
                Console.WriteLine("1- Lista Completa");
                Console.WriteLine("2- Lista Diputados");
                Console.WriteLine("3- Lista Senadores");
                Console.WriteLine("4- Cantidad de Legisladores en cada Camara");
                Console.WriteLine("5- Volver al menu");
                Console.WriteLine("");
                Console.Write("Ingrese la opcion: ");
                esNumero = int.TryParse(Console.ReadLine(), out op);

                if (esNumero)
                {
                    switch (op)
                    {
                        case 1:
                            Console.Clear();
                            parlamento.ListarCamaras();
                            Console.Write("\nPresione ENTER para continuar: ");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.Clear();
                            parlamento.ListDiputados();
                            Console.Write("\nPresione ENTER para continuar: ");
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.Clear();
                            parlamento.ListSenador();
                            Console.Write("\nPresione ENTER para continuar: ");
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.Clear();
                            parlamento.CantidadLegisladoresPorTipo();
                            Console.Write("\nPresione ENTER para continuar: ");
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Opcion incorrecta, ingresela de nuevo: ");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opcion incorrecta, ingresela de nuevo: ");
                }
            } while (op != 5);
            //Menu(parlamento);

        }
        public static void MenuPropuestas(Parlamento parlamento)
        {
            int op;
            bool esNumero;

            do
            {
                Console.Clear();
                Console.WriteLine(" MENU PROPUESTAS\n");
                Console.WriteLine("1 - Presentar");
                Console.WriteLine("2 - Votar");
                Console.WriteLine("3 - Debatir");
                Console.WriteLine("4 - Volver al menu");
                Console.WriteLine("");
                Console.Write("Ingrese la opcion: ");
                esNumero = int.TryParse(Console.ReadLine(), out op);
                string camara = "0";

                if (esNumero)
                {
                    switch (op)
                    {
                        case 1:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("1-Diputados");
                                Console.WriteLine("2-Senadores");
                                Console.WriteLine("");
                                Console.Write("Que camara va a presentar la propuesta: ");
                                camara = Console.ReadLine();
                            } while ((camara != "1") && (camara != "2"));
                            if (camara == "1")
                            {
                                Console.Clear() ;
                                parlamento.ListDiputados();
                                int asiento = 0;
                                do
                                {
                                Console.Write("\n Seleccione quien va a presentar la propuesta\nRecuerde que la seleccion debe ser por Numero de Asiento: ");
                                asiento = int.Parse(Console.ReadLine());
                                } while (!AsientoOcupado(parlamento, asiento, "Diputado"));
                                
                                foreach (Legislador legislador in parlamento.getLegisladores())
                                {
                                    if(asiento == legislador.getAsiento() && legislador.getCamara()=="Diputado")
                                    {
                                        Console.Clear();
                                        legislador.presentarPropuestaLegislativa();
                                    }
                                }
                            }
                            else
                            {
                                Console.Clear();
                                parlamento.ListSenador();
                                int asiento = 0;
                                do
                                {
                                    Console.Write("\n Seleccione quien va a presentar la propuesta\nRecuerde que la seleccion debe ser por Numero de Asiento: ");
                                    asiento = int.Parse(Console.ReadLine());
                                } while (!AsientoOcupado(parlamento, asiento, "Diputado"));

                                foreach (Legislador legislador in parlamento.getLegisladores())
                                {
                                    if (asiento == legislador.getAsiento()&& legislador.getCamara()=="Senador")
                                    {
                                        Console.Clear();
                                        legislador.presentarPropuestaLegislativa();
                                    }
                                }
                            }


                            Console.ReadLine();
                            break;   
                        case 2:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("1-Diputados");
                                Console.WriteLine("2-Senadores");
                                Console.WriteLine("");
                                Console.Write("De que camara se va a votar la propuesta: ");
                                camara = Console.ReadLine();
                            } while ((camara != "1") && (camara != "2"));
                            if (camara == "1")
                            {
                                Console.Clear();
                                parlamento.ListDiputados();
                                int asiento = 0;
                                do
                                {
                                    Console.Write("\n Seleccione quien va a votar la propuesta\nRecuerde que la seleccion debe ser por Numero de Asiento: ");
                                    asiento = int.Parse(Console.ReadLine());
                                } while (!AsientoOcupado(parlamento, asiento, "Diputado"));

                                foreach (Legislador legislador in parlamento.getLegisladores())
                                {
                                    if (asiento == legislador.getAsiento() && legislador.getCamara() == "Diputado")
                                    {
                                        Console.Clear();
                                        legislador.votar();
                                    }
                                }
                            }
                            else
                            {
                                Console.Clear();
                                parlamento.ListSenador();
                                int asiento = 0;
                                do
                                {
                                    Console.Write("\n Seleccione quien va a votar la propuesta\nRecuerde que la seleccion debe ser por Numero de Asiento: ");
                                    asiento = int.Parse(Console.ReadLine());
                                } while (!AsientoOcupado(parlamento, asiento, "Senador"));

                                foreach (Legislador legislador in parlamento.getLegisladores())
                                {
                                    if (asiento == legislador.getAsiento() && legislador.getCamara() == "Senador")
                                    {
                                        Console.Clear();
                                        legislador.votar();
                                    }
                                }
                            }
                            Console.ReadLine();
                            break;
                        case 3:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("1-Diputados");
                                Console.WriteLine("2-Senadores");
                                Console.WriteLine("");
                                Console.Write("De que camara es quien va a debatir sobre la propuesta: ");
                                camara = Console.ReadLine();
                            } while ((camara != "1") && (camara != "2"));
                            if (camara == "1")
                            {
                                Console.Clear();
                                parlamento.ListDiputados();
                                int asiento = 0;
                                do
                                {
                                    Console.Write("\n Seleccione quien va a debatir la propuesta\nRecuerde que la seleccion debe ser por Numero de Asiento: ");
                                    asiento = int.Parse(Console.ReadLine());
                                } while (!AsientoOcupado(parlamento, asiento, "Diputado"));

                                foreach (Legislador legislador in parlamento.getLegisladores())
                                {
                                    if (asiento == legislador.getAsiento() && legislador.getCamara() == "Diputado")
                                    {
                                        Console.Clear();
                                        legislador.participarDebate();
                                    }
                                }
                            }
                            else
                            {
                                Console.Clear();
                                parlamento.ListSenador();
                                int asiento = 0;
                                do
                                {
                                    Console.Write("\n Seleccione quien va a debatir la propuesta\nRecuerde que la seleccion debe ser por Numero de Asiento: ");
                                    asiento = int.Parse(Console.ReadLine());
                                } while (!AsientoOcupado(parlamento, asiento, "Diputado"));

                                foreach (Legislador legislador in parlamento.getLegisladores())
                                {
                                    if (asiento == legislador.getAsiento() && legislador.getCamara() == "Senador")
                                    {
                                        Console.Clear();
                                        legislador.participarDebate();
                                    }
                                }
                            }
                            Console.ReadLine();
                            break;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("Opcion incorrecta, ingresela de nuevo: ");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opcion incorrecta, ingresela de nuevo: ");
                }
            } while (op != 4);
        }
        public static bool AsientoOcupado(Parlamento parlamento, int numAsiento, string camara)
        {
            foreach (Legislador legislador in parlamento.getLegisladores())
            {
                if (legislador.getCamara() == camara)
                {
                    if(numAsiento == legislador.getAsiento())
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool DespachoOcupado(Parlamento parlamento, int numDespacho)
        {
            foreach(Legislador legislador in parlamento.getLegisladores())
            {
                if(legislador.getNumDespachos()== numDespacho)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CadenaSinEspacio(string palabra)
        {
            if (string.IsNullOrWhiteSpace(palabra))
            {
                return false;
            }
            if(palabra.Contains(" "))
            {
                return false;
            }
            return true;
        }
        
    }
}
