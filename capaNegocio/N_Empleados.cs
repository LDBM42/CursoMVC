using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

using capaDatos;
using capaEntidad;


namespace capaNegocio
{
    public class N_Empleados
    {
        // Para poder usar la clase de la capa datos, hay que instanciarla
        D_Empleados objDato = new D_Empleados();

        //Se crea un metodo de tipo DataTable para poder recibir el DataTable que devuelve la clase D_Empledados
        public DataTable N_listado()
        {
            return objDato.D_listado();
        }

    }
}
