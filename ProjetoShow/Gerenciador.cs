namespace ProjetoShow;
public class Gerenciador
{
    List<Questao>ListaQuestoes= new List<Questao>();
    List<int>ListaQuestoesRespondidas= new List<int>();
    Label labelPontuacao;
    Label labelNivel;
    Questao QuestaoCorrente;
    public Gerenciador( Label labelPerg, Button btnResp1, Button btnResp2, Button btnResp3, Button btnResp4, Button btnResp5, Label labelPontuacao, Label labelNivel)
    {
        CriaPerguntas(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        labelPontuacao = labelPontuacao;
        labelNivel = labelNivel;
    }
    void CriaPerguntas(Label labelPerg, Button btnResp1, Button btnResp2, Button btnResp3, Button btnResp4, Button btnResp5)
    {
        var Q1 = new Questao();
        Q1.NivelPergunta= 1;
        Q1.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q1.Pergunta = "Qual a cor do céu?";
        Q1.Resposta1 = "Vermelho";
        Q1.Resposta2 = "Laranja";
        Q1.Resposta3 = "Verde";
        Q1.Resposta4 = "Azul";
        Q1.Resposta5 = "Preto";
        Q1.RespostaCorreta = 4;
        ListaQuestoes.Add(Q1);

        var Q2 = new Questao();
        Q1.NivelPergunta= 1;
        Q2.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q2.Pergunta = "Qual a cor da laranja?";
        Q2.Resposta1 = "Preto";
        Q2.Resposta2 = "Verde";
        Q2.Resposta3 = "Laranja";
        Q2.Resposta4 = "Azul";
        Q2.Resposta5 = "Vermelho";
        Q2.RespostaCorreta = 3;
        ListaQuestoes.Add(Q2);
        ProximaQuestao();
    }
   
    void ProximaQuestao()
    {
        var numAleat = Random.Shared.Next(0, ListaQuestoes.Count);
        while (ListaQuestoesRespondidas.Contains(numAleat))
            numAleat=Random.Shared.Next(0, ListaQuestoes.Count);
        ListaQuestoesRespondidas.Add(numAleat);
        QuestaoCorrente = ListaQuestoes[numAleat];
        QuestaoCorrente.Desenha();
    }

  public int Pontuacao {get; private set;} 
  int NivelAtual = 0;
  private object listaQuestoesRespondidas;

    void Inicializar() 
  {
    Pontuacao = 0;
    NivelAtual = 1;
    ProximaQuestao();
  }  

  public async void VerificaCorreta(int RespostaRespondida)
  {
    if (QuestaoCorrente.VerificarResposta(RespostaRespondida))
    {
        await Task.Delay(1000);
        AdicionaPontuacao(NivelAtual);
        NivelAtual++;
        ProximaQuestao();
        LabelPontuacao.Text= "Pontuacao: R$" + Pontuacao.ToString();
        LabelNivel.Text= "Nivel:" + NivelAtual.ToString();
    }
    else
    {
        await App.Current.MainPage.DisplayAlert("Fim","Você Errou","Ok");
        Inicializar();
    }
  }
  void AdicionaPontuacao(int n)
  {
    if(n==1)
     Pontuacao = 1000;
    else if (n==2)
     Pontuacao = 2000;
    else if (n==3) 
     Pontuacao = 5000;
    else if (n==4)
     Pontuacao = 10000;
    else if (n==5)
     Pontuacao = 20000;
    else if (n==6)
     Pontuacao = 50000;
    else if (n==7)
     Pontuacao = 100000;
    else if (n==8)
     Pontuacao = 200000;
    else if (n==9)
     Pontuacao = 500000;
    else 
     Pontuacao = 1000000;     
  }
}