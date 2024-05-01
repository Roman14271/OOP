using System.Windows.Forms;

namespace ПР13_в1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Перевірка імені
            string name = textBoxName.Text;
            if (name.Length < 1 || name.Length > 20)
            {
                MessageBox.Show("Ім'я має бути від 1 до 20 символів");
                return;
            }

            // Перевірка прізвища
            string surname = textBoxSurname.Text;
            if (surname.Length < 1 || surname.Length > 20)
            {
                MessageBox.Show("Прізвище має бути від 1 до 20 символів");
                return;
            }

            // Перевірка дати народження
            try
            {
                DateTime birthDate = DateTime.Parse(textBoxBirthDate.Text);
                if (birthDate.Year < 1930 || birthDate.Year > 2020)
                {
                    MessageBox.Show("Дата народження має бути від 1930 до 2020 року");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Неправильний формат дати народження");
                return;
            }

            // Успішна валідація
            MessageBox.Show("Всі дані введені правильно!");
        }
    }
}
