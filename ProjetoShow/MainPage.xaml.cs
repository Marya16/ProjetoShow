
namespace ProjetoShow;

    public partial class MainPage : ContentPage
   {
        Gerenciador gerenciador;
        public MainPage()
        {
        gerenciador = new Gerenciador(labelPergunta, btn1, btn2, btn3 , btn4, btn5);
        }
        void OnOnBt1Clicked (object sender, EventArgs args)
        {
          gerenciador.VerificaResposta(1);
        }
         void OnOnBt2Clicked (object sender, EventArgs args)
        {
          gerenciador.VerificaResposta(2);
        }
         void OnOnBt3Clicked (object sender, EventArgs args)
        {
          gerenciador.VerificaResposta(3);
        }
         void OnOnBt4Clicked (object sender, EventArgs args)
        {
          gerenciador.VerificaResposta(4);
        }
         void OnOnBt5Clicked (object sender, EventArgs args)
        {
          gerenciador.VerificaResposta(5);
        }

   }

