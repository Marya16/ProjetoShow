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
        this.labelPontuacao = labelPontuacao;
        this.labelNivel = labelNivel;
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
        Q2.NivelPergunta = 1;
        Q2.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q2.Pergunta = "Quantos segundos tem um minuto?";
        Q2.Resposta1 = "30";
        Q2.Resposta2 = "45";
        Q2.Resposta3 = "60";
        Q2.Resposta4 = "90";
        Q2.Resposta5 = "120";
        Q2.RespostaCorreta = 3;
        ListaQuestoes.Add(Q2);

        var Q3 = new Questao();
        Q3.NivelPergunta = 1;
        Q3.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q3.Pergunta = "Qual é a capital do Brasil?";
        Q3.Resposta1 = "São Paulo";
        Q3.Resposta2 = "Brasília";
        Q3.Resposta3 = "Rio de Janeiro";
        Q3.Resposta4 = "Salvador";
        Q3.Resposta5 = "Belo Horizonte";
        Q3.RespostaCorreta = 2;
        ListaQuestoes.Add(Q3);

        var Q4 = new Questao();
        Q4.NivelPergunta = 1;
        Q4.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q4.Pergunta = "Qual é o maior planeta do Sistema Solar?";
        Q4.Resposta1 = "Terra";
        Q4.Resposta2 = "Marte";
        Q4.Resposta3 = "Júpiter";
        Q4.Resposta4 = "Saturno";
        Q4.Resposta5 = "Urano";
        Q4.RespostaCorreta = 3;
        ListaQuestoes.Add(Q4);

        var Q5 = new Questao();
        Q5.NivelPergunta = 1;
        Q5.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q5.Pergunta = "Qual é a cor da laranja?";
        Q5.Resposta1 = "Preto";
        Q5.Resposta2 = "Verde";
        Q5.Resposta3 = "Laranja";
        Q5.Resposta4 = "Azul";
        Q5.Resposta5 = "Vermelho";
        Q5.RespostaCorreta = 3;
        ListaQuestoes.Add(Q5);

        var Q6 = new Questao();
        Q6.NivelPergunta = 1;
        Q6.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q6.Pergunta = "Quantos dias há em um ano bissexto?";
        Q6.Resposta1 = "365";
        Q6.Resposta2 = "366";
        Q6.Resposta3 = "360";
        Q6.Resposta4 = "364";
        Q6.Resposta5 = "362";
        Q6.RespostaCorreta = 2;
        ListaQuestoes.Add(Q6);

        var Q7 = new Questao();
        Q7.NivelPergunta = 1;
        Q7.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q7.Pergunta = "Quem pintou a Mona Lisa?";
        Q7.Resposta1 = "Vincent van Gogh";
        Q7.Resposta2 = "Leonardo da Vinci";
        Q7.Resposta3 = "Pablo Picasso";
        Q7.Resposta4 = "Michelangelo";
        Q7.Resposta5 = "Claude Monet";
        Q7.RespostaCorreta = 2;
        ListaQuestoes.Add(Q7);

        var Q8 = new Questao();
        Q8.NivelPergunta = 1;
        Q8.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q8.Pergunta = "Quem descobriu o Brasil em 1500?";
        Q8.Resposta1 = "Pedro Álvares Cabral";
        Q8.Resposta2 = "Cristóvão Colombo";
        Q8.Resposta3 = "Fernão de Magalhães";
        Q8.Resposta4 = "Vasco da Gama";
        Q8.Resposta5 = "Américo Vespúcio";
        Q8.RespostaCorreta = 1;
        ListaQuestoes.Add(Q8);

        var Q9 = new Questao();
        Q9.NivelPergunta = 1;
        Q9.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q9.Pergunta = "Qual é o metal presente no centro da Terra?";
        Q9.Resposta1 = "Ferro";
        Q9.Resposta2 = "Ouro";
        Q9.Resposta3 = "Alumínio";
        Q9.Resposta4 = "Cobre";
        Q9.Resposta5 = "Prata";
        Q9.RespostaCorreta = 1;
        ListaQuestoes.Add(Q9);

        var Q10 = new Questao();
        Q10.NivelPergunta = 1;
        Q10.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q10.Pergunta = "Qual animal é conhecido como o 'rei da selva'?";
        Q10.Resposta1 = "Elefante";
        Q10.Resposta2 = "Tigre";
        Q10.Resposta3 = "Leão";
        Q10.Resposta4 = "Girafa";
        Q10.Resposta5 = "Rinoceronte";
        Q10.RespostaCorreta = 3;
        ListaQuestoes.Add(Q10);

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
    }
    else
    {
        await App.Current.MainPage.DisplayAlert("Fim","Você Errou","Ok");
        Inicializar();
    }
        labelPontuacao.Text= "Pontuacao: R$" + Pontuacao.ToString();
        labelNivel.Text= "Nivel:" + NivelAtual.ToString();
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