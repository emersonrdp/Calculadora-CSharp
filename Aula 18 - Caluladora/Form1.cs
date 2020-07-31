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
        double total, ultimoNumero, trocaSinal;
        string operador;

        // MÉTODOS
        private void Limpar()
        {
            total = 0;
            ultimoNumero = 0;
            operador = "+";
            txtresult.Text = "0";
            txthistorico.Text = "";
            bt_trocasinal.Enabled = true;
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
                case "mod":
                    total = total % ultimoNumero;
                    break;
                /*case "%":
                    total = total * ( 1 + ( ultimoNumero / 100 );
                    break;*/            // x*(1+(y/100))    calculo de percentual -> y% de x
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
                /* Se o ultimonumero for 0 não vai mostrar o numero no histórico, após digitar um operador ou  a 
                    igualdade sempre vai fazer o calculo e após o calculo o ultimonumero e zerado.  
                    Ao digitar numero nunca vai mostrar o numero no histórico, so é mostrado no hitórico ao lançar o operador
                    ou o resultado.*/

                 if ((sender as Button).Text == "," || txtresult.Text == "0,")
                 {
                     txtresult.Text = txtresult.Text + (sender as Button).Text;
                 }
                 else
                 {
                     txtresult.Text = (sender as Button).Text;
                    
                 }  
            }
            else
            {
                txtresult.Text = txtresult.Text + (sender as Button).Text;
                //txthistorico.Text = txthistorico.Text + (sender as Button).Text;
            }

            ultimoNumero = Convert.ToDouble(txtresult.Text);
            bt_trocasinal.Enabled = true;
        }

        private void operadores(object sender, EventArgs e)
        {
            // verificaçãose a ultima letra é "=" no campo do histórico do calculo
            if (txthistorico.Text.EndsWith("="))
            {
                txthistorico.Text = txtresult.Text + (sender as Button).Text;
            }
            else
            {
                txthistorico.Text = txthistorico.Text + txtresult.Text + (sender as Button).Text;
            }

            ultimoNumero = Convert.ToDouble(txtresult.Text);
            Calcular();
            operador = (sender as Button).Text;
            bt_trocasinal.Enabled = false;
        }

        private void btresult_Click(object sender, EventArgs e)
        {
            txthistorico.Text = txthistorico.Text + txtresult.Text + (sender as Button).Text;
            ultimoNumero = Convert.ToDouble(txtresult.Text);
            Calcular();
            operador = "+";
            total = 0;
            bt_trocasinal.Enabled = true;
        }

        private void bt_trocasinal_Click(object sender, EventArgs e)
        {
            trocaSinal = Convert.ToDouble(txtresult.Text) * (-1);
            txtresult.Text = trocaSinal.ToString();
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }     
    }
}
// depois verificar como alterar para que ao clicar no botão operador mais de uma vz não fiu fazendo contas sem digitar numeros