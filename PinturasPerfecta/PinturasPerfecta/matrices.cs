using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinturasPerfecta
{
    public class matrices
    {
        public string[,] matriz;
        
        public string[,] getmatriz()
        {
            return this.matriz;
        }
        public void setmatriz(string[,] _matriz)
        {
            this.matriz = _matriz;
        }
    }
}
