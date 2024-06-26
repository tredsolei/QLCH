﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void addCusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCusForm addCusF = new AddCusForm();
            addCusF.Show(this);
        }

        private void editCusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCusForm editCusF = new EditCusForm();
            editCusF.Show(this);
        }

        private void listCusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CusListForm showlistCusForm = new CusListForm();
            showlistCusForm.Show(this);
        }

        private void PrinttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintCusForm printCus = new PrintCusForm();
            printCus.Show(this);
        }
    }
}
