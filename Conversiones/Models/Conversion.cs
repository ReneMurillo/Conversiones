using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conversiones.Models
{
    public class Conversion
    {
        private string UnidadIngresada { get; set; }
        private double ValorUnidad { get; set; }
        private string UnidadEsperada { get; set; }

        public string RealizarConversion(string pUnidadIngresada, double pValor, string pUnidadEsperada)
        {
            this.UnidadEsperada = pUnidadEsperada;
            this.ValorUnidad = pValor;
            this.UnidadIngresada = pUnidadIngresada;

            double resultado = 0;
            string mensaje = "";

            switch (UnidadIngresada)
            {
                case "Centimetros":
                    if(UnidadEsperada == "Centimetros")
                    {
                        resultado = ValorUnidad * 1 ;
                        mensaje = ValorUnidad + " cm es igual a " + resultado + " cm";
                    }else if(UnidadEsperada == "Metros")
                    {
                        resultado = ValorUnidad / 100;
                        mensaje = ValorUnidad + " cm es igual a " + resultado + " m";
                    }
                    else if (UnidadEsperada == "Kilometros")
                    {
                        resultado = (ValorUnidad / 100) / 1000;
                        mensaje = ValorUnidad + " cm es igual a " + resultado + " km";
                    }
                    else if (UnidadEsperada == "Millas")
                    {
                        resultado = ((ValorUnidad / 100) / 1000) / 0.621371;
                        mensaje = ValorUnidad + " cm es igual a " + resultado + " millas";
                    }
                    break;
                case "Metros":
                    if (UnidadEsperada == "Centimetros")
                    {
                        resultado = ValorUnidad * 100;
                        mensaje = ValorUnidad + " m es igual a " + resultado + " cm";
                    }
                    else if (UnidadEsperada == "Metros")
                    {
                        resultado = ValorUnidad * 1;
                        mensaje = ValorUnidad + " m es igual a " + resultado + " m";
                    }
                    else if (UnidadEsperada == "Kilometros")
                    {
                        resultado = (ValorUnidad / 1000);
                        mensaje = ValorUnidad + " m es igual a " + resultado + " km";
                    }
                    else if (UnidadEsperada == "Millas")
                    {
                        resultado = (ValorUnidad / 1000) / 0.621371;
                        mensaje = ValorUnidad + " m es igual a " + resultado + " millas";
                    }
                    break;
                case "Kilometros":
                    if (UnidadEsperada == "Centimetros")
                    {
                        resultado = (ValorUnidad * 1000) * 100;
                        mensaje = ValorUnidad + " km es igual a " + resultado + " cm";
                    }
                    else if (UnidadEsperada == "Metros")
                    {
                        resultado = ValorUnidad * 1000;
                        mensaje = ValorUnidad + " km es igual a " + resultado + " m";
                    }
                    else if (UnidadEsperada == "Kilometros")
                    {
                        resultado = ValorUnidad * 1;
                        mensaje = ValorUnidad + " km es igual a " + resultado + " km";
                    }
                    else if (UnidadEsperada == "Millas")
                    {
                        resultado = ValorUnidad * 0.621371;
                        mensaje = ValorUnidad + " km es igual a " + resultado + " millas";
                    }
                    break;
                case "Millas":
                    if (UnidadEsperada == "Centimetros")
                    {
                        resultado = ((ValorUnidad / 0.621371)* 1000) * 100;
                        mensaje = ValorUnidad + " millas es igual a " + resultado + " cm";
                    }
                    else if (UnidadEsperada == "Metros")
                    {
                        resultado = (ValorUnidad / 0.621371) * 1000;
                        mensaje = ValorUnidad + " millas es igual a " + resultado + " m";
                    }
                    else if (UnidadEsperada == "Kilometros")
                    {
                        resultado = ValorUnidad / 0.621371;
                        mensaje = ValorUnidad + "millas es igual a " + resultado + " km";
                    }
                    else if (UnidadEsperada == "Millas")
                    {
                        resultado = ValorUnidad * 1;
                        mensaje = ValorUnidad + "millas es igual a " + resultado + " millas";
                    }
                    break;
            }
            return mensaje;
        }
    }
}