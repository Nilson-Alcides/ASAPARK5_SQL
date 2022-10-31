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
    public partial class FrmSplash1 : Form
    {
        public FrmSplash1()
        {
            InitializeComponent();
        }

        private void Tempo_Tick(object sender, EventArgs e)
        {
            this.BarradeProgresso.Value = this.BarradeProgresso.Value + 2;
            if (BarradeProgresso.Value == 10)
            {
                lblModulos.Text = "Lendo modulos..";
            }
            else if (this.BarradeProgresso.Value == 20)
            {
                lblModulos.Text = "Ativando modulos.";
            }
            else if (this.BarradeProgresso.Value == 40)
            {
                lblModulos.Text = "Iniciando modulos..";
            }
            else if (this.BarradeProgresso.Value == 60)
            {
                lblModulos.Text = "Carregando modulos..";
            }
            else if (this.BarradeProgresso.Value == 80)
            {
                lblModulos.Text = "Preparando modules..";
            }
            else if (this.BarradeProgresso.Value == 100)
            {
                Tempo.Enabled = false;
                this.Visible = false;
                FrmMenu frmMenu = new FrmMenu();
                frmMenu.ShowDialog();
            }
        }
    }
}
