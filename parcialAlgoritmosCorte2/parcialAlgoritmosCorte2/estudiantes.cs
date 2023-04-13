using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialAlgoritmosCorte2
{
    internal class estudiantes
    {

        public class Estudiantes
        {
            private string nombre;
            private string apellido;
            private string tipoDoc;
            private string numDoc;
            private string fecha_nacimiento;
            private string genero;
            private string grado;
            private string telefono;
            private string nombre_madre;
            private string nombre_padre;

            public Estudiantes(string nombre, string apellido, string tipoDoc, string numDoc, string fecha_nacimiento, string genero, string grado, string telefono, string nombre_madre, string nombre_padre)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.tipoDoc = tipoDoc;
                this.numDoc = numDoc;
                this.fecha_nacimiento = fecha_nacimiento;
                this.genero = genero;
                this.grado = grado;
                this.telefono = telefono;
                this.nombre_madre = nombre_madre;
                this.nombre_padre = nombre_padre;
            }

            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellido { get => apellido; set => apellido = value; }
            public string TipoDoc { get => tipoDoc; set => tipoDoc = value; }
            public string NumDoc { get => numDoc; set => numDoc = value; }
            public string Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
            public string Genero { get => genero; set => genero = value; }
            public string Grado { get => grado; set => grado = value; }
            public string Telefono { get => telefono; set => telefono = value; }
            public string Nombre_madre { get => nombre_madre; set => nombre_madre = value; }
            public string Nombre_padre { get => nombre_padre; set => nombre_padre = value; }
        }

        
    }
}
