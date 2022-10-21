using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PedraPapelTesoura
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float VitoriasJogador = 0;
        float VitoriasBot = 0;
        public MainWindow()
        {
            InitializeComponent();

            float VitoriasJogador = 0;
            float VitoriasBot = 0;

            imgPedra.Visibility = Visibility.Hidden;
            imgPapel.Visibility = Visibility.Hidden;
            imgTesoura.Visibility = Visibility.Hidden;
            imgPedra_Copy.Visibility = Visibility.Hidden;
            imgPapel_Copy.Visibility = Visibility.Hidden;
            imgTesoura_Copy.Visibility = Visibility.Hidden;
        }

        private void escolhePapel(object sender, RoutedEventArgs e)
        {

            // botPapel = 0;
            // botTesoura = 1;
            // botPedra = 2;
            imgPedra.Visibility = Visibility.Hidden;
            imgPapel.Visibility = Visibility.Hidden;
            imgTesoura.Visibility = Visibility.Hidden;
            imgPapel.Visibility = Visibility.Visible;
            Random random = new Random();
            int escolhaDoBot = random.Next(0, 3);

            //------------------------------------------Se o Bot escolher Papel! ------------------------------------------

            for (int i; escolhaDoBot == 0; escolhaDoBot++)
            {
                imgPedra_Copy.Visibility = Visibility.Hidden;
                imgPapel_Copy.Visibility = Visibility.Hidden;
                imgTesoura_Copy.Visibility = Visibility.Hidden;
                imgPapel_Copy.Visibility = Visibility.Visible;
                txtVencedor.Text = "Empate!";
                break;
            }

            //------------------------------------------ Se o Bot escolher Tesoura! ------------------------------------------

            for (int i; escolhaDoBot == 1; escolhaDoBot++)
            {
                imgPedra_Copy.Visibility = Visibility.Hidden;
                imgPapel_Copy.Visibility = Visibility.Hidden;
                imgTesoura_Copy.Visibility = Visibility.Hidden;
                imgTesoura_Copy.Visibility = Visibility.Visible;
                txtVencedor.Text = "O vencedor é o Bot!";
                VitoriasBot++;
                AumentaVitoriasBot();
                break;
            }

            //------------------------------------------ Se o Bot escolher Pedra! ------------------------------------------

            for (int i; escolhaDoBot == 2; escolhaDoBot++)
            {
                imgPedra_Copy.Visibility = Visibility.Hidden;
                imgPapel_Copy.Visibility = Visibility.Hidden;
                imgTesoura_Copy.Visibility = Visibility.Hidden;
                imgPedra_Copy.Visibility = Visibility.Visible;
                txtVencedor.Text = "O vencedor é o Jogador!";
                VitoriasJogador++;
                AumentaVitoriasJogador();
                break;
            }
        }
        private void escolhePedra(object sender, RoutedEventArgs e)
        {
            // botPapel = 0;
            // botTesoura = 1;
            // botPedra = 2;
            imgPedra.Visibility = Visibility.Hidden;
            imgPapel.Visibility = Visibility.Hidden;
            imgTesoura.Visibility = Visibility.Hidden;
            imgPedra.Visibility = Visibility.Visible;
            Random random = new Random();
            int escolhaDoBot = random.Next(0, 3);

            //------------------------------------------Se o Bot escolher Papel! ------------------------------------------

            for (int i; escolhaDoBot == 0; escolhaDoBot++)
            {
                imgPedra_Copy.Visibility = Visibility.Hidden;
                imgPapel_Copy.Visibility = Visibility.Hidden;
                imgTesoura_Copy.Visibility = Visibility.Hidden;
                imgPapel_Copy.Visibility = Visibility.Visible;
                txtVencedor.Text = "O vencedor é o Bot!";
                VitoriasBot++;
                AumentaVitoriasBot();
                break;
            }

            //------------------------------------------ Se o Bot escolher Tesoura! ------------------------------------------

            for (int i; escolhaDoBot == 1; escolhaDoBot++)
            {
                imgPedra_Copy.Visibility = Visibility.Hidden;
                imgPapel_Copy.Visibility = Visibility.Hidden;
                imgTesoura_Copy.Visibility = Visibility.Hidden;
                imgTesoura_Copy.Visibility = Visibility.Visible;
                txtVencedor.Text = "O vencedor é o Jogador!";
                VitoriasJogador++;
                AumentaVitoriasJogador();
                break;
            }


            //------------------------------------------ Se o Bot escolher Pedra! ------------------------------------------

            for (int i; escolhaDoBot == 2; escolhaDoBot++)
            {
                imgPedra_Copy.Visibility = Visibility.Hidden;
                imgPapel_Copy.Visibility = Visibility.Hidden;
                imgTesoura_Copy.Visibility = Visibility.Hidden;
                imgPedra_Copy.Visibility = Visibility.Visible;
                txtVencedor.Text = "Empate!";
                break;
            }
        }

        private void escolheTesoura(object sender, RoutedEventArgs e)
        {
            // botPapel = 0;
            // botTesoura = 1;
            // botPedra = 2;
            imgPedra.Visibility = Visibility.Hidden;
            imgPapel.Visibility = Visibility.Hidden;
            imgTesoura.Visibility = Visibility.Hidden;
            imgTesoura.Visibility = Visibility.Visible;
            Random random = new Random();
            int escolhaDoBot = random.Next(0, 3);

            //------------------------------------------Se o Bot escolher Papel! ------------------------------------------

            for (int i; escolhaDoBot == 0; escolhaDoBot++)
            {
                imgPedra_Copy.Visibility = Visibility.Hidden;
                imgPapel_Copy.Visibility = Visibility.Hidden;
                imgTesoura_Copy.Visibility = Visibility.Hidden;
                imgPapel_Copy.Visibility = Visibility.Visible;
                txtVencedor.Text = "O vencedor é o Jogador!";
                VitoriasJogador++;
                AumentaVitoriasJogador();
                break;
            }

            //------------------------------------------ Se o Bot escolher Tesoura! ------------------------------------------

            for (int i; escolhaDoBot == 1; escolhaDoBot++)
            {
                imgPedra_Copy.Visibility = Visibility.Hidden;
                imgPapel_Copy.Visibility = Visibility.Hidden;
                imgTesoura_Copy.Visibility = Visibility.Hidden;
                imgTesoura_Copy.Visibility = Visibility.Visible;
                txtVencedor.Text = "Empate!";
                break;
            }

            //------------------------------------------ Se o Bot escolher Pedra! ------------------------------------------

            for (int i; escolhaDoBot == 2; escolhaDoBot++)
            {
                imgPedra_Copy.Visibility = Visibility.Hidden;
                imgPapel_Copy.Visibility = Visibility.Hidden;
                imgTesoura_Copy.Visibility = Visibility.Hidden;
                imgPedra_Copy.Visibility = Visibility.Visible;
                txtVencedor.Text = "O vencedor é o Bot!";
                VitoriasBot++;
                AumentaVitoriasBot();
                break;
            }
        }

        private void AumentaVitoriasJogador()
        {
            txtVitoriasJogador.Text = $"{(VitoriasJogador)}";
        }
        private void AumentaVitoriasBot()
        {
            txtVitoriasBot.Text = $"{(VitoriasBot)}";
        }

    }
}

