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
            objEntidad.sueldo = Convert.ToDouble(tbx_Sueldo.Text);

            objNego.N_Insertar(objEntidad);

            MessageBox.Show("Registro Insertado con exito");
        }

        void Limpiar()
        {
            tbx_Cod.Text = "";
            tbx_Edad.Text = "";
            tbx_Nom.Text = "";
            tbx_Sexo.Text = "";
            tbx_Sueldo.Text = "";
        }

        private void dgv_Datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*Este condicional pregunta cual de las imagenes o botones hemos presionando
              Especificamente, pregunta si presionamos la celda "Eliminar" del DataGridView "dgv_Datos"*/
            if(dgv_Datos.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            {
                DialogResult Respuesta = MessageBox.Show("Está seguro de Eliminar el Registro?", "Advertencia", MessageBoxButtons.YesNo);
                if (Respuesta == DialogResult.Yes) // si la respuesta es si
                {
                    /*Para saber cual es el código de la fila a la que le hicimos clic usamos este código que dice:
                 almacena en objEntidad.cod el código que está en la Celda "CodEmp" de la Fila a la que se le
                 hizo clic ".Row[e.RowIndex].Cells" del DatagridView "dgv_Datos" */
                    objEntidad.cod = Convert.ToInt32(dgv_Datos.Rows[e.RowIndex].Cells["CodEmp"].Value.ToString());
                    //Recargar el DataGridView con los datos del objeto Entidad
                    objNego.N_Eliminar(objEntidad);

                    ListarEmpleado();
                }
                else
                {
                    dgv_Datos.Rows[e.RowIndex].Cells["Eliminar"].Selected = false;
                }
            }
            else if(dgv_Datos.Rows[e.RowIndex].Cells["Editar"].Selected)
            {
                /*llenamos cada uno de los campos de texto con el codigo, nombre, edad, etc. de la Celda de
                  la Fila a la que se le hizo clic.*/
                tbx_Cod.Text = dgv_Datos.Rows[e.RowIndex].Cells["codEmp"].Value.ToString();
                tbx_Nom.Text = dgv_Datos.Rows[e.RowIndex].Cells["nomEmp"].Value.ToString();
                tbx_Edad.Text = dgv_Datos.Rows[e.RowIndex].Cells["edadEmp"].Value.ToString();
                tbx_Sexo.Text = dgv_Datos.Rows[e.RowIndex].Cells["sexoEmp"].Value.ToString();
                tbx_Sueldo.Text = dgv_Datos.Rows[e.RowIndex].Cells["sueldoEmp"].Value.ToString();
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            editar();
            Limpiar();
            ListarEmpleado();
        }

        void editar()
        {
            objEntidad.cod = Convert.ToInt32(tbx_Cod.Text);
            objEntidad.nom = tbx_Nom.Text;
            objEntidad.edad = Convert.ToInt32(tbx_Edad.Text);
            objEntidad.sexo = tbx_Sexo.Text;
            objEntidad.sueldo = Convert.ToDouble(tbx_Sueldo.Text);

            objNego.N_Editar(objEntidad);

            MessageBox.Show("Registro Editado con exito");
        }
    }
}
