namespace capaPresentacion
{
    partial class P_Mantenimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_Mantenimiento));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_Cod = new System.Windows.Forms.TextBox();
            this.tbx_Nom = new System.Windows.Forms.TextBox();
            this.tbx_Edad = new System.Windows.Forms.TextBox();
            this.tbx_Sexo = new System.Windows.Forms.TextBox();
            this.tbx_sueldo = new System.Windows.Forms.TextBox();
            this.dgv_Datos = new System.Windows.Forms.DataGridView();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.codEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento de Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Edad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sueldo:";
            // 
            // tbx_Cod
            // 
            this.tbx_Cod.Location = new System.Drawing.Point(110, 74);
            this.tbx_Cod.Name = "tbx_Cod";
            this.tbx_Cod.Size = new System.Drawing.Size(100, 22);
            this.tbx_Cod.TabIndex = 7;
            // 
            // tbx_Nom
            // 
            this.tbx_Nom.Location = new System.Drawing.Point(110, 118);
            this.tbx_Nom.Name = "tbx_Nom";
            this.tbx_Nom.Size = new System.Drawing.Size(100, 22);
            this.tbx_Nom.TabIndex = 8;
            // 
            // tbx_Edad
            // 
            this.tbx_Edad.Location = new System.Drawing.Point(110, 162);
            this.tbx_Edad.Name = "tbx_Edad";
            this.tbx_Edad.Size = new System.Drawing.Size(100, 22);
            this.tbx_Edad.TabIndex = 9;
            // 
            // tbx_Sexo
            // 
            this.tbx_Sexo.Location = new System.Drawing.Point(110, 206);
            this.tbx_Sexo.Name = "tbx_Sexo";
            this.tbx_Sexo.Size = new System.Drawing.Size(100, 22);
            this.tbx_Sexo.TabIndex = 10;
            // 
            // tbx_sueldo
            // 
            this.tbx_sueldo.Location = new System.Drawing.Point(110, 250);
            this.tbx_sueldo.Name = "tbx_sueldo";
            this.tbx_sueldo.Size = new System.Drawing.Size(100, 22);
            this.tbx_sueldo.TabIndex = 11;
            // 
            // dgv_Datos
            // 
            this.dgv_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEmp,
            this.nomEmp,
            this.edadEmp,
            this.sexoEmp,
            this.sueldoEmp,
            this.Eliminar,
            this.Editar});
            this.dgv_Datos.Location = new System.Drawing.Point(234, 74);
            this.dgv_Datos.Name = "dgv_Datos";
            this.dgv_Datos.RowTemplate.Height = 24;
            this.dgv_Datos.Size = new System.Drawing.Size(689, 198);
            this.dgv_Datos.TabIndex = 12;
            this.dgv_Datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Datos_CellContentClick);
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.AutoSize = true;
            this.btn_Insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insertar.Location = new System.Drawing.Point(460, 289);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(220, 30);
            this.btn_Insertar.TabIndex = 13;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.AutoSize = true;
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Location = new System.Drawing.Point(702, 289);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(220, 30);
            this.btn_Editar.TabIndex = 14;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
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
            this.nomEmp.FillWeight = 40F;
            this.nomEmp.HeaderText = "Nombre";
            this.nomEmp.Name = "nomEmp";
            this.nomEmp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // edadEmp
            // 
            this.edadEmp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.edadEmp.DataPropertyName = "edadEmp";
            this.edadEmp.FillWeight = 10F;
            this.edadEmp.HeaderText = "Edad";
            this.edadEmp.Name = "edadEmp";
            this.edadEmp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sexoEmp
            // 
            this.sexoEmp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sexoEmp.DataPropertyName = "sexoEmp";
            this.sexoEmp.FillWeight = 10F;
            this.sexoEmp.HeaderText = "Sexo";
            this.sexoEmp.Name = "sexoEmp";
            this.sexoEmp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sueldoEmp
            // 
            this.sueldoEmp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sueldoEmp.DataPropertyName = "sueldoEmp";
            this.sueldoEmp.FillWeight = 20F;
            this.sueldoEmp.HeaderText = "Sueldo";
            this.sueldoEmp.Name = "sueldoEmp";
            this.sueldoEmp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Eliminar.FillWeight = 15F;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Editar.FillWeight = 15F;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            // 
            // P_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 350);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Insertar);
            this.Controls.Add(this.dgv_Datos);
            this.Controls.Add(this.tbx_sueldo);
            this.Controls.Add(this.tbx_Sexo);
            this.Controls.Add(this.tbx_Edad);
            this.Controls.Add(this.tbx_Nom);
            this.Controls.Add(this.tbx_Cod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "P_Mantenimiento";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.P_Mantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_Cod;
        private System.Windows.Forms.TextBox tbx_Nom;
        private System.Windows.Forms.TextBox tbx_Edad;
        private System.Windows.Forms.TextBox tbx_Sexo;
        private System.Windows.Forms.TextBox tbx_sueldo;
        private System.Windows.Forms.DataGridView dgv_Datos;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoEmp;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
    }
}