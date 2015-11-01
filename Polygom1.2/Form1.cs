using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Structs;

namespace Polygom1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            Result.Text = null;
        }

        // Кнопка открывающая новую форму CircleForm
        private void Circle_Click(object sender, EventArgs e)
        {
            CircleForm f2 = new CircleForm(this);
            f2.Show();
        }

        // Кнопка открывающая новую форму PolygonForm
        private void PolygonButton_Click(object sender, EventArgs e)
        {
            PolygonForm f3 = new PolygonForm(this);
            f3.Show();
        }
    }
}
