

namespace AtividadePAM2
{
    public partial class MainPage : ContentPage
    {
        int ValorDado = 0;
        string guardar = null;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnRolar_Clicked(object sender, EventArgs e)
        {
            ValorDado = Convert.ToInt32((string)ValorP.SelectedItem);
            Random rnd = new Random();
            int Calcular = rnd.Next(1,ValorDado + 1);
            Valor.Text = Convert.ToString(Calcular);
            
        }
    }

}
