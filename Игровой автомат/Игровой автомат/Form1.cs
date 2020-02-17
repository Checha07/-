using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Игровой_автомат
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button button = new Button();
            button.Text = "мы могём всё";
            button.Size=new Size(100,100);
            this.Controls.Add(button);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
            this.Hide();
            string name = textBox1.Text;
        }
    }
}
