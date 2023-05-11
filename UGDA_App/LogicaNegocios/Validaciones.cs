using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ServicioSocial.Forms.Clases
{
    class Validaciones
    {
        public bool email(string email)
        {
            string formato;
            formato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if(Regex.IsMatch(email, formato))
            {
                if(Regex.Replace(email,formato,String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool carnet(string carnet)
        {
            string formato;

            formato = "^[A-Z]{2}|[0-9]{4}$";

            if (Regex.IsMatch(carnet, formato))
            {
                if (Regex.Replace(carnet, formato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool letras(string letras)
        {
            string formato;

            formato = "[a-zA-ZñÑ\\s]{2,50}";

            if (Regex.IsMatch(letras, formato))
            {
                if (Regex.Replace(letras, formato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool ubicacion(string ubicacion)
        {
            string formato;

            formato = "[a-zA-Z]{2}|[-]{1}|";

            if (Regex.IsMatch(ubicacion, formato))
            {
                if (Regex.Replace(ubicacion, formato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
