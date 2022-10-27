using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
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

namespace palavra_cruzada
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Palavra1 = "";
        string Palavra2 = "";
        string Palavra3 = "";
        string Palavra4 = "";
        string Palavra5 = "";
        string Palavra6 = "";
        string Palavra7 = "";
        string Palavra8 = "";
        string Palavra9 = "";
        string Palavra10 = "";
        int contadorDeAcertos = 0;

        public MainWindow()
        {
            InitializeComponent();
            msgDeVitoria.Visibility = Visibility.Hidden;
            img_1.Visibility = Visibility.Hidden;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Animal Que faz de tudo Voa, nada e anda!", "Dica 1", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Melhor projeto integrador que o senai já viu!", "Dica 2", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Em pleno 2022, ano da ... , você conhece o Elon Musk? ", "Dica 3", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Os professores possuem mais que os alunos. Estamos sempre precisando dele para além de passar de ano ganhar mais conhecimento.", "Dica 4", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("È o processo de aquisição de conhecimento!", "Dica 5", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Melhor professor do mundo, um pouco bravo mais está sempre ajudando a gente. Aliás cabeças rolarão.", "Dica 6", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("É utilizado para criar o melhor projeto integrador do mundo!", "Dica 7", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Instituição que ajuda milhares de jovens à entrarem no mercado de trabalho além de profissionalizar estes jovens.", "Dica 8", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("O Educk é desenvolvido para esta plataforma!", "Dica 9", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click10(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Algo almejado por todos, o Educk é a definição desta palavra.", "Dica 10", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Verificar1(object sender, KeyEventArgs e)
        {
            // VERIFICA 1

            Palavra1 = letra_P.Text + letra_A.Text + letra_T.Text + letra_O.Text;
            Palavra1 = Palavra1.ToUpper();

           
            
            // VERIFICA 2
            
            Palavra2 = letra_E2.Text + letra_D2.Text + letra_U2.Text + letra_C3.Text + letra_K.Text;
            Palavra2 = Palavra2.ToUpper();

            

            // VERIFICA 3

            Palavra3 = letra_T1.Text + letra_E1.Text + letra_C2.Text + letra_N1.Text + letra_O3.Text + letra_L3.Text + letra_O4.Text + letra_G.Text + letra_I1.Text + letra_A2.Text;
            Palavra3 = Palavra3.ToUpper();

           
            // VERIFICA 4

            Palavra4 = letra_E4.Text + letra_S3.Text + letra_T2.Text + letra_U3.Text + letra_D3.Text + letra_O.Text;
            Palavra4 = Palavra4.ToUpper();

           

            // VERIFICA 5

            Palavra5 = letra_A3.Text + letra_P1.Text + letra_R3.Text + letra_E2.Text + letra_N2.Text + letra_D1.Text + letra_I2.Text + letra_Z.Text + letra_A2.Text + letra_G1.Text + letra_E3.Text + letra_M1.Text;
            Palavra5 = Palavra5.ToUpper();

           

            // VERIFICA 6

            Palavra6 = letra_R2.Text + letra_O1.Text + letra_D.Text + letra_O2.Text + letra_L2.Text + letra_F.Text + letra_O3.Text;
            Palavra6 = Palavra6.ToUpper();

          

            // VERIFICA 7

            Palavra7 = letra_X.Text + letra_A.Text + letra_M.Text + letra_A.Text + letra_R.Text + letra_I.Text + letra_N.Text;
            Palavra7 = Palavra7.ToUpper();

           

            // VERIFICA 8

            Palavra8 = letra_S4.Text + letra_E3.Text + letra_N3.Text + letra_A4.Text + letra_I3.Text;
            Palavra8 = Palavra8.ToUpper();

           

            // VERIFICA 9

            Palavra9 = letra_C.Text + letra_E.Text + letra_L.Text + letra_U.Text + letra_L1.Text + letra_A1.Text + letra_R1.Text;
            Palavra9 = Palavra9.ToUpper();

          

            // VERIFICA 10

            Palavra10 = letra_S.Text + letra_U1.Text + letra_C1.Text + letra_E.Text + letra_S1.Text + letra_S2.Text + letra_O1.Text;


            Palavra10 = Palavra10.ToUpper();

            VerificarPalavra1();
            VerificarPalavra2();
            VerificarPalavra3();
            VerificarPalavra4();
            VerificarPalavra5();
            VerificarPalavra6();
            VerificarPalavra7();
            VerificarPalavra8();
            VerificarPalavra9();
            VerificarPalavra10();

            verificartodos();
        }
        
        private void VerificarPalavra1()
        {

            if (Palavra1.Contains("PATO"))
            {
                if (letra_P.Background != Brushes.Purple)
                {
                    letra_P.Background = Brushes.Purple;
                    letra_A.Background = Brushes.Purple;
                    letra_T.Background = Brushes.Purple;
                    letra_O.Background = Brushes.Purple;

                    letra_P.IsHitTestVisible = false;
                    letra_A.IsHitTestVisible = false;
                    letra_T.IsHitTestVisible = false;
                    letra_O.IsHitTestVisible = false;

                    letra_P.Focusable = false;
                    letra_A.Focusable = false;
                    letra_T.Focusable = false;
                    letra_O.Focusable = false;

                    contadorDeAcertos++;
                }
                else
                {
                    Palavra1 = "PATO";
                }

                
            }
          

        }
        private void VerificarPalavra2()
        {
            if (Palavra2.Contains("EDUCK"))
            {
                if (letra_D2.Background != Brushes.Purple)
                {
                    letra_E2.Background = Brushes.Purple;
                    letra_D2.Background = Brushes.Purple;
                    letra_U2.Background = Brushes.Purple;
                    letra_C3.Background = Brushes.Purple;
                    letra_K.Background = Brushes.Purple;

                    letra_E2.IsHitTestVisible = false;
                    letra_D2.IsHitTestVisible = false;
                    letra_U2.IsHitTestVisible = false;
                    letra_C3.IsHitTestVisible = false;
                    letra_K.IsHitTestVisible = false;

                    letra_E2.Focusable = false;
                    letra_D2.Focusable = false;
                    letra_U2.Focusable = false;
                    letra_C3.Focusable = false;
                    letra_K.Focusable = false;

                    contadorDeAcertos++;
                }
                else
                {
                    Palavra2 = "EDUCK";
                }
            }
        }

        private void VerificarPalavra3()
        {
            if (Palavra3.Contains("TECNOLOGIA"))
            {
                if (letra_E1.Background != Brushes.Purple)
                {
                    letra_T1.Background = Brushes.Purple;
                    letra_E1.Background = Brushes.Purple;
                    letra_C2.Background = Brushes.Purple;
                    letra_N1.Background = Brushes.Purple;
                    letra_O3.Background = Brushes.Purple;
                    letra_L3.Background = Brushes.Purple;
                    letra_O4.Background = Brushes.Purple;
                    letra_G.Background = Brushes.Purple;
                    letra_I1.Background = Brushes.Purple;
                    letra_A2.Background = Brushes.Purple;

                    letra_T1.IsHitTestVisible = false;
                    letra_E1.IsHitTestVisible = false;
                    letra_C2.IsHitTestVisible = false;
                    letra_N1.IsHitTestVisible = false;
                    letra_O3.IsHitTestVisible = false;
                    letra_L3.IsHitTestVisible = false;
                    letra_O4.IsHitTestVisible = false;
                    letra_G.IsHitTestVisible = false;
                    letra_I1.IsHitTestVisible = false; 
                    letra_A2.IsHitTestVisible = false;

                    letra_T1.Focusable = false;
                    letra_E1.Focusable = false;
                    letra_C2.Focusable = false;
                    letra_N1.Focusable = false;
                    letra_O3.Focusable = false;
                    letra_L3.Focusable = false;
                    letra_O4.Focusable = false;
                    letra_G.Focusable = false;
                    letra_I1.Focusable = false;
                    letra_A2.Focusable = false;

                    contadorDeAcertos++;
                }
                else
                {
                    Palavra3 = "TECNOLOGIA";
                }
               
            }

        }

        private void VerificarPalavra4()
        {

            if (Palavra4.Contains("ESTUDO"))
            {
                if (letra_S3.Background != Brushes.Purple)
                {
                    letra_E4.Background = Brushes.Purple;
                    letra_S3.Background = Brushes.Purple;
                    letra_T2.Background = Brushes.Purple;
                    letra_U3.Background = Brushes.Purple;
                    letra_D3.Background = Brushes.Purple;
                    letra_O.Background = Brushes.Purple;

                    letra_E4.IsHitTestVisible = false;
                    letra_S3.IsHitTestVisible = false;
                    letra_T2.IsHitTestVisible = false;
                    letra_U3.IsHitTestVisible = false;
                    letra_D3.IsHitTestVisible = false;
                    letra_O.IsHitTestVisible = false;

                    letra_E4.Focusable = false;
                    letra_S3.Focusable = false;
                    letra_T2.Focusable = false;
                    letra_U3.Focusable = false;
                    letra_D3.Focusable = false;
                    letra_O.Focusable = false;

                    contadorDeAcertos++;
                }
                else
                {
                    Palavra4 = "ESTUDO";
                }
                
            }
        }
        private void VerificarPalavra5()
        {
            if (Palavra5.Contains("APRENDIZAGEM"))
            {
                if (letra_A3.Background != Brushes.Purple)
                {
                    letra_A3.Background = Brushes.Purple;
                    letra_P1.Background = Brushes.Purple;
                    letra_R3.Background = Brushes.Purple;
                    letra_E2.Background = Brushes.Purple;
                    letra_N2.Background = Brushes.Purple;
                    letra_D1.Background = Brushes.Purple;
                    letra_I2.Background = Brushes.Purple;
                    letra_Z.Background = Brushes.Purple;
                    letra_A2.Background = Brushes.Purple;
                    letra_G1.Background = Brushes.Purple;
                    letra_E3.Background = Brushes.Purple;
                    letra_M1.Background = Brushes.Purple;

                    letra_A3.IsHitTestVisible = false;
                    letra_P1.IsHitTestVisible = false;
                    letra_R3.IsHitTestVisible = false;
                    letra_E2.IsHitTestVisible = false;
                    letra_N2.IsHitTestVisible = false;
                    letra_D1.IsHitTestVisible = false;
                    letra_I2.IsHitTestVisible = false;
                    letra_Z.IsHitTestVisible = false;
                    letra_A2.IsHitTestVisible = false;
                    letra_G1.IsHitTestVisible = false;
                    letra_E3.IsHitTestVisible = false;
                    letra_M1.IsHitTestVisible = false;

                    letra_A3.Focusable = false;
                    letra_P1.Focusable = false;
                    letra_R3.Focusable = false;
                    letra_E2.Focusable = false;
                    letra_N2.Focusable = false;
                    letra_D1.Focusable = false;
                    letra_I2.Focusable = false;
                    letra_Z.Focusable = false;
                    letra_A2.Focusable = false;
                    letra_G1.Focusable = false;
                    letra_E3.Focusable = false;
                    letra_M1.Focusable = false;

                    contadorDeAcertos++;
                }
                else
                {
                    Palavra5 = "APRENDIZAGEM";
                }
               
            }

        }

        private void VerificarPalavra6()
        {
            
            if (Palavra6.Contains("RODOLFO"))
            {
                if (letra_R2.Background != Brushes.Purple)
                {
                    letra_R2.Background = Brushes.Purple;
                    letra_O1.Background = Brushes.Purple;
                    letra_D.Background = Brushes.Purple;
                    letra_O2.Background = Brushes.Purple;
                    letra_L2.Background = Brushes.Purple;
                    letra_F.Background = Brushes.Purple;
                    letra_O3.Background = Brushes.Purple;

                    letra_R2.IsHitTestVisible = false;
                    letra_O1.IsHitTestVisible = false;
                    letra_D.IsHitTestVisible = false;
                    letra_O2.IsHitTestVisible = false;
                    letra_L2.IsHitTestVisible = false;
                    letra_F.IsHitTestVisible = false;
                    letra_O3.IsHitTestVisible = false;

                    letra_R2.Focusable = false;
                    letra_O1.Focusable = false;
                    letra_D.Focusable = false;
                    letra_O2.Focusable = false;
                    letra_L2.Focusable = false;
                    letra_F.Focusable = false;
                    letra_O3.Focusable = false;

                    contadorDeAcertos++;
                }
                else
                {
                    Palavra6 = "RODOLFO";
                }

               
            }
        }

        private void VerificarPalavra7()
        {

            if (Palavra7.Contains("XAMARIN"))
            {
                if (letra_X.Background != Brushes.Purple)
                {
                    letra_X.Background = Brushes.Purple;
                    letra_A.Background = Brushes.Purple;
                    letra_M.Background = Brushes.Purple;
                    letra_A1.Background = Brushes.Purple;
                    letra_R.Background = Brushes.Purple;
                    letra_I.Background = Brushes.Purple;
                    letra_N.Background = Brushes.Purple;

                    letra_X.IsHitTestVisible = false;
                    letra_A.IsHitTestVisible = false;
                    letra_M.IsHitTestVisible = false;
                    letra_A1.IsHitTestVisible = false;
                    letra_R.IsHitTestVisible = false;
                    letra_I.IsHitTestVisible = false;
                    letra_N.IsHitTestVisible = false;

                    letra_X.Focusable = false;
                    letra_A.Focusable = false;
                    letra_M.Focusable = false;
                    letra_A1.Focusable = false;
                    letra_R.Focusable = false;
                    letra_I.Focusable = false;
                    letra_N.Focusable = false;

                    contadorDeAcertos++;
                }
                else
                {
                    Palavra7 = "XAMARIN";
                }
                
            }
        }
        private void VerificarPalavra8()
        {

            if (Palavra8.Contains("SENAI"))
            {
                if (letra_S4.Background != Brushes.Purple)
                {
                    letra_S4.Background = Brushes.Purple;
                    letra_E3.Background = Brushes.Purple;
                    letra_N3.Background = Brushes.Purple;
                    letra_A4.Background = Brushes.Purple;
                    letra_I3.Background = Brushes.Purple;

                    letra_S4.IsHitTestVisible = false;
                    letra_E3.IsHitTestVisible = false;
                    letra_N3.IsHitTestVisible = false;
                    letra_A4.IsHitTestVisible = false;
                    letra_I3.IsHitTestVisible = false;

                    letra_S4.Focusable = false;
                    letra_E3.Focusable = false;
                    letra_N3.Focusable = false;
                    letra_A4.Focusable = false;
                    letra_I3.Focusable = false;

                    contadorDeAcertos++;

                }
                else
                {
                    Palavra8 = "SENAI";
                }
               
            }
        }
        private void VerificarPalavra9()
        {

            if (Palavra9.Contains("CELULAR"))
            {
                if (letra_C.Background != Brushes.Purple)
                {
                    letra_C.Background = Brushes.Purple;
                    letra_E.Background = Brushes.Purple;
                    letra_L.Background = Brushes.Purple;
                    letra_U.Background = Brushes.Purple;
                    letra_L1.Background = Brushes.Purple;
                    letra_A1.Background = Brushes.Purple;
                    letra_R1.Background = Brushes.Purple;

                    letra_C.IsHitTestVisible = false;
                    letra_E.IsHitTestVisible = false;
                    letra_L.IsHitTestVisible = false;
                    letra_U.IsHitTestVisible = false;
                    letra_L1.IsHitTestVisible = false;
                    letra_A1.IsHitTestVisible = false;
                    letra_R1.IsHitTestVisible = false;

                    letra_C.Focusable = false;
                    letra_E.Focusable = false;
                    letra_L.Focusable = false;
                    letra_U.Focusable = false;
                    letra_L1.Focusable = false;
                    letra_A1.Focusable = false;
                    letra_R1.Focusable = false;

                    contadorDeAcertos++;

                }
                else
                {
                    Palavra9 = "CELULAR";
                }
                
            }
        }

        private void VerificarPalavra10()
        {
            if (Palavra10.Contains("SUCESSO"))
            {
                if (letra_S.Background != Brushes.Purple)
                {
                    letra_S.Background = Brushes.Purple;
                    letra_U1.Background = Brushes.Purple;
                    letra_C1.Background = Brushes.Purple;
                    letra_E.Background = Brushes.Purple;
                    letra_S1.Background = Brushes.Purple;
                    letra_S2.Background = Brushes.Purple;
                    letra_O1.Background = Brushes.Purple;

                    letra_S.IsHitTestVisible = false;
                    letra_U1.IsHitTestVisible = false;
                    letra_C1.IsHitTestVisible = false;
                    letra_E.IsHitTestVisible = false;
                    letra_S1.IsHitTestVisible = false;
                    letra_S2.IsHitTestVisible = false;
                    letra_O1.IsHitTestVisible = false;

                    letra_S.Focusable = false;
                    letra_U1.Focusable = false;
                    letra_C1.Focusable = false;
                    letra_E.Focusable = false;
                    letra_S1.Focusable = false;
                    letra_S2.Focusable = false;
                    letra_O1.Focusable = false;

                    contadorDeAcertos++;

                }
                else
                {
                    Palavra10 = "SUCESSO";
                }
                
      
            }

        }

        private void verificartodos()
        {
            if (contadorDeAcertos == 10)
            {
                img_1.Visibility = Visibility.Visible;
                msgDeVitoria.Visibility = Visibility.Visible;

                
            }
            
        }

        private void img1_click(object sender, MouseButtonEventArgs e)
        {
            Stream audio = Properties.Resources.SomPato;
            SoundPlayer player = new SoundPlayer(audio);
            player.Play();
        }
    }
}
