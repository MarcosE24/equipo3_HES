
namespace Sistema_HES
{
    partial class ModificarConsulta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.DgwListaConsulta = new System.Windows.Forms.DataGridView();
            this.TbxDescripcion = new System.Windows.Forms.TextBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CbxHora = new System.Windows.Forms.ComboBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblMedico = new System.Windows.Forms.Label();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.CbxEspecialidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgwListaConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "MODIFICACION DE CONSULTA";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Especialidad:";
            // 
            // TbxFecha
            // 
            this.TbxFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbxFecha.Enabled = false;
            this.TbxFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxFecha.Location = new System.Drawing.Point(332, 393);
            this.TbxFecha.Name = "TbxFecha";
            this.TbxFecha.Size = new System.Drawing.Size(187, 26);
            this.TbxFecha.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha:";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(754, 473);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(131, 32);
            this.BtnCerrar.TabIndex = 8;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // DgwListaConsulta
            // 
            this.DgwListaConsulta.AllowUserToAddRows = false;
            this.DgwListaConsulta.AllowUserToDeleteRows = false;
            this.DgwListaConsulta.AllowUserToResizeColumns = false;
            this.DgwListaConsulta.AllowUserToResizeRows = false;
            this.DgwListaConsulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgwListaConsulta.BackgroundColor = System.Drawing.Color.White;
            this.DgwListaConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwListaConsulta.Location = new System.Drawing.Point(12, 54);
            this.DgwListaConsulta.MultiSelect = false;
            this.DgwListaConsulta.Name = "DgwListaConsulta";
            this.DgwListaConsulta.ReadOnly = true;
            this.DgwListaConsulta.RowHeadersVisible = false;
            this.DgwListaConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgwListaConsulta.Size = new System.Drawing.Size(905, 252);
            this.DgwListaConsulta.TabIndex = 10;
            this.DgwListaConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwListaConsulta_CellClick);
            // 
            // TbxDescripcion
            // 
            this.TbxDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbxDescripcion.Enabled = false;
            this.TbxDescripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxDescripcion.Location = new System.Drawing.Point(684, 320);
            this.TbxDescripcion.Multiline = true;
            this.TbxDescripcion.Name = "TbxDescripcion";
            this.TbxDescripcion.Size = new System.Drawing.Size(227, 99);
            this.TbxDescripcion.TabIndex = 11;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEditar.Enabled = false;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(480, 473);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(131, 32);
            this.BtnEditar.TabIndex = 12;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hora:";
            // 
            // CbxHora
            // 
            this.CbxHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbxHora.Enabled = false;
            this.CbxHora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxHora.FormattingEnabled = true;
            this.CbxHora.Location = new System.Drawing.Point(325, 456);
            this.CbxHora.Name = "CbxHora";
            this.CbxHora.Size = new System.Drawing.Size(121, 28);
            this.CbxHora.TabIndex = 15;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(617, 473);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(131, 32);
            this.BtnEliminar.TabIndex = 16;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(589, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medico:\r\n";
            // 
            // LblMedico
            // 
            this.LblMedico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblMedico.AutoSize = true;
            this.LblMedico.Enabled = false;
            this.LblMedico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedico.Location = new System.Drawing.Point(462, 323);
            this.LblMedico.Name = "LblMedico";
            this.LblMedico.Size = new System.Drawing.Size(67, 20);
            this.LblMedico.TabIndex = 18;
            this.LblMedico.Text = "Medico";
            // 
            // Calendario
            // 
            this.Calendario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Calendario.Enabled = false;
            this.Calendario.Location = new System.Drawing.Point(14, 360);
            this.Calendario.MaxSelectionCount = 1;
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 19;
            this.Calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateSelected);
            // 
            // CbxEspecialidad
            // 
            this.CbxEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbxEspecialidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxEspecialidad.FormattingEnabled = true;
            this.CbxEspecialidad.Location = new System.Drawing.Point(136, 320);
            this.CbxEspecialidad.Name = "CbxEspecialidad";
            this.CbxEspecialidad.Size = new System.Drawing.Size(189, 28);
            this.CbxEspecialidad.TabIndex = 20;
            // 
            // ModificarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(931, 540);
            this.Controls.Add(this.CbxEspecialidad);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.LblMedico);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.CbxHora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.TbxDescripcion);
            this.Controls.Add(this.DgwListaConsulta);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarConsulta";
            this.Text = "ModificarConsulta";
            this.Load += new System.EventHandler(this.ModificarConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgwListaConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbxFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridView DgwListaConsulta;
        private System.Windows.Forms.TextBox TbxDescripcion;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbxHora;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblMedico;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.ComboBox CbxEspecialidad;
    }
}