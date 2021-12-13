using Newtonsoft.Json;
using QuickType;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace FindCountryAPI
{
    public partial class frmFindCountry : Form
    {
        HttpClient api = new HttpClient { BaseAddress = new Uri("https://restcountries.com") };
        List<Country> countryInfo = new List<Country>();


        public frmFindCountry()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {        
            //var response = await api.GetAsync("/v3.1/all");
            //var content = await response.Content.ReadAsStringAsync();

            //var countries = JsonConvert.DeserializeObject(content);
        }

        private void CriarColunasPaises()
        {
            if (dtgDados.Columns.Count == 0)
                dtgDados.Columns.Add("nomePais", "País");
                dtgDados.Columns.Add("sigla", "Sigla");
                dtgDados.Columns.Add("moeda", "Moeda");
                dtgDados.Columns.Add("bloco", "Bloco Econômica");
                dtgDados.Columns.Add("bandeira", "Bandeira");

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FindCountrys(txtCountry.Text);
        }

        private async void FindCountrys(string countryName)
        {
            Country country1 = new Country();

            var response = await api.GetAsync($@"v2/name/{countryName}?fullText=true");
            var content = await response.Content.ReadAsStringAsync();
            if (content.Contains("404"))
            {
                MessageBox.Show("Não foi possível encontrar esse país!");
                return;
            }

            var countries = JsonConvert.DeserializeObject<Country[]>(content);

            CriarColunasPaises();

            foreach (var country in countries)
            {
                country1.Name = country.Name;
                country1.Alpha2Code = country.Alpha2Code;
                country1.Currencies = country.Currencies;
                country1.Flags = country.Flags;
                country1.RegionalBlocs = country.RegionalBlocs;
                country1.Population = country.Population;
                country1.Timezones = country.Timezones;
                country1.Capital = country.Capital;
                country1.Borders = country.Borders;
                country1.Languages = country.Languages;
            }
            countryInfo.Add(country1);

            foreach(var country in countryInfo)
            {
                dtgDados.Rows.Add(country.Name,country.Alpha2Code,country.Currencies[0].Name,country.RegionalBlocs[0].Name, country.Flags.Png);
            }
            dtgDados.AutoResizeColumns();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dtgDados.Rows.Clear();
            dtgDados.Columns.Clear();
            txtCountry.Text = string.Empty;
        }

        private void dtgDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 && e.ColumnIndex < 0)
                return;

            if (dtgDados.Columns[e.ColumnIndex].Index == dtgDados.Columns["nomePais"].Index)
            {                                
                LoadDetailsCountry();
            }
        }

        private void LoadDetailsCountry()
        {
            using (frmCountryDetails frmCountryDetails = new frmCountryDetails(countryInfo))
            {
                frmCountryDetails.ShowDialog();
            }
        }
    }
}
