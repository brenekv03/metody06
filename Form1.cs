using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metody06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string retezec = "Bohdan má 4 velmi dlouhé nohy";
            VymazatCislice(ref retezec);
            char[] mez = { ' ' };
            string[] slova = retezec.Split(mez, StringSplitOptions.RemoveEmptyEntries);
            foreach(string x in slova)
            {
                listBox1.Items.Add(x);
            }
        }
        static private void VymazatCislice(ref string retezec)
        {
            int i = 0;
            while(i<retezec.Length)
            {
                if (char.IsDigit(retezec[i]))
                {
                    string substr = retezec.Substring(0, i);
                    string substr2 = retezec.Substring(i+1);
                    retezec = substr + substr2;
                }
                else i++;
            }
        }
    }
}
