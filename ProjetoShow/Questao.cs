namespace ProjetoShow;

public class Questao()
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
    public void Desenhar()
     {
      labelPergunta.Text = Pergunta;
      botaoResposta1.Text = Resposta1;
      botaoResposta2.Text = Resposta2;
      botaoResposta3.Text = Resposta3;
      botaoResposta4.Text = Resposta4;
      botaoResposta5.Text = Resposta5;
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
        var btn = QualBTN (RespostaRespondida);
            btn.BackgroudColor = Colors.Green;
            return true;
       }
         else 
         
       { 
        var btnCorreta = QualBTN (RespostaCorreta);
        var btnIncorreto = QualBTN (RespostaRespondida);
        btnCorreto.BackgroudColor = Colors.Red;
        btnIncorreto.BackgroudColor = Colors.Green;
        return false;
       }
     } 
     private Button QualBTN (int RespostaRespondida) 
     {
       if (RespostaRespondida == RespostaCorreta);
     }
     
}