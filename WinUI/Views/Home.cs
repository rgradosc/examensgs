using ExamenSGS.WinUI.Services;
using ExamenSGS.WinUI.ViewModels;
using System;
using System.Windows.Forms;

namespace ExamenSGS.WinUI.Views
{
    public partial class HomeForm : Form
    {
        private readonly IService<YearViewModel> yearService;
        private readonly IService<AverageViewModel> averageService;

        public HomeForm()
        {
            InitializeComponent();

            yearService = new CalculateYearService();
            averageService = new CalculateAverageService();

            errorMessageYearLabel.Text = string.Empty;
            errorMessageStartLabel.Text = string.Empty;
            errorMessageEndLabel.Text = string.Empty;
        }

        private async void calculateYearButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(desireAgeText.Text))
            {
                errorMessageYearLabel.Text = "La edad es requerida.";
                return;
            }
            
            if (desireAgeText.Text == "0")
            {
                errorMessageYearLabel.Text = "La edad debe ser mayor a 0.";
                return;
            }

            errorMessageYearLabel.Text = string.Empty;

            var entidad = new YearViewModel
            {
                Birthdate = birthdateText.Value,
                QuantityYear = Convert.ToInt32(desireAgeText.Text),
            };

            calculateYearButton.Enabled = false;
            resultYearLabel.Text = "Procesando datos...";

            var result = await yearService.Request(entidad);
            result = result.Substring(1, result.Length - 2);
            
            calculateYearButton.Enabled = true;
            resultYearLabel.Text = string.Format("El resultado es: {0}", result);
        }

        private async void calculateAverageButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(startNumberText.Text))
            {
                errorMessageStartLabel.Text = "El Inicio es requerido.";
                return;
            }

            if (startNumberText.Text == "0")
            {
                errorMessageStartLabel.Text = "El Inicio debe ser mayor a 0.";
                return;
            }

            if (string.IsNullOrWhiteSpace(endNumberText.Text))
            {
                errorMessageEndLabel.Text = "El Fin es requerido.";
                return;
            }

            if (endNumberText.Text == "0")
            {
                errorMessageEndLabel.Text = "El Fin debe ser mayor a 0.";
                return;
            }

            errorMessageStartLabel.Text = string.Empty;
            errorMessageEndLabel.Text = string.Empty;

            var entidad = new AverageViewModel
            {
                End = Convert.ToInt32(endNumberText.Text),
                Start = Convert.ToInt32(startNumberText.Text),
            };

            calculateAverageButton.Enabled = false;
            resultAverageLabel.Text = "Procesando datos...";

            var result = await averageService.Request(entidad);

            calculateAverageButton.Enabled = true;
            resultAverageLabel.Text = $"El resultado es: {result}";
        }
    }
}
