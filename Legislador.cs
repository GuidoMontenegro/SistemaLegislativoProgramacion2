using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_1
{
    internal abstract class Legislador
    {
        string PartidoPolitico;
        string DepartamentoQueRepresenta;
        int NumDespacho;
        string Nombre;
        string Apellido;
        int Edad;
        bool Casado;

        public Legislador() { }

        public Legislador(string PartidoPolitico, string DepartamentoQueRepresenta, int NumDespacho, string Nombre, string Apellido, int Edad, bool Casado)
        {
            this.PartidoPolitico = PartidoPolitico;
            this.DepartamentoQueRepresenta = DepartamentoQueRepresenta;
            this.NumDespacho = NumDespacho;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Edad = Edad;
            this.Casado = Casado;
        }   

        public string getPartidoPolitico() => PartidoPolitico;
        public void setPartidoPolitico(string PartidoPolitico)=>this.PartidoPolitico = PartidoPolitico;
        public string getDepartamentoQueRepresenta()=> DepartamentoQueRepresenta;
        public void setDepartamentoQueRepresenta(string DepartamentoQueRepresenta)=>this.DepartamentoQueRepresenta = DepartamentoQueRepresenta;
        public int getNumDespachos() => NumDespacho;
        public void setNumDespachos(int NumDespacho)=>this.NumDespacho = NumDespacho;
        public string getNombre() => Nombre;
        public void setNombre(string Nombre)=>this.Nombre = Nombre;
        public string getApellido() => Apellido;
        public int getEdad() => Edad;
        public void setEdad(int Edad)=>this.Edad = Edad;
        public bool getCasado() => Casado;
        public void setCasado(bool Casado)=>this.Casado = Casado;
        public abstract string getCamara();
        public abstract int getAsiento();
        public abstract void presentarPropuestaLegislativa();
        public abstract void votar();
        public abstract void participarDebate();
        
    }
}
