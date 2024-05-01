using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityPopulationApp
{
    public partial class Form1 : Form
    {
        private List<City> cities;

        public Form1()
        {
            InitializeComponent();
        }


        private void UpdateCityList()
        {
            var filteredCities = cities;

            if (!String.IsNullOrEmpty(textBoxFilterName.Text))
            {
                filteredCities = filteredCities.Where(c => c.Name.StartsWith(textBoxFilterName.Text)).ToList();
            }

            if (numericUpDownFilterPopulation.Value > 0)
            {
                filteredCities = filteredCities.Where(c => c.Population >= numericUpDownFilterPopulation.Value).ToList();
            }

            listBoxCities.DataSource = null;
            listBoxCities.DataSource = filteredCities;
            labelTotalCities.Text = $"Всього міст: {filteredCities.Count}";
        }
        private void buttonAddCity_Click(object sender, EventArgs e)
        {

            cities.Add(new City(textBox1.Text, (int)numericUpDown1.Value));
            UpdateCityList();
        }

        private void listBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Додайте код для обробки вибраного елемента списку
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cities = new List<City>()
            {
                new City("Київ", 2967000),
                new City("Львів", 732341),
                new City("Одеса", 1017000),
                new City("Дніпро", 980769),
                new City("Запоріжжя", 732323)
            };

            UpdateCityList();
        }

        private void textBoxFilterName_TextChanged_1(object sender, EventArgs e)
        {
            UpdateCityList();
        }

        private void numericUpDownFilterPopulation_ValueChanged_1(object sender, EventArgs e)
        {
            UpdateCityList();
        }
    }

    public class City
    {
        public string Name { get; set; }
        public int Population { get; set; }

        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }

        public override string ToString()
        {
            return Name + " - " + Population;
        }
    }
}
