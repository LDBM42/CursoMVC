using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capaEntidad;
using capaNegocio;

namespace capaPresentacion
{
    public partial class P_Mantenimiento : Form
    {
        public P_Mantenimiento()
        {
            InitializeComponent();
        }

        private void P_Mantenimiento_Load(object sender, EventArgs e)
        {
            ListarEmpleado();
        }

        E_Empleados objEntidad = new E_Empleados();
        N_Empleados objNego = new N_Empleados();

        void ListarEmpleado()
        {
            DataTable dt = objNego.N_listado();
            //DataSource permite vaciar un DataTable en un dataGridView
            dgv_Datos.DataSource = dt;
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            Insertar();
            ListarEmpleado(); // para rellenar denuevo la lista al insertarle nuevos datos
        }

        void Insertar()
        {
            objEntidad.nom = tbx_Nom.Text;
            objEntidad.edad = Convert.ToInt32(tbx_Edad.Text);
            objEntidad.sexo = tbx_Sexo.Text;
            objEntidad.sueldo = Convert.ToDouble(tbx_sueldo.Text);

            objNego.N_Insertar(objEntidad);

            MessageBox.Show("Registro Insertado con exito");
        }

        void Limpiar()
        {
            tbx_Cod.Text = "";
            tbx_Edad.Text = "";
            tbx_Nom.Text = "";
            tbx_Sexo.Text = "";
            tbx_sueldo.Text = "";
        }
    }
}
