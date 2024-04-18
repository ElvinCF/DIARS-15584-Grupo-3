using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class ConexionN
    {
        Conexion cn= new Conexion();
        public int conSQL(string user)
        {
            return cn.consultalogin(user);
        }



    }
}
