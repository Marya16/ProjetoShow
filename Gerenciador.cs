namespace ProjetoShow;
public class Gerenciador
{
    List<Questao>ListaQuestoes= new List<Questao>();
    List<int>ListaQuestoesRespondidas= new List<int>();
    Questao QuestaoCorrente;
    public Gerenciador( Label labelPerg, Button btnResp1, Button btnResp2, Button btnResp3, Button btnRespo4, Button btnResp5)
    {
        CriaPerguntas(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
    }
    void CriaPerguntas(Label labelPerg, Button btnResp1, Button btnResp2, Button btnResp3, Button btnRespo4, Button btnResp5)
    {
        var Q1 = new Questao();
        Q1.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q1.Pergunta = "Qual a cor do céu?";
        Q1.Resposta1 = "Vermelho";
        Q1.Resposta2 = "Laranja";
        Q1.Resposta3 = "Verde";
        Q1.Resposta4 = "Azul";
        Q1.Resposta5 = "Preto";
        Q1 RespostaCorreta = 4;
        ListaQuestoes.Add(Q1);

        var Q2 = new Questao();
        Q2.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q2.Pergunta = "Qual a cor da laranja?";
        Q2.Resposta1 = "Preto";
        Q2.Resposta2 = "Verde";
        Q2.Resposta3 = "Laranja";
        Q2.Resposta4 = "Azul";
        Q2.Resposta5 = "Vermelho";
        Q2 RespostaCorreta = 3;
        ListaQuestoes.Add(Q2);
    }
    public async void verificaCorreta(int RespostaRespondida)
    {
        if (QuestaoCorrente.VerificarResposta(RespostaRespondida))
        {
            await Task.Delay (1000);
            ProximaQuestao();        
        }
    }
    void ProximaQuestao()
    {
        var numAleat = Random.Shared.Next(0, ListaQuestoes.Count);
        while (Lista QuestoesRespondidas.Contains(numAleat))
        numAleat = Random.Shared.Next(0, ListaQuestoes.Count);
        ListaQuestoesRespondidas.Add(numAleat);
        QuestaoCorrente = ListaQuestoes[numAleat];
        QuestaoCorrente.Desenha();
    }
}