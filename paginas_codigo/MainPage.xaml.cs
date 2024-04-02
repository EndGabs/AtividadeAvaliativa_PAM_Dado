using System.Security.Cryptography.X509Certificates;

namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonRolar_Clicked(object sender, EventArgs e)
        {
            int opcao = Convert.ToInt32(PickerDado.SelectedItem)+1;
            Random random = new();
            NumeroSortido.Text = Convert.ToString(random.Next(1, opcao));
        }
    }

}
