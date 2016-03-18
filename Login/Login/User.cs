using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class User
    {
        private string nombre;
        private string pass;
        private string role;
        


        public User(string nombre, string pass, string role)
        {
            this.nombre = nombre;
            this.pass = pass;
            this.role = role;
        }


        public string Nombre
        {
            get
            { return nombre; }

            set
            { nombre = value; }
        }

        public string Pass
        {
            get { return pass; }

            set { pass = value; }
        }

        public string Role
        {
            get { return role; }

            set { role = value; }
        }
    }
}
