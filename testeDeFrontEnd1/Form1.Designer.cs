
namespace testeDeFrontEnd1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.botao_relatorios = new System.Windows.Forms.Button();
            this.botao_reservas = new System.Windows.Forms.Button();
            this.botao_emprestimos = new System.Windows.Forms.Button();
            this.botao_cadastros = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cadastros1 = new testeDeFrontEnd1.Cadastros();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.botao_relatorios);
            this.panel1.Controls.Add(this.botao_reservas);
            this.panel1.Controls.Add(this.botao_emprestimos);
            this.panel1.Controls.Add(this.botao_cadastros);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 542);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SidePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 110);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 62);
            this.SidePanel.TabIndex = 1;
            // 
            // botao_relatorios
            // 
            this.botao_relatorios.FlatAppearance.BorderSize = 0;
            this.botao_relatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_relatorios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_relatorios.ForeColor = System.Drawing.SystemColors.Control;
            this.botao_relatorios.Image = ((System.Drawing.Image)(resources.GetObject("botao_relatorios.Image")));
            this.botao_relatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botao_relatorios.Location = new System.Drawing.Point(0, 314);
            this.botao_relatorios.Name = "botao_relatorios";
            this.botao_relatorios.Size = new System.Drawing.Size(200, 62);
            this.botao_relatorios.TabIndex = 6;
            this.botao_relatorios.Text = "Relatórios";
            this.botao_relatorios.UseVisualStyleBackColor = true;
            // 
            // botao_reservas
            // 
            this.botao_reservas.FlatAppearance.BorderSize = 0;
            this.botao_reservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_reservas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_reservas.ForeColor = System.Drawing.SystemColors.Control;
            this.botao_reservas.Image = ((System.Drawing.Image)(resources.GetObject("botao_reservas.Image")));
            this.botao_reservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botao_reservas.Location = new System.Drawing.Point(0, 246);
            this.botao_reservas.Name = "botao_reservas";
            this.botao_reservas.Size = new System.Drawing.Size(200, 62);
            this.botao_reservas.TabIndex = 5;
            this.botao_reservas.Text = "Reservas";
            this.botao_reservas.UseVisualStyleBackColor = true;
            // 
            // botao_emprestimos
            // 
            this.botao_emprestimos.FlatAppearance.BorderSize = 0;
            this.botao_emprestimos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_emprestimos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_emprestimos.ForeColor = System.Drawing.SystemColors.Control;
            this.botao_emprestimos.Image = ((System.Drawing.Image)(resources.GetObject("botao_emprestimos.Image")));
            this.botao_emprestimos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botao_emprestimos.Location = new System.Drawing.Point(0, 178);
            this.botao_emprestimos.Name = "botao_emprestimos";
            this.botao_emprestimos.Size = new System.Drawing.Size(200, 62);
            this.botao_emprestimos.TabIndex = 4;
            this.botao_emprestimos.Text = "Empréstimos";
            this.botao_emprestimos.UseVisualStyleBackColor = true;
            // 
            // botao_cadastros
            // 
            this.botao_cadastros.FlatAppearance.BorderSize = 0;
            this.botao_cadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_cadastros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_cadastros.ForeColor = System.Drawing.SystemColors.Control;
            this.botao_cadastros.Image = ((System.Drawing.Image)(resources.GetObject("botao_cadastros.Image")));
            this.botao_cadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botao_cadastros.Location = new System.Drawing.Point(0, 110);
            this.botao_cadastros.Name = "botao_cadastros";
            this.botao_cadastros.Size = new System.Drawing.Size(200, 62);
            this.botao_cadastros.TabIndex = 3;
            this.botao_cadastros.Text = "Cadastros";
            this.botao_cadastros.UseVisualStyleBackColor = true;
            this.botao_cadastros.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 22);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(206, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 69);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sistema de Gestão de Bibliotecas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Webiblioteca";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cadastros1);
            this.panel4.Location = new System.Drawing.Point(200, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(729, 421);
            this.panel4.TabIndex = 5;
            // 
            // cadastros1
            // 
            this.cadastros1.Location = new System.Drawing.Point(6, 3);
            this.cadastros1.Name = "cadastros1";
            this.cadastros1.Size = new System.Drawing.Size(729, 424);
            this.cadastros1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 542);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botao_cadastros;
        private System.Windows.Forms.Button botao_emprestimos;
        private System.Windows.Forms.Button botao_relatorios;
        private System.Windows.Forms.Button botao_reservas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel4;
        private Cadastros cadastros1;
        private System.Windows.Forms.Panel SidePanel;
    }
}

