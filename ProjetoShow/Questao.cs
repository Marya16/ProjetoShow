
namespace ProjetoShow;

public class Questao:IEquatable<Questao>
{
    public string Pergunta;
    public string Resposta1;
    public string Resposta2;
    public string Resposta3;
    public string Resposta4;
    public string Resposta5;
    public int RespostaCorreta;
    public int NivelPergunta;
    private Label labelPergunta;
    private Button botaoResposta1;
    private Button botaoResposta2;
    private Button botaoResposta3;
    private Button botaoResposta4;
    private Button botaoResposta5;
    public void Desenha()
     {
      labelPergunta.Text = Pergunta;
      botaoResposta1.Text = Resposta1;
      botaoResposta2.Text = Resposta2;
      botaoResposta3.Text = Resposta3;
      botaoResposta4.Text = Resposta4;
      botaoResposta5.Text = Resposta5;

    this.botaoResposta1!.BackgroundColor = Color.FromArgb("#c99908");
    this.botaoResposta1!.TextColor       = Colors.Black;
    this.botaoResposta2!.BackgroundColor = Color.FromArgb("#c99908");
    this.botaoResposta2!.TextColor       = Colors.Black;
    this.botaoResposta3!.BackgroundColor = Color.FromArgb("#c99908");
    this.botaoResposta3!.TextColor       = Colors.Black;
    this.botaoResposta4!.BackgroundColor = Color.FromArgb("#c99908");
    this.botaoResposta4!.TextColor       = Colors.Black;
    this.botaoResposta5!.BackgroundColor = Color.FromArgb("#c99908");
    this.botaoResposta5!.TextColor       = Colors.Black;
     }
    public Questao()
     {
      
     }
     public bool Equals(Questao q)
      {
        return this.Nivel==Q.Nivel;
      }
    public Questao(Label pg, Button bt1, Button bt2, Button bt3, Button bt4, Button bt5)
     {
       labelPergunta = pg;
       botaoResposta1 = bt1;
       botaoResposta2 = bt2;
       botaoResposta3 = bt3;
       botaoResposta4 = bt4;
       botaoResposta5 = bt5;

     } 
    
     public void ConfigurarDesenho(Label pg, Button bt1, Button bt2, Button bt3, Button bt4, Button bt5)
     {
        labelPergunta = pg;
        botaoResposta1 = bt1;
        botaoResposta2 = bt2;
        botaoResposta3 = bt3;
        botaoResposta4 = bt4;
        botaoResposta5 = bt5;
     }
     public bool VerificarResposta(int RespostaRespondida)
     {
         if (RespostaCorreta == RespostaRespondida) 
       { 
        var btn = QualBotao (RespostaRespondida);
            btn.BackgroundColor = Colors.Green;
            return true;
       }
         else 
         
       { 
        var btnCorreto = QualBotao (RespostaCorreta);
        var btnIncorreto = QualBotao (RespostaRespondida);
        btnCorreto.BackgroundColor = Colors.Green;
        btnIncorreto.BackgroundColor = Colors.Red;
        return false;
       }
     } 
     private Button QualBotao(int RespostaRespondida) 
     {
      if (RespostaRespondida ==1)
          return botaoResposta1;
      else if (RespostaRespondida ==2)
        return botaoResposta2;
      else if (RespostaRespondida ==3)
        return botaoResposta3;
      else if (RespostaRespondida ==4)
        return botaoResposta4;
        else 
            return botaoResposta5;
     }

}