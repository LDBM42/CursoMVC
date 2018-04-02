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

        public void N_Insertar(E_Empleados emp)
        {
            objDato.D_insertar(emp); //pasamos el objeto de la capa E_Empleados como parametro al metodo D_insertar.
        }

        public void N_Eliminar(E_Empleados emp)
        {
            objDato.D_eliminar(emp);
        }

        public void N_Editar(E_Empleados emp)
        {
            objDato.D_editar(emp);
        }
    }
}
