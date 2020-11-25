﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeDeFrontEnd1
{
    public partial class Emprestimos : UserControl
    {
        public Emprestimos()
        {
            InitializeComponent();
        }

        private void EmprestarExemplares_Click(object sender, EventArgs e)
        {
            SidePanelForm1.Height = EmprestarExemplares.Height;
            SidePanelForm1.Top = EmprestarExemplares.Top;
        }

        private void DevolucaoExemplares_Click(object sender, EventArgs e)
        {
            SidePanelForm1.Height = DevolucaoExemplares.Height;
            SidePanelForm1.Top = DevolucaoExemplares.Top;
        }

        private void FaturarEmprestimo_Click(object sender, EventArgs e)
        {
            SidePanelForm1.Height = FaturarEmprestimo.Height;
            SidePanelForm1.Top = FaturarEmprestimo.Top;
        }

        private void ProlongarEmprestimo_Click(object sender, EventArgs e)
        {
            SidePanelForm1.Height = ProlongarEmprestimo.Height;
            SidePanelForm1.Top = ProlongarEmprestimo.Top;
        }
    }
}