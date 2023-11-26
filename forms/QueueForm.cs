﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoOrganizer
{
    public partial class QueueForm : Form
    {
        public QueueForm()
        {
            InitializeComponent();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = MainModule.Queue.items;

            dataGridView1.DataSource = bindingSource;
        }
    }
}
