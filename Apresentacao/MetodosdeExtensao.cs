using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public static class MetodosdeExtensao
    {
        #region ValidarVazio
        /// <summary>
        /// verifica se o campo está vazio
        /// </summary>
        /// <param name="txt">Caixa de texto estendida</param>
        /// <returns>O conteudo da caixa de texto validada</returns>
        public static string ValidarVazio(this TextBox txt)
        {
            if (txt.Text.Trim() == "")
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Prencha o campo" + txt.AccessibleName.ToUpper());
            }
            return txt.Text.Trim();
        }
        #endregion
        #region ValidarEmail
        public static string ValidarEmail(this TextBox txt)
        {
            if (!Regex.IsMatch(txt.ValidarVazio(),
                @"^[a-zA-Z0-9\._\-]+\@+[a-zA-Z0-9\._\-]+\.[a-zA-Z]+$"))
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Informe um e-amil válido");
            }
            return txt.Text;
        }
        #endregion
        #region ValidarData
        public static DateTime ValidarData(this TextBox txt)
        {
            try
            {
                return Convert.ToDateTime(txt.ValidarVazio());
            }
            catch (Exception ex)
            {
                txt.Focus();
                txt.SelectAll();
                string msg = "";
                if (ex.Message.Substring(0, 8) == "Preencha")
                {
                    msg = ex.Message;
                }
                else
                {
                    msg = "Informe uma data válida";
                }
                throw new Exception(msg);
            }
        }
        #endregion
        #region ValidarCodigo
        public static int ValidarCodigo(this TextBox txt)
        {
            if (!Regex.IsMatch(txt.ValidarVazio(), @"^[0-9]+$"))
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Informe um código válido");
            }
            return Convert.ToInt32(txt.Text);
        }

        #endregion
        #region LimparTela
        public static void LimparTela(this Form formulario)
        {
            foreach (Control ctl in formulario.Controls)
            {
                if (ctl is TextBox)
                {
                    (ctl as TextBox).Clear();
                }
                else if (ctl is Label && Convert.ToString(ctl.Tag) == "1")
                {
                    ctl.ResetText();
                }

            }
        }
        #endregion

        #region RemoveCaracteresEspeciais

        public static string RemoveCaracteresEspeciais(this TextBox text)
        {
            string NovaRemoveCaracteresEspeciais = text.Text.Replace("'", " ");
            return NovaRemoveCaracteresEspeciais;
        }
        #endregion


    }
}
