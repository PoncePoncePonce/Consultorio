namespace Tarea.Forms
{
    partial class DoctoresForm
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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.dtgDoctores = new System.Windows.Forms.DataGridView();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_nombre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoctores)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(222, 382);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 0;
            this.btn_aceptar.Text = "Registrar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // dtgDoctores
            // 
            this.dtgDoctores.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDoctores.Location = new System.Drawing.Point(222, 95);
            this.dtgDoctores.Name = "dtgDoctores";
            this.dtgDoctores.RowTemplate.Height = 25;
            this.dtgDoctores.Size = new System.Drawing.Size(478, 244);
            this.dtgDoctores.TabIndex = 2;
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(57, 244);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(100, 23);
            this.txt_cedula.TabIndex = 3;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(57, 330);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(113, 23);
            this.txt_telefono.TabIndex = 4;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(57, 170);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 23);
            this.txt_Apellido.TabIndex = 5;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(16, 77);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_nombre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cédula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numero de telefono";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(369, 382);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "Regresar";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(304, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Registrar Doctores";
            // 
            // cmb_nombre
            // 
            this.cmb_nombre.FormattingEnabled = true;
            this.cmb_nombre.Location = new System.Drawing.Point(16, 106);
            this.cmb_nombre.Name = "cmb_nombre";
            this.cmb_nombre.Size = new System.Drawing.Size(121, 23);
            this.cmb_nombre.TabIndex = 13;
            // 
            // DoctoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.dtgDoctores);
            this.Controls.Add(this.btn_aceptar);
            this.Name = "DoctoresForm";
            this.Text = "DoctoresForm";
            this.Load += new System.EventHandler(this.Todolist_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoctores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_aceptar;
        private DataGridView dtgDoctores;
        private TextBox txt_cedula;
        private TextBox txt_telefono;
        private TextBox txt_Apellido;
        private TextBox txt_nombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_exit;
        private Label label5;
        private ComboBox cmb_nombre;
    }
}