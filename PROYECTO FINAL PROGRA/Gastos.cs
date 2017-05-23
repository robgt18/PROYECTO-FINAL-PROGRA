using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROYECTO_FINAL_PROGRA
{
    public class Gastos
    {
        string nombre;
        string identificacion;
        string tipodereparto;

        public string Nombre
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

        public string Identificacion
        {
            get
            {
                return identificacion;
            }

            set
            {
                identificacion = value;
            }
        }

        public string Tipodereparto
        {
            get
            {
                return tipodereparto;
            }

            set
            {
                tipodereparto = value;
            }
        }
    }
}