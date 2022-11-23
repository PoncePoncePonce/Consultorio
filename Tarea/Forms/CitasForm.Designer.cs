namespace Tarea.Forms
{
    partial class CitasForm
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
            this.txtlabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_doc = new System.Windows.Forms.TextBox();
            this.txt_cli = new System.Windows.Forms.TextBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.dtg_doctores = new System.Windows.Forms.DataGridView();
            this.dtg_clientes = new System.Windows.Forms.DataGridView();
            this.dtg_citas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_doctor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_doctores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_citas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtlabel1
            // 
            this.txtlabel1.AutoSize = true;
            this.txtlabel1.Location = new System.Drawing.Point(25, 133);
            this.txtlabel1.Name = "txtlabel1";
            this.txtlabel1.Size = new System.Drawing.Size(134, 15);
            this.txtlabel1.TabIndex = 0;
            this.txtlabel1.Text = "Doctor (Solo el nombre)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente (Solo el Nombre)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // txt_doc
            // 
            this.txt_doc.Location = new System.Drawing.Point(29, 167);
            this.txt_doc.Name = "txt_doc";
            this.txt_doc.Size = new System.Drawing.Size(100, 23);
            this.txt_doc.TabIndex = 3;
            // 
            // txt_cli
            // 
            this.txt_cli.Location = new System.Drawing.Point(30, 286);
            this.txt_cli.Name = "txt_cli";
            this.txt_cli.Size = new System.Drawing.Size(100, 23);
            this.txt_cli.TabIndex = 4;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(30, 392);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(216, 23);
            this.dtp_fecha.TabIndex = 5;
            // 
            // dtg_doctores
            // 
            this.dtg_doctores.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtg_doctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_doctores.Location = new System.Drawing.Point(295, 43);
            this.dtg_doctores.Name = "dtg_doctores";
            this.dtg_doctores.RowTemplate.Height = 25;
            this.dtg_doctores.Size = new System.Drawing.Size(508, 150);
            this.dtg_doctores.TabIndex = 6;
            // 
            // dtg_clientes
            // 
            this.dtg_clientes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtg_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_clientes.Location = new System.Drawing.Point(295, 230);
            this.dtg_clientes.Name = "dtg_clientes";
            this.dtg_clientes.RowTemplate.Height = 25;
            this.dtg_clientes.Size = new System.Drawing.Size(508, 150);
            this.dtg_clientes.TabIndex = 7;
            // 
            // dtg_citas
            // 
            this.dtg_citas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtg_citas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_citas.Location = new System.Drawing.Point(295, 411);
            this.dtg_citas.Name = "dtg_citas";
            this.dtg_citas.RowTemplate.Height = 25;
            this.dtg_citas.Size = new System.Drawing.Size(508, 179);
            this.dtg_citas.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Doctores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Clientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Citas";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(107, 495);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 12;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(107, 567);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Regresar";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(48, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Agendar Citas";
            // 
            // cmb_doctor
            // 
            this.cmb_doctor.FormattingEnabled = true;
            this.cmb_doctor.Location = new System.Drawing.Point(135, 167);
            this.cmb_doctor.Name = "cmb_doctor";
            this.cmb_doctor.Size = new System.Drawing.Size(121, 23);
            this.cmb_doctor.TabIndex = 15;
            // 
            // CitasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 614);
            this.Controls.Add(this.cmb_doctor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_citas);
            this.Controls.Add(this.dtg_clientes);
            this.Controls.Add(this.dtg_doctores);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.txt_cli);
            this.Controls.Add(this.txt_doc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlabel1);
            this.Name = "CitasForm";
            this.Text = "CitasForm";
            this.Load += new System.EventHandler(this.Todo_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_doctores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_citas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtlabel1;
        private Label label2;
        private Label label3;
        private TextBox txt_doc;
        private TextBox txt_cli;
        private DateTimePicker dtp_fecha;
        private DataGridView dtg_doctores;
        private DataGridView dtg_clientes;
        private DataGridView dtg_citas;
        private Label label1;
        private Label label4;
        private Label label5;
        private Button btn_Aceptar;
        private Button btn_exit;
        private Label label6;
        private ComboBox cmb_doctor;
    }
}