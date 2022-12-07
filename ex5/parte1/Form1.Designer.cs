namespace parte1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botao1 = new System.Windows.Forms.Button();
            this.mensagem1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botao1
            // 
            this.botao1.BackColor = System.Drawing.Color.Black;
            this.botao1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao1.ForeColor = System.Drawing.Color.White;
            this.botao1.Location = new System.Drawing.Point(79, 31);
            this.botao1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(224, 85);
            this.botao1.TabIndex = 0;
            this.botao1.Text = "clique";
            this.botao1.UseVisualStyleBackColor = false;
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // mensagem1
            // 
            this.mensagem1.AutoSize = true;
            this.mensagem1.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensagem1.ForeColor = System.Drawing.Color.Blue;
            this.mensagem1.Location = new System.Drawing.Point(128, 161);
            this.mensagem1.Name = "mensagem1";
            this.mensagem1.Size = new System.Drawing.Size(128, 42);
            this.mensagem1.TabIndex = 1;
            this.mensagem1.Text = "label1";
            this.mensagem1.Click += new System.EventHandler(this.mensagemClicada);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 724);
            this.Controls.Add(this.mensagem1);
            this.Controls.Add(this.botao1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Label mensagem1;
    }
}

