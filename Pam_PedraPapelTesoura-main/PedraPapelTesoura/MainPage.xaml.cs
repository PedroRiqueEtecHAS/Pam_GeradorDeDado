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


            if (Calcular == 1)
            {
                resultadoBot.Text = pedra;
            }
            if (Calcular == 2)
            {
                resultadoBot.Text = papel;
            }
            if (Calcular == 3)
            {
                resultadoBot.Text = tesoura;
            }
            if (escolhaPlayer == "Pedra") 
            {
                resultadoPlayer.Text = pedra;
            }
            if (escolhaPlayer == "Papel")
            {
                resultadoPlayer.Text =  papel;
            }
            if (escolhaPlayer == "Tesoura")
            {
                resultadoPlayer.Text = tesoura;
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


