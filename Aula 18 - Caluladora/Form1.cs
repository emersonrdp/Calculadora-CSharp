using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_18___Caluladora
{
    public partial class Form1 : Form
    {
        double total, ultimoNumero;
        string operador;

        // MÉTODOS
        private void Limpar()
        {
            total = 0;
            ultimoNumero = 0;
            operador = "+";
            txtresult.Text = "0";
            txthistorico.Text = "";
        }

        private void Calcular()
        {
            switch (operador)
            {
                case "+": 
                    total += ultimoNumero;
                    break;
                case "-":
                    total -= ultimoNumero;
                    break;
                case "x":
                    total *= ultimoNumero;
                    break;
                case "/":
                    total /= ultimoNumero;
                    break;
            }

            ultimoNumero = 0;
            txtresult.Text = total.ToString();
        }
        

        public Form1()
        {
            InitializeComponent();
            Limpar();
        }

        // FUNÇÕES DE CLIQUE DE BOTÕES
        private void gerarnumero(object sender, EventArgs e)
        {
            if (ultimoNumero == 0)
            {
                txtresult.Text = (sender as Button).Text;

                if (txthistorico.Text.EndsWith("="))
                {
                    txthistorico.Text = (sender as Button).Text;
                }
                else
                {
                    txthistorico.Text = txthistorico.Text + (sender as Button).Text;
                }
                
            }
            else
            {
                txtresult.Text = txtresult.Text + (sender as Button).Text;
                txthistorico.Text = txthistorico.Text + (sender as Button).Text;
            }

            ultimoNumero = Convert.ToDouble(txtresult.Text);
            //ultimoNumero = Convert.ToDouble(txthistorico.Text);
            
        }

        private void operadores(object sender, EventArgs e)
        {
            ultimoNumero = Convert.ToDouble(txtresult.Text);
            Calcular();
            operador = (sender as Button).Text;

            if (txthistorico.Text.EndsWith("="))
            {
                txthistorico.Text = txtresult.Text + (sender as Button).Text;
            }
            else
            {
                txthistorico.Text = txthistorico.Text + (sender as Button).Text;
            }
            
        }

        private void btresult_Click(object sender, EventArgs e)
        {
            ultimoNumero = Convert.ToDouble(txtresult.Text);
            Calcular();
            operador = "+";
            total = 0;
            txthistorico.Text = txthistorico.Text + (sender as Button).Text;
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

       
    }
}
