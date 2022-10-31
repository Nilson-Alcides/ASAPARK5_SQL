using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public class Validacao
    {
        //https://www.youtube.com/channel/UCFLpNBurSkltf_xYi7dRRjg/videos

        public bool ValidaCNPJ()
        {
            // Colocar os 12 primeiros números dentro de dados inteiros
            // Calcular esses 12 números e gerar os 2 dígitos verificadores
            // Verificar se é verdadeiro ou falso o CNPJ
            MaskedTextBox maskedTextBox = new MaskedTextBox();
            try
            {
                if (!(maskedTextBox.Text.Length < 18))
                {
                    int n1 = Convert.ToInt16(maskedTextBox.Text.Substring(0, 1));
                    int n2 = Convert.ToInt16(maskedTextBox.Text.Substring(1, 1));
                    int n3 = Convert.ToInt16(maskedTextBox.Text.Substring(3, 1));
                    int n4 = Convert.ToInt16(maskedTextBox.Text.Substring(4, 1));
                    int n5 = Convert.ToInt16(maskedTextBox.Text.Substring(5, 1));
                    int n6 = Convert.ToInt16(maskedTextBox.Text.Substring(7, 1));
                    int n7 = Convert.ToInt16(maskedTextBox.Text.Substring(8, 1));
                    int n8 = Convert.ToInt16(maskedTextBox.Text.Substring(9, 1));
                    int n9 = Convert.ToInt16(maskedTextBox.Text.Substring(11, 1));
                    int n10 = Convert.ToInt16(maskedTextBox.Text.Substring(12, 1));
                    int n11 = Convert.ToInt16(maskedTextBox.Text.Substring(13, 1));
                    int n12 = Convert.ToInt16(maskedTextBox.Text.Substring(14, 1));

                    int digito1 = Convert.ToInt16(maskedTextBox.Text.Substring(16, 1));
                    int digito2 = Convert.ToInt16(maskedTextBox.Text.Substring(17, 1));

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
        bool ValidarRG(string RG)
        {
            try
            {
                // Pegar os 8 primeiros dígitos e multiplicar o primeiro por 2, e cada número subir + 1 até chegar em 9
                // RG = textBox1.Text.Replace(".", "").Replace("-", "").Replace(",", "").Replace(" ", "").Trim();

                int n1 = int.Parse(RG.Substring(0, 1));
                int n2 = int.Parse(RG.Substring(1, 1));
                int n3 = int.Parse(RG.Substring(2, 1));
                int n4 = int.Parse(RG.Substring(3, 1));
                int n5 = int.Parse(RG.Substring(4, 1));
                int n6 = int.Parse(RG.Substring(5, 1));
                int n7 = int.Parse(RG.Substring(6, 1));
                int n8 = int.Parse(RG.Substring(7, 1));

                string DV = RG.Substring(8, 1);

                int Soma = n1 * 2 + n2 * 3 + n3 * 4 + n4 * 5 + n5 * 6 + n6 * 7 + n7 * 8 + n8 * 9;

                string digitoVerificador = Convert.ToString(Soma % 11);

                // Se o dígito verificador for igual a 1, automaticamente ele se tornará o algarismo romano X,
                // pois será feito o cálculo de 11 - o dígito verificador. No caso, ficaria 11 - 1, que é igual a 10.

                if (digitoVerificador == "1")
                {
                    digitoVerificador = "X";
                }

                // Se o dígito verificador for igual a 0, automaticamente ele se torna 0, pois 11 - 0 é igual a 11, e
                // não será permitido isso no dígito verificador, então automaticamente o dígito será 0.
                else if (digitoVerificador == "0")
                {
                    digitoVerificador = "0";
                }

                // Se não for nem 0 nem 1, vai ser feito 11 - o dígito verificador. Por exemplo, se o a soma dividida por 11
                // deu resto 5, será feito 11 - 5, que é igual a 6. Então automaticamente o dígito verificador do RG se tornará o número 6!

                else
                {
                    digitoVerificador = (11 - int.Parse(digitoVerificador)).ToString();
                }

                // Verificar se o dígito verificador é igual ao DV do RG que está sendo validado.

                if (digitoVerificador == DV)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (ValidarRG(textBox1.Text))
        //    {
        //        MessageBox.Show("RG Válido!", "Validador de RG", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //        MessageBox.Show("RG Inválido!", "Validador de RG", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        // Agora coloque um CPF dentro da maskedTextBox e clique em validar!
        // É isso, voltei a ativa novamente. Até o próximo vídeo :)
        // Links na descrição.

        bool validaCPF()
        {
            // Para entender mais o algoritmo sendo feito, visite o site do início do vídeo. Link na descrição!
            MaskedTextBox maskedTextBox1 = new MaskedTextBox();
            if (maskedTextBox1.Text.Length == 14)
            {
                int n1 = Convert.ToInt16(maskedTextBox1.Text.Substring(0, 1));
                int n2 = Convert.ToInt16(maskedTextBox1.Text.Substring(1, 1));
                int n3 = Convert.ToInt16(maskedTextBox1.Text.Substring(2, 1));
                int n4 = Convert.ToInt16(maskedTextBox1.Text.Substring(4, 1));
                int n5 = Convert.ToInt16(maskedTextBox1.Text.Substring(5, 1));
                int n6 = Convert.ToInt16(maskedTextBox1.Text.Substring(6, 1));
                int n7 = Convert.ToInt16(maskedTextBox1.Text.Substring(8, 1));
                int n8 = Convert.ToInt16(maskedTextBox1.Text.Substring(9, 1));
                int n9 = Convert.ToInt16(maskedTextBox1.Text.Substring(10, 1));

                int n10 = Convert.ToInt16(maskedTextBox1.Text.Substring(12, 1));
                int n11 = Convert.ToInt16(maskedTextBox1.Text.Substring(13, 1));

                // Se todos os números forem iguais, irá burlar o validador, e retornar true
                if (n1 == n2 && n2 == n3 && n3 == n4 && n4 == n5 && n5 == n6 && n6 == n7 && n7 == n8 && n8 == n9)
                {
                    return false;
                }
                else
                {
                    // Somar todos os números multiplicados
                    int Soma1 = n1 * 10 + n2 * 9 + n3 * 8 + n4 * 7 + n5 * 6 + n6 * 5 + n7 * 4 + n8 * 3 + n9 * 2;

                    // Dividir por 11 e retornar o resto da divisão
                    int digitoVerificador1 = Soma1 % 11;

                    // Verificar se o valor obtido é menor que dois ou maior
                    if (digitoVerificador1 < 2)
                    {
                        digitoVerificador1 = 0;
                    }
                    else
                    {
                        digitoVerificador1 = 11 - digitoVerificador1;
                    }

                    // Soma todos os números multiplicados
                    int Soma2 = n1 * 11 + n2 * 10 + n3 * 9 + n4 * 8 + n5 * 7 + n6 * 6 + n7 * 5 + n8 * 4 + n9 * 3 + digitoVerificador1 * 2;

                    // Dividir por 11 e retornar o resto da divisão
                    int digitoVerificador2 = Soma2 % 11;

                    // Verificar se o valor obtido é menor ou maior que 2
                    if (digitoVerificador2 < 2)
                    {
                        digitoVerificador2 = 0;
                    }
                    else
                    {
                        digitoVerificador2 = 11 - digitoVerificador2;
                    }

                    // Verifica se os dois dígitos são iguais aos do CPF digitado na maskedTextBox
                    if (digitoVerificador1 == n10 && digitoVerificador2 == n11)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }
    }
}
