
namespace ProjetoShow;

    public partial class MainPage : ContentPage
   {
        Gerenciador gerenciador;
        public MainPage()
        {
        gerenciador = new Gerenciador(labelPerg, btnResp1, btnResp2, btnResp3, btnRespo4, btnResp5);
        }
        void OnOnBt1Clicked (object sender, EventArgs args)
        {
          gerenciador.VerificarResposta(1);
        }
         void OnOnBt2Clicked (object sender, EventArgs args)
        {
          gerenciador.VerificarResposta(2);
        }
         void OnOnBt3Clicked (object sender, EventArgs args)
        {
          gerenciador.VerificarResposta(3);
        }
         void OnOnBt4Clicked (object sender, EventArgs args)
        {
          gerenciador.VerificarResposta(4);
        }
         void OnOnBt5Clicked (object sender, EventArgs args)
        {
          gerenciador.VerificarResposta(5);
        }

   }

