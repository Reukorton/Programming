﻿using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        List<Item> _items;

        public ItemsTab()
        {
            InitializeComponent();

            _items = new List<Item>();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
