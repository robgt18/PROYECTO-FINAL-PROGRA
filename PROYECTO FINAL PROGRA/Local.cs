using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROYECTO_FINAL_PROGRA
{
    public class Local:Propiedades

    {
        string nombrecomercial;
        string actividad;

        public string Nombrecomercial
        {
            get
            {
                return nombrecomercial;
            }

            set
            {
                nombrecomercial = value;
            }
        }

        public string Actividad
        {
            get
            {
                return actividad;
            }

            set
            {
                actividad = value;
            }
        }
    }
}