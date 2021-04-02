using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinturasPerfecta
{
    class MediadorClientes
    {
        private string Id;
        private string Nombre;
        private string Apellido;
        private string Email;
        private string Direccion;

        public string getId()
        {
            return this.Id;
        }
        public string getNombre()
        {
            return this.Nombre;
        }
        public string getApellido()
        {
            return this.Apellido;
        }

        public string getEmail()
        {
            return this.Email;
        }

        public string getDireccion()
        {
            return this.Direccion;
        }

        public void setId(string _id)
        {
            this.Id = _id;
        }

        public void setNombre(string _Nombre)
        {
            this.Nombre = _Nombre;
        }

        public void setApellido(string _Apellido)
        {
            this.Apellido = _Apellido;
        }

        public void setEmail(string _Email)
        {
            this.Email = _Email;
        }

        public void setDireccion(string _Direccion)
        {
            this.Direccion = _Direccion;
        }
    }
}
