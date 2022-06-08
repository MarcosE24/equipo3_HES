
namespace Sistema_HES
{
    partial class Pendientes
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
            this.DgwVista = new System.Windows.Forms.DataGridView();
            this.BtnAtendido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgwVista)).BeginInit();
            this.SuspendLayout();
            // 
            // DgwVista
            // 
            this.DgwVista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgwVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwVista.Location = new System.Drawing.Point(70, 25);
            this.DgwVista.Name = "DgwVista";
            this.DgwVista.Size = new System.Drawing.Size(655, 248);
            this.DgwVista.TabIndex = 0;
            this.DgwVista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwVista_CellClick);
            // 
            // BtnAtendido
            // 
            this.BtnAtendido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAtendido.Enabled = false;
            this.BtnAtendido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtendido.Font = new System.Drawing.Font("Segoe UI Black", 10F);
            this.BtnAtendido.Location = new System.Drawing.Point(310, 312);
            this.BtnAtendido.Name = "BtnAtendido";
            this.BtnAtendido.Size = new System.Drawing.Size(173, 57);
            this.BtnAtendido.TabIndex = 1;
            this.BtnAtendido.Text = "Marcar como Atendido";
            this.BtnAtendido.UseVisualStyleBackColor = true;
            this.BtnAtendido.Click += new System.EventHandler(this.BtnAtendido_Click);
            // 
            // Pendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.BtnAtendido);
            this.Controls.Add(this.DgwVista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pendientes";
            this.Text = "Pendientes";
            ((System.ComponentModel.ISupportInitialize)(this.DgwVista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgwVista;
        private System.Windows.Forms.Button BtnAtendido;
    }
}