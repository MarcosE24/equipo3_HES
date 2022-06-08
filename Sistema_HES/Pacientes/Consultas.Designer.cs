
namespace Sistema_HES
{
    partial class Consultas
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
            this.TbxCi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnReservar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TbxDescripcion = new System.Windows.Forms.TextBox();
            this.CbxHora = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.label10 = new System.Windows.Forms.Label();
            this.LblSala = new System.Windows.Forms.Label();
            this.CbxEspecialidad = new System.Windows.Forms.ComboBox();
            this.LblDoctor = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbxCi
            // 
            this.TbxCi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbxCi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxCi.Location = new System.Drawing.Point(216, 98);
            this.TbxCi.Name = "TbxCi";
            this.TbxCi.Size = new System.Drawing.Size(149, 26);
            this.TbxCi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Documento N°:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre del Doctor :";
            // 
            // TbxFecha
            // 
            this.TbxFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbxFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxFecha.Location = new System.Drawing.Point(169, 149);
            this.TbxFecha.Name = "TbxFecha";
            this.TbxFecha.Size = new System.Drawing.Size(189, 26);
            this.TbxFecha.TabIndex = 6;
            this.TbxFecha.TextChanged += new System.EventHandler(this.ObtenerHoras);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(425, 42);
            this.label5.TabIndex = 8;
            this.label5.Text = "Reservacion de Consulta";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha de consulta:";
            // 
            // BtnReservar
            // 
            this.BtnReservar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnReservar.BackColor = System.Drawing.Color.MintCream;
            this.BtnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReservar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReservar.Location = new System.Drawing.Point(470, 426);
            this.BtnReservar.Name = "BtnReservar";
            this.BtnReservar.Size = new System.Drawing.Size(106, 37);
            this.BtnReservar.TabIndex = 10;
            this.BtnReservar.Text = "Reservar";
            this.BtnReservar.UseVisualStyleBackColor = false;
            this.BtnReservar.Click += new System.EventHandler(this.BtnReservar_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(386, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Consultar con un/a:";
            // 
            // TbxDescripcion
            // 
            this.TbxDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbxDescripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxDescripcion.Location = new System.Drawing.Point(502, 259);
            this.TbxDescripcion.Multiline = true;
            this.TbxDescripcion.Name = "TbxDescripcion";
            this.TbxDescripcion.Size = new System.Drawing.Size(217, 113);
            this.TbxDescripcion.TabIndex = 14;
            // 
            // CbxHora
            // 
            this.CbxHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbxHora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxHora.FormattingEnabled = true;
            this.CbxHora.Items.AddRange(new object[] {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00"});
            this.CbxHora.Location = new System.Drawing.Point(435, 152);
            this.CbxHora.Name = "CbxHora";
            this.CbxHora.Size = new System.Drawing.Size(121, 28);
            this.CbxHora.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(386, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Hora:";
            // 
            // Calendario
            // 
            this.Calendario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Calendario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calendario.Location = new System.Drawing.Point(77, 286);
            this.Calendario.MaxSelectionCount = 1;
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 19;
            this.Calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateSelected);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(304, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Sala:";
            // 
            // LblSala
            // 
            this.LblSala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblSala.AutoSize = true;
            this.LblSala.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSala.Location = new System.Drawing.Point(350, 199);
            this.LblSala.Name = "LblSala";
            this.LblSala.Size = new System.Drawing.Size(17, 20);
            this.LblSala.TabIndex = 21;
            this.LblSala.Text = "0";
            // 
            // CbxEspecialidad
            // 
            this.CbxEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbxEspecialidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxEspecialidad.FormattingEnabled = true;
            this.CbxEspecialidad.Location = new System.Drawing.Point(528, 98);
            this.CbxEspecialidad.Name = "CbxEspecialidad";
            this.CbxEspecialidad.Size = new System.Drawing.Size(190, 28);
            this.CbxEspecialidad.TabIndex = 22;
            this.CbxEspecialidad.SelectedValueChanged += new System.EventHandler(this.CargaMedicoSala);
            // 
            // LblDoctor
            // 
            this.LblDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDoctor.AutoSize = true;
            this.LblDoctor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDoctor.Location = new System.Drawing.Point(180, 199);
            this.LblDoctor.Name = "LblDoctor";
            this.LblDoctor.Size = new System.Drawing.Size(39, 20);
            this.LblDoctor.TabIndex = 23;
            this.LblDoctor.Text = "doc";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCerrar.BackColor = System.Drawing.Color.MintCream;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(582, 426);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(94, 37);
            this.BtnCerrar.TabIndex = 24;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Puede añadir una descripcion(opciona):";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Elija una fecha desde el calendario:";
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(829, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.LblDoctor);
            this.Controls.Add(this.CbxEspecialidad);
            this.Controls.Add(this.LblSala);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.CbxHora);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TbxDescripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnReservar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbxFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxCi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxCi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnReservar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbxDescripcion;
        private System.Windows.Forms.ComboBox CbxHora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblSala;
        private System.Windows.Forms.ComboBox CbxEspecialidad;
        private System.Windows.Forms.Label LblDoctor;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}