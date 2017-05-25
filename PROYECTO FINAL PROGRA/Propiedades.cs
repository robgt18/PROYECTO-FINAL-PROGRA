using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROYECTO_FINAL_PROGRA
{
    public class Propiedades
    {
        string tipo;
        string codigopropiedad;
        int metros;
        string nitpropietario;
        List<string> gastos;

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

      

        public int Metros
        {
            get
            {
                return metros;
            }

            set
            {
                metros = value;
            }
        }

        

        public List<string> Gastos
        {
            get
            {
                return gastos;
            }

            set
            {
                gastos = value;
            }
        }

        public string Codigopropiedad
        {
            get
            {
                return codigopropiedad;
            }

            set
            {
                codigopropiedad = value;
            }
        }

        public string Nitpropietario
        {
            get
            {
                return nitpropietario;
            }

            set
            {
                nitpropietario = value;
            }
        }
    }
}