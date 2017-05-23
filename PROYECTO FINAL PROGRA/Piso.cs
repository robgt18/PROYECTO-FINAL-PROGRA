using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROYECTO_FINAL_PROGRA
{
    public class Piso
    {
        string vhvn;
        int habitaciones;

        public string Vhvn
        {
            get
            {
                return vhvn;
            }

            set
            {
                vhvn = value;
            }
        }

        public int Habitaciones
        {
            get
            {
                return habitaciones;
            }

            set
            {
                habitaciones = value;
            }
        }
    }
}