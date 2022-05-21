using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coset_Sistema_Produccion
{
    public class Class_Fecha_Hora
    {
        public DateTime calcula_fecha_hora(string fecha_hora_string)
        {
            string[] fecha_array_archivo = fecha_hora_string.Split(' ');

            
            DateTime fecha_hora_parse = DateTime.Now;
            
            

            if (CultureInfo.CurrentCulture.ToString() == "es-MX")
            {
                CultureInfo culture = new CultureInfo("es-MX", true);
                DateTime fecha_hora = DateTime.Now;

                if (fecha_hora.ToString().Contains("a.m.") || fecha_hora.ToString().Contains("p.m."))
                {
                    if (fecha_hora_string.Contains("a.m.") || fecha_hora_string.Contains("p.m."))
                    {
                        fecha_hora_parse = DateTime.Parse(fecha_hora_string, culture);
                    }
                    else if (fecha_hora_string.Contains("a. m.") || fecha_hora_string.Contains("p. m."))
                    {
                        culture.DateTimeFormat.AMDesignator = "a.m";
                        culture.DateTimeFormat.PMDesignator = "p.m";
                        fecha_hora_parse = DateTime.Parse(fecha_hora_string, culture);
                    }
                    else
                    {
                        fecha_hora_parse = DateTime.Parse(fecha_hora_string, culture);
                    }
                }
                else if(fecha_hora.ToString().Contains("a. m.") || fecha_hora.ToString().Contains("p. m."))
                {
                    if (fecha_hora_string.Contains("a.m.") || fecha_hora_string.Contains("p.m."))
                    {
                        culture.DateTimeFormat.AMDesignator = "a.m";
                        culture.DateTimeFormat.PMDesignator = "p.m";
                        fecha_hora_parse = DateTime.Parse(fecha_hora_string, culture);
                    }
                    else if (fecha_hora_string.Contains("a. m.") || fecha_hora_string.Contains("p. m."))
                    {
                        fecha_hora_parse = DateTime.Parse(fecha_hora_string, culture);
                    }
                    else
                    {
                        fecha_hora_parse = DateTime.Parse(fecha_hora_string, culture);
                    }
                }
                else
                {
                    fecha_hora_parse = DateTime.Parse(fecha_hora_string, culture);
                }
            }
            else if(CultureInfo.CurrentCulture.ToString() == "en-US")
            {
                CultureInfo culture = new CultureInfo("es-MX", true);
                fecha_hora_parse = DateTime.Parse(fecha_hora_string, culture);
            }
            
           
            return fecha_hora_parse;
        }
    }
}
