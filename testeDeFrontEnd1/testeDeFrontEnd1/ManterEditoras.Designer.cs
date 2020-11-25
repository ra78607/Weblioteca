
namespace testeDeFrontEnd1
{
    partial class ManterEditoras
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
            this.BoxCodigoEditora = new System.Windows.Forms.TextBox();
            this.LabelCodigoEditora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BoxCodigoEditora
            // 
            this.BoxCodigoEditora.Location = new System.Drawing.Point(19, 26);
            this.BoxCodigoEditora.Name = "BoxCodigoEditora";
            this.BoxCodigoEditora.Size = new System.Drawing.Size(82, 20);
            this.BoxCodigoEditora.TabIndex = 3;
            // 
            // LabelCodigoEditora
            // 
            this.LabelCodigoEditora.AutoSize = true;
            this.LabelCodigoEditora.Location = new System.Drawing.Point(16, 10);
            this.LabelCodigoEditora.Name = "LabelCodigoEditora";
            this.LabelCodigoEditora.Size = new System.Drawing.Size(79, 13);
            this.LabelCodigoEditora.TabIndex = 4;
            this.LabelCodigoEditora.Text = "Código Editora:";
            // 
            // ManterEditoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelCodigoEditora);
            this.Controls.Add(this.BoxCodigoEditora);
            this.Name = "ManterEditoras";
            this.Size = new System.Drawing.Size(500, 420);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxCodigoEditora;
        private System.Windows.Forms.Label LabelCodigoEditora;
    }
}
