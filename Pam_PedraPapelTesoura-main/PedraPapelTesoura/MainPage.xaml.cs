namespace PedraPapelTesoura
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Calcular = rnd.Next(1,3 + 1);
            string pedra = "pedra";
            string papel = "papel";
            string tesoura = "tesoura";
            int count = 0;
            string escolhaPlayer = Convert.ToString(escolha.SelectedItem);
            string jogador1 = player.Text;


            if(escolhaPlayer == "Pedra")
            {
                imgPlayer.Source = "pedraE.png";
            }
            if (escolhaPlayer == "Papel")
            {
                imgPlayer.Source = "papelE.png";
                imgPlayer.WidthRequest = 200;
                imgPlayer.Margin = 30;
            }
            if (escolhaPlayer == "Tesoura")
            {
                imgPlayer.Source = "TesouraE.png";
            }
            if (Calcular == 1)
            {
                resultadoBot.Text = pedra;
                imgBot.Source = "pedraD.png";
                imgBot.WidthRequest = 300;
                imgBot.Margin = 0;

            }
            if (Calcular == 2)
            {
                resultadoBot.Text = papel;
                imgBot.Source = "papelD.png";
                imgBot.WidthRequest = 200;
                imgBot.Margin = 50;
            }
            if (Calcular == 3)
            {
                resultadoBot.Text = tesoura;
                imgBot.Source = "tesouraD.png";
                imgBot.WidthRequest = 300;
                imgBot.Margin = 0;
            }
            if (escolhaPlayer == "Pedra") 
            {
                resultadoPlayer.Text = pedra;
                imgPlayer.Source = "pedraD.png";
                imgPlayer.WidthRequest = 300;
                imgPlayer.Margin = 0;
            }
            if (escolhaPlayer == "Papel")
            {
                resultadoPlayer.Text =  papel;
                imgPlayer.Source = "papelE.png";
                imgPlayer.WidthRequest = 200;
                imgPlayer.Margin = 50;
            }
            if (escolhaPlayer == "Tesoura")
            {
                resultadoPlayer.Text = tesoura;
                imgPlayer.Source = "TesouraE.png";
                imgPlayer.WidthRequest = 300;
                imgPlayer.Margin = 0;
            }
            if (resultadoPlayer.Text == pedra && resultadoBot.Text == papel)
            {
                Resultado.Text = $"Derrota do {jogador1}";
                count = 1;
            }
            if( resultadoPlayer.Text == tesoura && resultadoBot.Text == pedra)
            {
                Resultado.Text = $"Derrota do {jogador1}";
                count = 1;
            }
            if (resultadoPlayer.Text == papel && resultadoBot.Text == tesoura) 
            {
                Resultado.Text =  $"Derrota do {jogador1}";
                count = 1;
            }
            else if (resultadoBot.Text == resultadoPlayer.Text)
            {
                Resultado.Text = "empate";
                count = 1;
            }
            else if( count == 0)
            {
                Resultado.Text = $"vitoria do {jogador1}";
            }
        }
    }
    }


