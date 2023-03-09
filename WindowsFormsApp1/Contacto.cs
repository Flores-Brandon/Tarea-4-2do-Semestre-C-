using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Contacto : Persona
    {
        private string correo;
        private string telefono;

        public string _telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value.Replace(" ", "").Replace("-", "");
            }
        }
        public Contacto() : base()
        {
            telefono = string.Empty;
        }

        public Contacto(string nombre, DateTime? fechaNacimiento, string telefoino) : base(nombre, fechaNacimiento)
        {
            telefono = telefono;
        }

        public string correo_
        {
            get
            {
                return correo;
            }
            set
            {
                correo = correo;
                correo = value.Replace(" ", "").Replace("-", "");
            }
        }

        public override string ToString()
        {
            return base.ToString() + " " + telefono;
        }

        private class CSharpImpl
        {
            [Obsolete("Please refactor calling code to use normal Visual Basic assignment")]
            public static T __Assign<T>(ref T target, T value)
            {
                target = value;
                return value;
            }
        }
    }
}