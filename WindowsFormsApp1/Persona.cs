using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
        internal class Persona
        {
            protected string nombre;
            protected DateTime? fechaNacimiento;
            protected Int32 Edad;

            public string _nombre
            {
                get
                {
                    return nombre;
                }
                set
                {
                    nombre = value;
                }
            }

            public DateTime? _fechaNacimineto
            {
                get
                {
                    return fechaNacimiento;
                }
                set
                {
                    fechaNacimiento = value;
                }
            }

            public int Edad_
            {
                get
                {
                int edad;
                    edad = DateTime.Today.Year - fechaNacimiento.Value.Year;
                    if (fechaNacimiento.Value.Year > DateTime.Today.Year)
                        edad -= 1;
                    return edad;
                }
            }

            public Persona()
            {
                nombre = string.Empty;
                fechaNacimiento = null;
            }

            public Persona(string nombre, DateTime? fechaNacimineto)
            {
                this.nombre = nombre;
                this.fechaNacimiento = fechaNacimiento;
            }

            public override string ToString()
            {
                return nombre.ToUpper() + " " + Edad;
            }
        }
    }

