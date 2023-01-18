// elaborado por Oscar Abraham Arroyo Gómez
// 17/01/2024
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generadorContraseña
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int minLength = 8;
            int maxLength = 16;

            //characters used
            String Chars = "ABCDEFGHYJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz1234567890#$%&'()*+,-./:;<=>?@[]^_`{|}~";
            String Upper = "ABCDEFGHYJKLMNÑOPQRSTUVWXYZ";
            String Lower = "abcdefghijklmnñopqrstuvwxyz";
            String numbers = "1234567890";
            String Special = "#$%&'()*+,-./:;<=>?@[]^_`{|}~";
            
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            // random length for password 8-16
            int passwordLength = random.Next(minLength, maxLength + 1);

            while (passwordLength-->0)
                password.Append(Chars[random.Next(Chars.Length)]);
           
            passwordText.Text =  password.ToString();


        }
    }
}
