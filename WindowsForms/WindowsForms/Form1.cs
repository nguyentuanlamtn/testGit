using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {

        public static Form1 minstance;
        public static Form1 Instance
        {
            get
            {
                if (minstance == null || minstance.IsDisposed)
                {
                    minstance = new Form1();
                }
                return minstance;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        bool Temp;
        bool Form_Load;
		private bool IsEnMod;
    }
}
