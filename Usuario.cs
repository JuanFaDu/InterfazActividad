using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Usuario
    {
        public String nombre;
        public String correo;
        public String contrasena;

        public Usuario(String nombre, String correo, String contrasena)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.contrasena = contrasena;
        }
    }
}
