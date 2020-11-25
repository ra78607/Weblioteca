
namespace testeDeFrontEnd1
{
    partial class ManterLivros
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BoxCodigoLivro = new System.Windows.Forms.TextBox();
            this.LabelCodigoLivro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BoxCodigoLivro
            // 
            this.BoxCodigoLivro.Location = new System.Drawing.Point(19, 26);
            this.BoxCodigoLivro.Name = "BoxCodigoLivro";
            this.BoxCodigoLivro.Size = new System.Drawing.Size(82, 20);
            this.BoxCodigoLivro.TabIndex = 0;
            // 
            // LabelCodigoLivro
            // 
            this.LabelCodigoLivro.AutoSize = true;
            this.LabelCodigoLivro.Location = new System.Drawing.Point(16, 10);
            this.LabelCodigoLivro.Name = "LabelCodigoLivro";
            this.LabelCodigoLivro.Size = new System.Drawing.Size(84, 13);
            this.LabelCodigoLivro.TabIndex = 1;
            this.LabelCodigoLivro.Text = "Código do Livro:";
            // 
            // ManterLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelCodigoLivro);
            this.Controls.Add(this.BoxCodigoLivro);
            this.Name = "ManterLivros";
            this.Size = new System.Drawing.Size(500, 420);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxCodigoLivro;
        private System.Windows.Forms.Label LabelCodigoLivro;
    }
}
