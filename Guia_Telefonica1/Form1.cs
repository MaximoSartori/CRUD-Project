using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_Telefonica1
{
    public partial class Form1 : Form
    {
        Dictionary<String, String> personas = new Dictionary<String, String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            String name = tb1.Text;
            String num = tb2.Text;

            personas.Add(name, num);
            tb1.Clear();
            tb2.Clear();

        }

        private void b2_Click(object sender, EventArgs e)
        {
            String llave = tb1.Text;
            if (personas.ContainsKey(llave))
            {
                rtb1.Clear();
                rtb1.Text =$"El nombre `{llave}`  tiene asociado el numero `{personas[llave]}`";
            }
            else {
                rtb1.Clear();
                rtb1.Text = "El nombre ingresado no existe";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtb1.Clear();
            rtb1.AppendText("NOMBRE     NUMERO\n");
            foreach (var persona in personas)
            {
                
                rtb1.AppendText($"   {persona.Key}      -      {persona.Value}\n");
            }
            
        }

        private void b3_Click(object sender, EventArgs e)
        {
            rtb1.Clear();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            rtb1.Clear();
            String nombr = tb1.Text;
            if (personas.ContainsKey(nombr)){
                personas.Remove(nombr);
                rtb1.AppendText("La persona se elimino correctamente");
            }
            else{
                rtb1.AppendText("Selecciona un nombre valido");
            }
                
            
        }
    }
}
