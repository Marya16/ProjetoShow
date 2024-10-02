

namespace ProjetoShow;

public partial class MainPage : ContentPage
{
  public Gerenciador gerenciador;
	public MainPage()
	{
		InitializeComponent();
    gerenciador = new Gerenciador(labelPergunta, btnResp1, btnResp2, btnResp3, btnResp4, btnResp5, labelPontuacao, labelNivel);

	}

  private void OnBtnResposta01Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreta(1);
  }

  private void OnBtnResposta02Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreta(2);
  }

  private void OnBtnResposta03Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreta(3);
  }

  private void OnBtnResposta04Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreta(4);
  }

  private void OnBtnResposta05Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreta(5);
  }

  private async void Retira3(object sender, EventArgs e)
  {
    var ajuda = new RetiraErradas();
    ajuda.ConfiguraDesenho(btnResp1, btnResp2, btnResp3, btnResp4, btnResp5);
    ajuda.RealizaAjuda(gerenciador.QuestaoCorrente);
  }
}


