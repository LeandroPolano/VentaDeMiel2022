using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Servicio.Servicios;
using VentaDeMiel2022.Servicio.Servicios.Facades;

namespace VentaDeMiel2022.Windows
{
    public partial class FrmProvinciaAE : Form
    {
        private IServicioPais servicio;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            servicio = new ServicioPaises();
            CargarDatosComboPaises(ref PaisComboBox);
        }

        private void CargarDatosComboPaises(ref ComboBox paisComboBox)
        {
            var lista = servicio.GetLista();
            Pais pDefault = new Pais()
            {
                PaisId = 0,
                NombrePais = "Seleccione Pais"
            };
            lista.Insert(0, pDefault);
            paisComboBox.DataSource = lista;
            paisComboBox.DisplayMember = "NombrePais";
            paisComboBox.ValueMember = "PaisId";
            paisComboBox.SelectedIndex = 0;
        }

        public FrmProvinciaAE()
        {
            InitializeComponent();
        }

        private Provincia provincia;
        public Provincia GetTipo()
        {
            return provincia;
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        private void GuardarIconButton_Click(object sender, EventArgs e)
        {

        }
    }
}
