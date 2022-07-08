using System;
using System.Windows.Forms;
using VentaDeMiel2022.Entidades.Entidades;

namespace VentaDeMiel2022.Windows
{
    public partial class FrmPaisAE : Form
    {
        public FrmPaisAE()
        {
            InitializeComponent();
        }

        private Pais pais;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (pais!=null)
            {
                PaisTextBox.Text = pais.NombrePais;
            }
        }

        public Pais GetTipo()
        {
            return pais;
        }


        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        private void GuardarIconButton_Click(object sender, EventArgs e)
        {
            if (pais==null)
            {
                pais = new Pais();
            }

            pais.NombrePais = PaisTextBox.Text;
            DialogResult = DialogResult.OK;
        }

        public void SetTipo(Pais pais)
        {
            this.pais = pais;
        }
    }
}
