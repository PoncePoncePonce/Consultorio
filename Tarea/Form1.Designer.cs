namespace Tarea
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_doctor = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_cita = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_doctor
            // 
            this.btn_doctor.Location = new System.Drawing.Point(67, 107);
            this.btn_doctor.Name = "btn_doctor";
            this.btn_doctor.Size = new System.Drawing.Size(137, 23);
            this.btn_doctor.TabIndex = 0;
            this.btn_doctor.Text = "Registrar doctores";
            this.btn_doctor.UseVisualStyleBackColor = true;
            this.btn_doctor.Click += new System.EventHandler(this.btn_doctor_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.Location = new System.Drawing.Point(67, 174);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(129, 23);
            this.btn_cliente.TabIndex = 1;
            this.btn_cliente.Text = "Registrar Clientes";
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // btn_cita
            // 
            this.btn_cita.Location = new System.Drawing.Point(67, 243);
            this.btn_cita.Name = "btn_cita";
            this.btn_cita.Size = new System.Drawing.Size(128, 23);
            this.btn_cita.TabIndex = 2;
            this.btn_cita.Text = "Agendar una cita";
            this.btn_cita.UseVisualStyleBackColor = true;
            this.btn_cita.Click += new System.EventHandler(this.btn_cita_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(67, 396);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecciona una Acción";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_cita);
            this.Controls.Add(this.btn_cliente);
            this.Controls.Add(this.btn_doctor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_doctor;
        private Button btn_cliente;
        private Button btn_cita;
        private Button btn_exit;
        private Label label1;
    }
}