
namespace ParcialCorte1
{
    partial class Modulo3Formulario
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
            this.CajTex_Texto = new System.Windows.Forms.TextBox();
            this.Eti_Ayuda1 = new System.Windows.Forms.Label();
            this.Eti_Titulo = new System.Windows.Forms.Label();
            this.CajTex_Letra = new System.Windows.Forms.TextBox();
            this.Eti_Ayuda2 = new System.Windows.Forms.Label();
            this.Eti_Ayuda3 = new System.Windows.Forms.Label();
            this.Bot_ContarLetras = new System.Windows.Forms.Button();
            this.Eti_Advertencia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CajTex_Texto
            // 
            this.CajTex_Texto.BackColor = System.Drawing.Color.White;
            this.CajTex_Texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CajTex_Texto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajTex_Texto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CajTex_Texto.Location = new System.Drawing.Point(9, 95);
            this.CajTex_Texto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CajTex_Texto.Multiline = true;
            this.CajTex_Texto.Name = "CajTex_Texto";
            this.CajTex_Texto.Size = new System.Drawing.Size(430, 40);
            this.CajTex_Texto.TabIndex = 0;
            this.CajTex_Texto.Text = "Escribe aquí ";
            // 
            // Eti_Ayuda1
            // 
            this.Eti_Ayuda1.AutoSize = true;
            this.Eti_Ayuda1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eti_Ayuda1.ForeColor = System.Drawing.Color.Teal;
            this.Eti_Ayuda1.Location = new System.Drawing.Point(9, 76);
            this.Eti_Ayuda1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Eti_Ayuda1.Name = "Eti_Ayuda1";
            this.Eti_Ayuda1.Size = new System.Drawing.Size(184, 16);
            this.Eti_Ayuda1.TabIndex = 1;
            this.Eti_Ayuda1.Text = "1.Escribe lo que quieras  aquí:";
            // 
            // Eti_Titulo
            // 
            this.Eti_Titulo.AutoSize = true;
            this.Eti_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eti_Titulo.ForeColor = System.Drawing.Color.Gray;
            this.Eti_Titulo.Location = new System.Drawing.Point(146, 16);
            this.Eti_Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Eti_Titulo.Name = "Eti_Titulo";
            this.Eti_Titulo.Size = new System.Drawing.Size(183, 18);
            this.Eti_Titulo.TabIndex = 2;
            this.Eti_Titulo.Text = "Módulo 3 - Cuenta Letras";
            // 
            // CajTex_Letra
            // 
            this.CajTex_Letra.BackColor = System.Drawing.Color.Azure;
            this.CajTex_Letra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CajTex_Letra.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajTex_Letra.Location = new System.Drawing.Point(223, 140);
            this.CajTex_Letra.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CajTex_Letra.MaxLength = 1;
            this.CajTex_Letra.Name = "CajTex_Letra";
            this.CajTex_Letra.Size = new System.Drawing.Size(20, 22);
            this.CajTex_Letra.TabIndex = 3;
            this.CajTex_Letra.Text = "x";
            this.CajTex_Letra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Eti_Ayuda2
            // 
            this.Eti_Ayuda2.AutoSize = true;
            this.Eti_Ayuda2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eti_Ayuda2.ForeColor = System.Drawing.Color.Teal;
            this.Eti_Ayuda2.Location = new System.Drawing.Point(9, 143);
            this.Eti_Ayuda2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Eti_Ayuda2.Name = "Eti_Ayuda2";
            this.Eti_Ayuda2.Size = new System.Drawing.Size(210, 16);
            this.Eti_Ayuda2.TabIndex = 4;
            this.Eti_Ayuda2.Text = "2.Digita la letra que quieres contar:";
            // 
            // Eti_Ayuda3
            // 
            this.Eti_Ayuda3.AutoSize = true;
            this.Eti_Ayuda3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eti_Ayuda3.ForeColor = System.Drawing.Color.Teal;
            this.Eti_Ayuda3.Location = new System.Drawing.Point(11, 188);
            this.Eti_Ayuda3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Eti_Ayuda3.Name = "Eti_Ayuda3";
            this.Eti_Ayuda3.Size = new System.Drawing.Size(226, 16);
            this.Eti_Ayuda3.TabIndex = 5;
            this.Eti_Ayuda3.Text = "3.Haz clic en el botón \"Contar letras\":";
            // 
            // Bot_ContarLetras
            // 
            this.Bot_ContarLetras.BackColor = System.Drawing.Color.Teal;
            this.Bot_ContarLetras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bot_ContarLetras.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bot_ContarLetras.ForeColor = System.Drawing.Color.White;
            this.Bot_ContarLetras.Location = new System.Drawing.Point(238, 181);
            this.Bot_ContarLetras.Name = "Bot_ContarLetras";
            this.Bot_ContarLetras.Size = new System.Drawing.Size(100, 30);
            this.Bot_ContarLetras.TabIndex = 6;
            this.Bot_ContarLetras.Text = "Contar letras";
            this.Bot_ContarLetras.UseVisualStyleBackColor = false;
            this.Bot_ContarLetras.Click += new System.EventHandler(this.Bot_ContarLetras_Click);
            // 
            // Eti_Advertencia
            // 
            this.Eti_Advertencia.AutoSize = true;
            this.Eti_Advertencia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eti_Advertencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Eti_Advertencia.Location = new System.Drawing.Point(9, 236);
            this.Eti_Advertencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Eti_Advertencia.Name = "Eti_Advertencia";
            this.Eti_Advertencia.Size = new System.Drawing.Size(456, 16);
            this.Eti_Advertencia.TabIndex = 7;
            this.Eti_Advertencia.Text = "[!] Las letras tildadas y variaciones similares cuentan como letras distintas [!]" +
    "";
            // 
            // Modulo3Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 261);
            this.Controls.Add(this.Eti_Advertencia);
            this.Controls.Add(this.Bot_ContarLetras);
            this.Controls.Add(this.Eti_Ayuda3);
            this.Controls.Add(this.Eti_Ayuda2);
            this.Controls.Add(this.CajTex_Letra);
            this.Controls.Add(this.Eti_Titulo);
            this.Controls.Add(this.Eti_Ayuda1);
            this.Controls.Add(this.CajTex_Texto);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Modulo3Formulario";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo3 - Cuenta letras";
            this.Load += new System.EventHandler(this.Modulo3Formulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CajTex_Texto;
        private System.Windows.Forms.Label Eti_Ayuda1;
        private System.Windows.Forms.Label Eti_Titulo;
        private System.Windows.Forms.TextBox CajTex_Letra;
        private System.Windows.Forms.Label Eti_Ayuda2;
        private System.Windows.Forms.Label Eti_Ayuda3;
        private System.Windows.Forms.Button Bot_ContarLetras;
        private System.Windows.Forms.Label Eti_Advertencia;
    }
}