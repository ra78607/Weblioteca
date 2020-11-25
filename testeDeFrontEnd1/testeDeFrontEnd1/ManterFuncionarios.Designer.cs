
namespace testeDeFrontEnd1
{
    partial class ManterFuncionarios
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
            this.LabelManterFuncionarios = new System.Windows.Forms.Label();
            this.BoxCodigoFuncionario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelManterFuncionarios
            // 
            this.LabelManterFuncionarios.AutoSize = true;
            this.LabelManterFuncionarios.Location = new System.Drawing.Point(16, 10);
            this.LabelManterFuncionarios.Name = "LabelManterFuncionarios";
            this.LabelManterFuncionarios.Size = new System.Drawing.Size(101, 13);
            this.LabelManterFuncionarios.TabIndex = 1;
            this.LabelManterFuncionarios.Text = "Codigo Funcionário:";
            // 
            // BoxCodigoFuncionario
            // 
            this.BoxCodigoFuncionario.Location = new System.Drawing.Point(19, 26);
            this.BoxCodigoFuncionario.Name = "BoxCodigoFuncionario";
            this.BoxCodigoFuncionario.Size = new System.Drawing.Size(82, 20);
            this.BoxCodigoFuncionario.TabIndex = 2;
            // 
            // ManterFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BoxCodigoFuncionario);
            this.Controls.Add(this.LabelManterFuncionarios);
            this.Name = "ManterFuncionarios";
            this.Size = new System.Drawing.Size(500, 420);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelManterFuncionarios;
        private System.Windows.Forms.TextBox BoxCodigoFuncionario;
    }
}
