
namespace testeDeFrontEnd1
{
    partial class ManterClientes
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
            this.BoxCodigoAutor = new System.Windows.Forms.TextBox();
            this.LabelCodigoCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BoxCodigoAutor
            // 
            this.BoxCodigoAutor.Location = new System.Drawing.Point(19, 26);
            this.BoxCodigoAutor.Name = "BoxCodigoAutor";
            this.BoxCodigoAutor.Size = new System.Drawing.Size(82, 20);
            this.BoxCodigoAutor.TabIndex = 3;
            // 
            // LabelCodigoCliente
            // 
            this.LabelCodigoCliente.AutoSize = true;
            this.LabelCodigoCliente.Location = new System.Drawing.Point(16, 10);
            this.LabelCodigoCliente.Name = "LabelCodigoCliente";
            this.LabelCodigoCliente.Size = new System.Drawing.Size(78, 13);
            this.LabelCodigoCliente.TabIndex = 2;
            this.LabelCodigoCliente.Text = "Código Cliente:";
            // 
            // ManterClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BoxCodigoAutor);
            this.Controls.Add(this.LabelCodigoCliente);
            this.Location = new System.Drawing.Point(16, 10);
            this.Name = "ManterClientes";
            this.Size = new System.Drawing.Size(500, 420);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxCodigoAutor;
        private System.Windows.Forms.Label LabelCodigoCliente;
    }
}
