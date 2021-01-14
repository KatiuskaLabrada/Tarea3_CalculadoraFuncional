/*
 * Programa que realiza las operaciones matemáticas basicas
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3_Calculadora
{
    public partial class Calculadora : Form
    {
        int value1, value2, valSum, valRes, valMult, valDiv;

        private void calculate_Click(object sender, EventArgs e)
        {
            //Asignar valor a las variables
            value1 = Convert.ToInt32(val1.Text);
            value2 = Convert.ToInt32(val2.Text);

            //Calculos matematicos
            valSum = value1 + value2;
            valRes = value1 - value2;
            valMult = value1 * value2;
            valDiv = value1 / value2;

            //Mostrar los resultados
            this.sum.Text = valSum.ToString();
            this.rest.Text = valRes.ToString();
            this.mult.Text = valMult.ToString();
            this.div.Text = valDiv.ToString();
        }

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        //Función que limpia todos loc campos
        private void clear_Click(object sender, EventArgs e)
        {
            val1.Clear();
            val2.Clear();
            sum.Clear();
            rest.Clear();
            mult.Clear();
            div.Clear();
        }

        //Función que cierra la aplicación
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
