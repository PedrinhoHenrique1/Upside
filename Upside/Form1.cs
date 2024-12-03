using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upside
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_FinishRegister_Click(object sender, EventArgs e)
        {
            string txb_User1 = textBox1.Text.Trim();
            string txb_Password1 = textBox2.Text.Trim();

            // Verificação das credenciais
            if (txb_User1 == "Pedro" && txb_Password1 == "123")
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }

            if (txb_User1 == "admin" && txb_Password1 == "admin")
            {
                Admin admin = new Admin();
                admin.ShowDialog();
            }

            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            }
        }
    }
}
