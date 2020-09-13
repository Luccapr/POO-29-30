namespace POO_3A_29_30
{
    partial class Inicio
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
            this.btnAutor = new System.Windows.Forms.Button();
            this.btnEditora = new System.Windows.Forms.Button();
            this.btnLivro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAutor
            // 
            this.btnAutor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAutor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutor.Location = new System.Drawing.Point(36, 33);
            this.btnAutor.Name = "btnAutor";
            this.btnAutor.Size = new System.Drawing.Size(153, 148);
            this.btnAutor.TabIndex = 0;
            this.btnAutor.Text = "Autor";
            this.btnAutor.UseVisualStyleBackColor = false;
            this.btnAutor.Click += new System.EventHandler(this.btnAutor_Click);
            // 
            // btnEditora
            // 
            this.btnEditora.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEditora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditora.Location = new System.Drawing.Point(258, 33);
            this.btnEditora.Name = "btnEditora";
            this.btnEditora.Size = new System.Drawing.Size(153, 148);
            this.btnEditora.TabIndex = 1;
            this.btnEditora.Text = "Editora";
            this.btnEditora.UseVisualStyleBackColor = false;
            this.btnEditora.Click += new System.EventHandler(this.btnEditora_Click);
            // 
            // btnLivro
            // 
            this.btnLivro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLivro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivro.Location = new System.Drawing.Point(484, 33);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.Size = new System.Drawing.Size(153, 148);
            this.btnLivro.TabIndex = 2;
            this.btnLivro.Text = "Livro";
            this.btnLivro.UseVisualStyleBackColor = false;
            this.btnLivro.Click += new System.EventHandler(this.btnLivro_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(670, 203);
            this.Controls.Add(this.btnLivro);
            this.Controls.Add(this.btnEditora);
            this.Controls.Add(this.btnAutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inicio";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAutor;
        private System.Windows.Forms.Button btnEditora;
        private System.Windows.Forms.Button btnLivro;
    }
}

