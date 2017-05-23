using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROYECTO_FINAL_PROGRA
{
    public class Garage:Propiedades
    {
        string abierta;
        string bodega;

        public string Abierta
        {
            get
            {
                return abierta;
            }

            set
            {
                abierta = value;
            }
        }

        public string Bodega
        {
            get
            {
                return bodega;
            }

            set
            {
                bodega = value;
            }
        }
    }
}