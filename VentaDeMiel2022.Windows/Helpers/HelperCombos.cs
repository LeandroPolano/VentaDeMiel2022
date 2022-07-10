using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Servicio.Servicios;
using VentaDeMiel2022.Servicio.Servicios.Facades;

namespace VentaDeMiel2022.Windows.Helpers
{
    public static class HelperCombos
    {
        public static void CargarDatosComboTipos(ref ComboBox combo)
        {
            IServicioPais servicio = new ServicioPaises();
            var lista = servicio.GetLista();
            Pais pDefault = new Pais()
            {
                PaisId = 0,
                NombrePais = "Seleccione un pais"
            };
            lista.Insert(0, pDefault);
            combo.DataSource = lista;
            combo.DisplayMember = "NombrePais";
            combo.ValueMember = "PaisId";
            combo.SelectedIndex = 0;
        }
    }
}
