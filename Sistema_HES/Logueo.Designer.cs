﻿
namespace Sistema_HES
{
    partial class Logueo
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
            this.label2 = new System.Windows.Forms.Label();
            this.LblRegistrar = new System.Windows.Forms.Label();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.TbxCi = new System.Windows.Forms.TextBox();
            this.TbxContraseña = new System.Windows.Forms.TextBox();
            this.LblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento N°:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // LblRegistrar
            // 
            this.LblRegistrar.AutoSize = true;
            this.LblRegistrar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistrar.Location = new System.Drawing.Point(122, 265);
            this.LblRegistrar.Name = "LblRegistrar";
            this.LblRegistrar.Size = new System.Drawing.Size(87, 18);
            this.LblRegistrar.TabIndex = 2;
            this.LblRegistrar.Text = "Registrarse";
            this.LblRegistrar.Click += new System.EventHandler(this.LblRegistrar_Click);
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.Location = new System.Drawing.Point(95, 152);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(159, 45);
            this.BtnEntrar.TabIndex = 3;
            this.BtnEntrar.Text = "Iniciar Sesión";
            this.BtnEntrar.UseVisualStyleBackColor = true;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // TbxCi
            // 
            this.TbxCi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxCi.Location = new System.Drawing.Point(133, 46);
            this.TbxCi.Name = "TbxCi";
            this.TbxCi.Size = new System.Drawing.Size(186, 24);
            this.TbxCi.TabIndex = 4;
            // 
            // TbxContraseña
            // 
            this.TbxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxContraseña.Location = new System.Drawing.Point(133, 86);
            this.TbxContraseña.Name = "TbxContraseña";
            this.TbxContraseña.PasswordChar = '*';
            this.TbxContraseña.Size = new System.Drawing.Size(186, 24);
            this.TbxContraseña.TabIndex = 5;
            // 
            // LblError
            // 
            this.LblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.Red;
            this.LblError.Location = new System.Drawing.Point(19, 214);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(307, 31);
            this.LblError.TabIndex = 6;
            this.LblError.Text = "El nombre de Usuario o la Contraseña no son validos. Porfavor verifique e intente" +
    " de nuevo o Registrese :)";
            this.LblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblError.Visible = false;
            // 
            // Logueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 327);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.TbxContraseña);
            this.Controls.Add(this.TbxCi);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.LblRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Logueo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblRegistrar;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.TextBox TbxCi;
        private System.Windows.Forms.TextBox TbxContraseña;
        private System.Windows.Forms.Label LblError;
    }
}

