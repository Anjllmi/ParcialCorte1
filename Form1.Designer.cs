
namespace ParcialCorte1
{
    partial class Modulo1Formulario
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
            this.CNum_Entero1 = new System.Windows.Forms.NumericUpDown();
            this.CNum_Entero2 = new System.Windows.Forms.NumericUpDown();
            this.Bot_EncontrarMayor = new System.Windows.Forms.Button();
            this.Eti_Entero1 = new System.Windows.Forms.Label();
            this.Eti_Entero2 = new System.Windows.Forms.Label();
            this.Eti_Ayuda1 = new System.Windows.Forms.Label();
            this.Eti_Ayuda2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CNum_Entero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CNum_Entero2)).BeginInit();
            this.SuspendLayout();
            // 
            // CNum_Entero1
            // 
            this.CNum_Entero1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNum_Entero1.Location = new System.Drawing.Point(40, 120);
            this.CNum_Entero1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.CNum_Entero1.Name = "CNum_Entero1";
            this.CNum_Entero1.Size = new System.Drawing.Size(120, 26);
            this.CNum_Entero1.TabIndex = 0;
            this.CNum_Entero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CNum_Entero2
            // 
            this.CNum_Entero2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNum_Entero2.Location = new System.Drawing.Point(240, 120);
            this.CNum_Entero2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.CNum_Entero2.Name = "CNum_Entero2";
            this.CNum_Entero2.Size = new System.Drawing.Size(120, 26);
            this.CNum_Entero2.TabIndex = 1;
            this.CNum_Entero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Bot_EncontrarMayor
            // 
            this.Bot_EncontrarMayor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Bot_EncontrarMayor.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bot_EncontrarMayor.ForeColor = System.Drawing.Color.White;
            this.Bot_EncontrarMayor.Location = new System.Drawing.Point(140, 197);
            this.Bot_EncontrarMayor.Name = "Bot_EncontrarMayor";
            this.Bot_EncontrarMayor.Size = new System.Drawing.Size(104, 50);
            this.Bot_EncontrarMayor.TabIndex = 2;
            this.Bot_EncontrarMayor.Text = "Comparar números";
            this.Bot_EncontrarMayor.UseVisualStyleBackColor = false;
            this.Bot_EncontrarMayor.Click += new System.EventHandler(this.Bot_EncontrarMayor_Click);
            // 
            // Eti_Entero1
            // 
            this.Eti_Entero1.AutoSize = true;
            this.Eti_Entero1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eti_Entero1.Location = new System.Drawing.Point(37, 101);
            this.Eti_Entero1.Name = "Eti_Entero1";
            this.Eti_Entero1.Size = new System.Drawing.Size(114, 16);
            this.Eti_Entero1.TabIndex = 3;
            this.Eti_Entero1.Text = "Número entero 1";
            // 
            // Eti_Entero2
            // 
            this.Eti_Entero2.AutoSize = true;
            this.Eti_Entero2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eti_Entero2.Location = new System.Drawing.Point(237, 101);
            this.Eti_Entero2.Name = "Eti_Entero2";
            this.Eti_Entero2.Size = new System.Drawing.Size(114, 16);
            this.Eti_Entero2.TabIndex = 4;
            this.Eti_Entero2.Text = "Número entero 2";
            // 
            // Eti_Ayuda1
            // 
            this.Eti_Ayuda1.AutoSize = true;
            this.Eti_Ayuda1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eti_Ayuda1.ForeColor = System.Drawing.Color.Teal;
            this.Eti_Ayuda1.Location = new System.Drawing.Point(37, 75);
            this.Eti_Ayuda1.Name = "Eti_Ayuda1";
            this.Eti_Ayuda1.Size = new System.Drawing.Size(275, 16);
            this.Eti_Ayuda1.TabIndex = 5;
            this.Eti_Ayuda1.Text = "1.Ingrese los valores para lo dos números.";
            // 
            // Eti_Ayuda2
            // 
            this.Eti_Ayuda2.AutoSize = true;
            this.Eti_Ayuda2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eti_Ayuda2.ForeColor = System.Drawing.Color.Teal;
            this.Eti_Ayuda2.Location = new System.Drawing.Point(37, 178);
            this.Eti_Ayuda2.Name = "Eti_Ayuda2";
            this.Eti_Ayuda2.Size = new System.Drawing.Size(281, 16);
            this.Eti_Ayuda2.TabIndex = 6;
            this.Eti_Ayuda2.Text = "2.Haga clic en el botón Comparar números.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mayor de dos números";
            // 
            // Modulo1Formulario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eti_Ayuda2);
            this.Controls.Add(this.Eti_Ayuda1);
            this.Controls.Add(this.Eti_Entero2);
            this.Controls.Add(this.Eti_Entero1);
            this.Controls.Add(this.Bot_EncontrarMayor);
            this.Controls.Add(this.CNum_Entero2);
            this.Controls.Add(this.CNum_Entero1);
            this.MaximizeBox = false;
            this.Name = "Modulo1Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo 1 - Mayor de dos números";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CNum_Entero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CNum_Entero2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown CNum_Entero1;
        private System.Windows.Forms.NumericUpDown CNum_Entero2;
        private System.Windows.Forms.Button Bot_EncontrarMayor;
        private System.Windows.Forms.Label Eti_Entero1;
        private System.Windows.Forms.Label Eti_Entero2;
        private System.Windows.Forms.Label Eti_Ayuda1;
        private System.Windows.Forms.Label Eti_Ayuda2;
        private System.Windows.Forms.Label label1;
    }
}

