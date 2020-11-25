
namespace testeDeFrontEnd1
{
    partial class ManterAutores
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
            this.LabelCodigoAutor = new System.Windows.Forms.Label();
            this.BoxCodigoAutor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelCodigoAutor
            // 
            this.LabelCodigoAutor.AutoSize = true;
            this.LabelCodigoAutor.Location = new System.Drawing.Point(16, 10);
            this.LabelCodigoAutor.Name = "LabelCodigoAutor";
            this.LabelCodigoAutor.Size = new System.Drawing.Size(71, 13);
            this.LabelCodigoAutor.TabIndex = 0;
            this.LabelCodigoAutor.Text = "Código Autor:";
            // 
            // BoxCodigoAutor
            // 
            this.BoxCodigoAutor.Location = new System.Drawing.Point(19, 26);
            this.BoxCodigoAutor.Name = "BoxCodigoAutor";
            this.BoxCodigoAutor.Size = new System.Drawing.Size(82, 20);
            this.BoxCodigoAutor.TabIndex = 1;
            // 
            // ManterAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BoxCodigoAutor);
            this.Controls.Add(this.LabelCodigoAutor);
            this.Name = "ManterAutores";
            this.Size = new System.Drawing.Size(500, 420);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCodigoAutor;
        private System.Windows.Forms.TextBox BoxCodigoAutor;
    }
}
