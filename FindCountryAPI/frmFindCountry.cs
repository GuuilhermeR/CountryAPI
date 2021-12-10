using Newtonsoft.Json;
using QuickType;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace FindCountryAPI
{
    public partial class frmFindCountry : Form
    {
        public frmFindCountry()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CriarColunasPaises()
        {
            if (dtgDados.Columns.Count == 0)
            {
                dtgDados.Columns.Add("nomePais", "País");
                dtgDados.Columns.Add("sigla", "Sigla");
                dtgDados.Columns.Add("moeda", "Moeda");
                dtgDados.Columns.Add("bloco", "Bloco Econômica");
                dtgDados.Columns.Add("bandeira", "Bandeira");
            }
        }

        private async void FindCountrys(string countryName)
        {
            HttpClient teste = new HttpClient { BaseAddress = new Uri("https://restcountries.com") };
            var response = await teste.GetAsync($@"v2/name/{countryName}?fullText=true");
            var content = await response.Content.ReadAsStringAsync();
            if (content.Contains("404"))
                MessageBox.Show("Não foi possível encontrar");

            var countries = JsonConvert.DeserializeObject<Country[]>(content);

            CriarColunasPaises();
            foreach (var country in countries)
            {
                dtgDados.Rows.Add(country.Name, country.Alpha2Code, country.Currencies[0].Code, country.RegionalBlocs[0].Name, country.Flag);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FindCountrys(txtFilterCountry.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dtgDados.Rows.Clear();
            dtgDados.Columns.Clear();
            txtFilterCountry.Text = string.Empty;
        }

        private void dtgDados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 && e.ColumnIndex < 0)
                return;

            if (dtgDados.Columns[e.ColumnIndex].Index == dtgDados.Columns["nomePais"].Index)
            {

            }

        }
    }
}
