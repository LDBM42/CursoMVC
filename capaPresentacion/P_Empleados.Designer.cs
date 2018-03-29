namespace capaPresentacion
{
    partial class P_Empleados
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Empleados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEmp,
            this.nomEmp,
            this.edadEmp,
            this.sexoEmp,
            this.sueldoEmp});
            this.dataGridView1.Location = new System.Drawing.Point(28, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(588, 283);
            this.dataGridView1.TabIndex = 1;
            // 
            // codEmp
            // 
            this.codEmp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codEmp.DataPropertyName = "codEmp";
            this.codEmp.FillWeight = 15F;
            this.codEmp.HeaderText = "Código";
            this.codEmp.Name = "codEmp";
            this.codEmp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nomEmp
            // 
            this.nomEmp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomEmp.DataPropertyName = "nomEmp";
            this.nomEmp.FillWeight = 35F;
            this.nomEmp.HeaderText = "Nombre";
            this.nomEmp.Name = "nomEmp";
            this.nomEmp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // edadEmp
            // 
            this.edadEmp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.edadEmp.DataPropertyName = "edadEmp";
            this.edadEmp.FillWeight = 25F;
            this.edadEmp.HeaderText = "Edad";
            this.edadEmp.Name = "edadEmp";
            this.edadEmp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sexoEmp
            // 
            this.sexoEmp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sexoEmp.DataPropertyName = "sexoEmp";
            this.sexoEmp.FillWeight = 25F;
            this.sexoEmp.HeaderText = "Sexo";
            this.sexoEmp.Name = "sexoEmp";
            this.sexoEmp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sueldoEmp
            // 
            this.sueldoEmp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sueldoEmp.DataPropertyName = "sueldoEmp";
            this.sueldoEmp.FillWeight = 25F;
            this.sueldoEmp.HeaderText = "Sueldo";
            this.sueldoEmp.Name = "sueldoEmp";
            this.sueldoEmp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // P_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 390);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "P_Empleados";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.P_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoEmp;
    }
}

