using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address;

        public AddressControl()
        {
            InitializeComponent();

            _address = new Address();
        }

        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
    }
}
