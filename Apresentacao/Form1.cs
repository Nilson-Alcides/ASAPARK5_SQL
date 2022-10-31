using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool ValidaCNPJ()
        {
            // Colocar os 12 primeiros números dentro de dados inteiros
            // Calcular esses 12 números e gerar os 2 dígitos verificadores
            // Verificar se é verdadeiro ou falso o CNPJ

            try
            {
                if (!(mkdCPFCNPJ.Text.Length < 18))
                {
                    int n1 = Convert.ToInt16(mkdCPFCNPJ.Text.Substring(0, 1));
                    int n2 = Convert.ToInt16(mkdCPFCNPJ.Text.Substring(1, 1));
                    int n3 = Convert.ToInt16(mkdCPFCNPJ.Text.Substring(3, 1));
                    int n4 = Convert.ToInt16(mkdCPFCNPJ.Text.Substring(4, 1));
                    int n5 = Convert.ToInt16(mkdCPFCNPJ.Text.Substring(5, 1));
                    int n6 = Convert.ToInt16(mkdCPFCNPJ.Text.Substring(7, 1));
                    int n7 = Convert.ToInt16(mkdCPFCNPJ.Text.Substring(8, 1));
                    int n8 = Convert.ToInt16(mkdCPFCNPJ.Text.Substring(9, 1));
                    int n9 = Convert.ToInt16(mkdCPFCNPJ.Text.Substring(11, 1));
                    int n10 = Convert.ToInt16(mkdCPFCNPJ.Text.Substring(12, 1));
                    int n11 = Convert.ToInt16(mkdCPFCNPJ.Text.Substring(13, 1));
                    int n12 = Convert.ToInt16(mkdCPFCNPJ.Text.Substring(14, 1));

                    int digito1 = Convert.ToInt16(mkdCPFCNPJ.Text.Substring(16, 1));
                    int digito2 = Convert.ToInt16(mkdCPFCNPJ.Text.Substring(17, 1));

                    if (n1 == 0 && n2 == 0 && n3 == 0 && n4 == 0 && n5 == 0 && n6 == 0 && n7 == 0 && n8 == 0 && n9 == 0 && n10 == 0 && n11 == 0 && n12 == 0 && digito1 == 0 && digito2 == 0)
                    {
                        return false;
                    }

                    int Soma1 = n1 * 5 + n2 * 4 + n3 * 3 + n4 * 2 + n5 * 9 + n6 * 8 + n7 * 7 + n8 * 6 + n9 * 5 + n10 * 4 + n11 * 3 + n12 * 2;

                    int digitoVerificador1 = Soma1 % 11;

                    if (digitoVerificador1 < 2)
                    {
                        digitoVerificador1 = 0;
                    }
                    else
                    {
                        digitoVerificador1 = 11 - digitoVerificador1;
                    }

                    int Soma2 = n1 * 6 + n2 * 5 + n3 * 4 + n4 * 3 + n5 * 2 + n6 * 9 + n7 * 8 + n8 * 7 + n9 * 6 + n10 * 5 + n11 * 4 + n12 * 3 + digitoVerificador1 * 2;

                    int digitoVerificador2 = Soma2 % 11;

                    if (digitoVerificador2 < 2)
                    {
                        digitoVerificador2 = 0;
                    }
                    else
                    {
                        digitoVerificador2 = 11 - digitoVerificador2;
                    }

                    // Verifica se CNPJ é verdadeiro ou falso
                    if (digito1 == digitoVerificador1 && digito2 == digitoVerificador2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }
            catch { return false; }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (ValidaCNPJ() == true)
            {
                MessageBox.Show("CNPJ Válido!", "Validador de CNPJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("CNPJ Inválido!", "Validador de CNPJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        // Obrigado, até o próximo vídeo! Dúvidas, comentem abaixo. Leia a descrição também para mais informações!
     
    }
        }
    


