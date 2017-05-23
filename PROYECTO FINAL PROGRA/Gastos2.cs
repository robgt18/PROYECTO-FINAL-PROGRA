using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROYECTO_FINAL_PROGRA
{
    public class Gastos2
    {
        string idgastos;
        string descripcion;
        int importe;
        string tipodezona;

        public string Idgastos
        {
            get
            {
                return idgastos;
            }

            set
            {
                idgastos = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public int Importe
        {
            get
            {
                return importe;
            }

            set
            {
                importe = value;
            }
        }

        public string Tipodezona
        {
            get
            {
                return tipodezona;
            }

            set
            {
                tipodezona = value;
            }
        }
    }
}