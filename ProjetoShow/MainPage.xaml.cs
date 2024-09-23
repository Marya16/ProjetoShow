

namespace ProjetoShow;

public partial class MainPage : ContentPage
{
  Gerenciador gerenciador;
	public MainPage()
	{
		InitializeComponent();
    gerenciador = new Gerenciador(labelPergunta, btnResp1, btnResp2, btnResp3, btnResp4, btnResp5);

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
}


