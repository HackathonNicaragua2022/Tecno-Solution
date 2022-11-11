using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaNotasF_H_E.Datos
{
    class Cn
    {
        
        public  static string Conexion;
        //public static SqlConection Sqlcon = new SqlConection()

        public static void Armar_Conexion(string ip)
        {           
            try
            {
                Conexion = ("Data Source="+ip+"; Initial catalog = FHernadez; " +
                    "Integrated Security=False; User Id=sa; Password=sas;");

            }
            catch (Exception Ex)
            {
               // DisplayAlert("Conexión",)
            }
        }
    }
}
