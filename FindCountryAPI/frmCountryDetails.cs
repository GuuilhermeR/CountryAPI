using QuickType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindCountryAPI
{
    public partial class frmCountryDetails : Form
    {
        List<Country> CountryInfo = new List<Country>();

        public frmCountryDetails(List<Country> country)
        {
            CountryInfo = country;
            InitializeComponent();
        }

        private void frmCountryDetails_Load(object sender, EventArgs e)
        {
            LoadDados();
        }

        public void LoadDados()
        {
            LoadColumns();
            LoadInfos();
        }

        public void LoadInfos()
        {
            string fronteira = string.Empty;
            string timezone = string.Empty;

            foreach (Country cnt in CountryInfo)
            {
                foreach (var bord in cnt.Borders)
                    fronteira += bord + ",";

                foreach (var time in cnt.Timezones)
                    timezone += time + ",";
            }
            fronteira = fronteira.Remove(fronteira.Length - 1);
            timezone = timezone.Remove(timezone.Length - 1);

            foreach (var countryDetail in CountryInfo)
                dtgDados.Rows.Add(countryDetail.Population, timezone
                    , countryDetail.Currencies[0].Symbol, countryDetail.Languages[0].Name
                    , countryDetail.Capital, countryDetail.RegionalBlocs[0].Name, fronteira);

            dtgDados.AutoResizeColumns();
        }

        public void LoadColumns()
        {
            if (dtgDados.Columns.Count == 0)
            {
                dtgDados.Columns.Add("pop", "População");
                dtgDados.Columns.Add("time", "Horário Local");
                dtgDados.Columns.Add("moeda", "Moedas");
                dtgDados.Columns.Add("lingua", "Idioma");
                dtgDados.Columns.Add("capital", "Capital");
                dtgDados.Columns.Add("bloco", "Bloco Econômico");
                dtgDados.Columns.Add("fronteira", "Fronteira");
            }
        }
    }
}
