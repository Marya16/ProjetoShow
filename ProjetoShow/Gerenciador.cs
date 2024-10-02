namespace ProjetoShow;
public class Gerenciador
{
    List<Questao>listaTodasQuestoes= new List<Questao>();
    List<Questao>listTodasQuestoesRespondidas= new List<Questao>();
    Label labelPontuacao;
    Label labelNivel;
    Questao QuestaoCorrente;
    public Gerenciador( Label labelPerg, Button btnResp1, Button btnResp2, Button btnResp3, Button btnResp4, Button btnResp5, Label labelPontuacao, Label labelNivel)
    {
        CriaPerguntas(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        this.labelPontuacao = labelPontuacao;
        this.labelNivel = labelNivel;
    }
    
  public int Pontuacao {get; private set;} 
  int NivelAtual = 1;


    void Inicializar() 
  {
    Pontuacao = 0;
    NivelAtual = 1;
    listTodasQuestoesRespondidas.Clear();
    ProximaQuestao();

  }  
  public async void VerificaCorreta(int RespostaRespondida)
  {
    if (QuestaoCorrente.VerificarResposta(RespostaRespondida))
    {
        await Task.Delay(1000);
        AdicionaPontuacao(NivelAtual);
        if (NivelAtual == 10)
        {
        await App.Current.MainPage.DisplayAlert("Você chegou ao Fim!","Parabéns","OK");
        Inicializar();
        }
        NivelAtual++;
        ProximaQuestao();
    }
    else
    {
        await App.Current.MainPage.DisplayAlert("Voce chegou ao Fim!","Você Errou","Ok");
        Inicializar();
    }
        labelPontuacao.Text= "Pontuacao: R$" + Pontuacao.ToString();
        labelNivel.Text= "Nivel:" + NivelAtual.ToString();
  }

     public void ProximaQuestao()
    {
        var listaQuestoes= listaTodasQuestoes.Where(d=>d.NivelPergunta == NivelAtual).ToList();
        var numRand= Random.Shared.Next(0, listaQuestoes.Count-1);
        var novaQuestao= listaQuestoes[numRand];
        while (listTodasQuestoesRespondidas.Contains(novaQuestao))
        {
          numRand= Random.Shared.Next(0, listaQuestoes.Count-1);
          novaQuestao= listaQuestoes[numRand];
        } 
        listTodasQuestoesRespondidas.Add(novaQuestao);
        QuestaoCorrente= novaQuestao;
        QuestaoCorrente.Desenha();
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
        listaTodasQuestoes.Add(Q1);

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
        listaTodasQuestoes.Add(Q2);

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
        listaTodasQuestoes.Add(Q3);

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
        listaTodasQuestoes.Add(Q4);

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
        listaTodasQuestoes.Add(Q5);

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
        listaTodasQuestoes.Add(Q6);

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
        listaTodasQuestoes.Add(Q7);

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
        listaTodasQuestoes.Add(Q8);

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
        listaTodasQuestoes.Add(Q9);

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
        listaTodasQuestoes.Add(Q10);

         var Q11 = new Questao();
        Q11.NivelPergunta = 2;
        Q11.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q11.Pergunta = "Qual é o nome do gás que as plantas absorvem durante a fotossíntese?";
        Q11.Resposta1 = "Oxigênio";
        Q11.Resposta2 = "Hidrogênio";
        Q11.Resposta3 = "Dióxido de carbono";
        Q11.Resposta4 = "Nitrogênio";
        Q11.Resposta5 = "Hélio";
        Q11.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q11);

        var Q12 = new Questao();
        Q12.NivelPergunta = 2;
        Q12.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q12.Pergunta = "Qual é a fórmula química da água?";
        Q12.Resposta1 = "CO2";
        Q12.Resposta2 = "H2O";
        Q12.Resposta3 = "O2";
        Q12.Resposta4 = "NaCl";
        Q12.Resposta5 = "CH4";
        Q12.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q12);

        var Q13 = new Questao();
        Q13.NivelPergunta = 2;
        Q13.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q13.Pergunta = "Quem foi o primeiro presidente do Brasil?";
        Q13.Resposta1 = "Juscelino Kubitschek";
        Q13.Resposta2 = "Getúlio Vargas";
        Q13.Resposta3 = "Floriano Peixoto";
        Q13.Resposta4 = "Marechal Deodoro da Fonseca";
        Q13.Resposta5 = "João Goulart";
        Q13.RespostaCorreta = 4;
        listaTodasQuestoes.Add(Q13);

        var Q14 = new Questao();
        Q14.NivelPergunta = 2;
        Q14.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q14.Pergunta = "Em que ano o homem pisou na Lua pela primeira vez?";
        Q14.Resposta1 = "1959";
        Q14.Resposta2 = "1969";
        Q14.Resposta3 = "1975";
        Q14.Resposta4 = "1980";
        Q14.Resposta5 = "1990";
        Q14.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q14);

        var Q15 = new Questao();
        Q15.NivelPergunta = 2;
        Q15.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q15.Pergunta = "Qual é o país mais populoso do mundo?";
        Q15.Resposta1 = "Índia";
        Q15.Resposta2 = "China";
        Q15.Resposta3 = "Estados Unidos";
        Q15.Resposta4 = "Rússia";
        Q15.Resposta5 = "Indonésia";
        Q15.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q15);

        var Q16 = new Questao();
        Q16.NivelPergunta = 2;
        Q16.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q16.Pergunta = "Quem escreveu 'Dom Quixote'?";
        Q16.Resposta1 = "William Shakespeare";
        Q16.Resposta2 = "Leon Tolstói";
        Q16.Resposta3 = "Miguel de Cervantes";
        Q16.Resposta4 = "Fiódor Dostoiévski";
        Q16.Resposta5 = "Gabriel García Márquez";
        Q16.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q16);

        var Q17 = new Questao();
        Q17.NivelPergunta = 2;
        Q17.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q17.Pergunta = "Qual é a maior cordilheira do mundo?";
        Q17.Resposta1 = "Montanhas Rochosas";
        Q17.Resposta2 = "Cordilheira dos Andes";
        Q17.Resposta3 = "Himalaia";
        Q17.Resposta4 = "Alpes";
        Q17.Resposta5 = "Cáucaso";
        Q17.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q17);

        var Q18 = new Questao();
        Q18.NivelPergunta = 2;
        Q18.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q18.Pergunta = "Qual é o maior oceano da Terra?";
        Q18.Resposta1 = "Atlântico";
        Q18.Resposta2 = "Índico";
        Q18.Resposta3 = "Pacífico";
        Q18.Resposta4 = "Ártico";
        Q18.Resposta5 = "Antártico";
        Q18.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q18);

        var Q19 = new Questao();
        Q19.NivelPergunta = 2;
        Q19.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q19.Pergunta = "Qual é a moeda oficial do Japão?";
        Q19.Resposta1 = "Dólar";
        Q19.Resposta2 = "Euro";
        Q19.Resposta3 = "Yen";
        Q19.Resposta4 = "Libra";
        Q19.Resposta5 = "Rupia";
        Q19.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q19);

        var Q20 = new Questao();
        Q20.NivelPergunta = 2;
        Q20.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q20.Pergunta = "Qual é o elemento químico mais abundante no universo?";
        Q20.Resposta1 = "Oxigênio";
        Q20.Resposta2 = "Hidrogênio";
        Q20.Resposta3 = "Carbono";
        Q20.Resposta4 = "Hélio";
        Q20.Resposta5 = "Nitrogênio";
        Q20.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q20);

        var Q21 = new Questao();
        Q21.NivelPergunta = 3;
        Q21.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q21.Pergunta = "Qual é a menor unidade de medida de memória em informática?";
        Q21.Resposta1 = "Byte";
        Q21.Resposta2 = "Bit";
        Q21.Resposta3 = "Kilobyte";
        Q21.Resposta4 = "Megabyte";
        Q21.Resposta5 = "Gigabyte";
        Q21.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q21);

        var Q22 = new Questao();
        Q22.NivelPergunta = 3;
        Q22.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q22.Pergunta = "Qual é o rio mais longo do mundo?";
        Q22.Resposta1 = "Amazonas";
        Q22.Resposta2 = "Nilo";
        Q22.Resposta3 = "Yangtzé";
        Q22.Resposta4 = "Mississipi";
        Q22.Resposta5 = "Danúbio";
        Q22.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q22);

        var Q23 = new Questao();
        Q23.NivelPergunta = 3;
        Q23.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q23.Pergunta = "Qual é o nome da primeira mulher a ganhar um Prêmio Nobel?";
        Q23.Resposta1 = "Marie Curie";
        Q23.Resposta2 = "Rosalind Franklin";
        Q23.Resposta3 = "Ada Lovelace";
        Q23.Resposta4 = "Jane Goodall";
        Q23.Resposta5 = "Dorothy Hodgkin";
        Q23.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q23);

        var Q24 = new Questao();
        Q24.NivelPergunta = 3;
        Q24.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q24.Pergunta = "Qual é a fórmula química do sal de cozinha?";
        Q24.Resposta1 = "H2O";
        Q24.Resposta2 = "CO2";
        Q24.Resposta3 = "NaCl";
        Q24.Resposta4 = "CH4";
        Q24.Resposta5 = "KCl";
        Q24.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q24);

        var Q25 = new Questao();
        Q25.NivelPergunta = 3;
        Q25.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q25.Pergunta = "Em que país foram realizados os primeiros Jogos Olímpicos modernos?";
        Q25.Resposta1 = "França";
        Q25.Resposta2 = "Grécia";
        Q25.Resposta3 = "Estados Unidos";
        Q25.Resposta4 = "Reino Unido";
        Q25.Resposta5 = "Alemanha";
        Q25.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q25);

        var Q26 = new Questao();
        Q26.NivelPergunta = 3;
        Q26.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q26.Pergunta = "Qual é o maior oceano do mundo?";
        Q26.Resposta1 = "Oceano Atlântico";
        Q26.Resposta2 = "Oceano Índico";
        Q26.Resposta3 = "Oceano Pacífico";
        Q26.Resposta4 = "Oceano Ártico";
        Q26.Resposta5 = "Oceano Antártico";
        Q26.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q26);

        var Q27 = new Questao();
        Q27.NivelPergunta = 3;
        Q27.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q27.Pergunta = "Qual é a camada mais externa da Terra?";
        Q27.Resposta1 = "Manto";
        Q27.Resposta2 = "Núcleo";
        Q27.Resposta3 = "Crosta";
        Q27.Resposta4 = "Litosfera";
        Q27.Resposta5 = "Astenosfera";
        Q27.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q27);

        var Q28 = new Questao();
        Q28.NivelPergunta = 3;
        Q28.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q28.Pergunta = "Qual é o nome da galáxia onde a Terra está localizada?";
        Q28.Resposta1 = "Galáxia de Andrômeda";
        Q28.Resposta2 = "Via Láctea";
        Q28.Resposta3 = "Nebulosa do Caranguejo";
        Q28.Resposta4 = "Galáxia de Órion";
        Q28.Resposta5 = "Cinturão de Kuiper";
        Q28.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q28);

        var Q29 = new Questao();
        Q29.NivelPergunta = 3;
        Q29.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q29.Pergunta = "Qual foi o primeiro satélite artificial lançado pela humanidade?";
        Q29.Resposta1 = "Apollo 11";
        Q29.Resposta2 = "Sputnik 1";
        Q29.Resposta3 = "Explorer 1";
        Q29.Resposta4 = "Vostok 1";
        Q29.Resposta5 = "Voyager 1";
        Q29.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q29);

        var Q30 = new Questao();
        Q30.NivelPergunta = 3;
        Q30.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q30.Pergunta = "Qual é o continente com o maior número de países?";
        Q30.Resposta1 = "Ásia";
        Q30.Resposta2 = "África";
        Q30.Resposta3 = "Europa";
        Q30.Resposta4 = "América do Norte";
        Q30.Resposta5 = "América do Sul";
        Q30.RespostaCorreta = 2;

        var Q31 = new Questao();
        Q31.NivelPergunta = 4;
        Q31.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q31.Pergunta = "Qual é a capital da Austrália?";
        Q31.Resposta1 = "Sydney";
        Q31.Resposta2 = "Melbourne";
        Q31.Resposta3 = "Canberra";
        Q31.Resposta4 = "Perth";
        Q31.Resposta5 = "Adelaide";
        Q31.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q31);

        var Q32 = new Questao();
        Q32.NivelPergunta = 4;
        Q32.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q32.Pergunta = "Qual é a montanha mais alta do mundo?";
        Q32.Resposta1 = "Monte Everest";
        Q32.Resposta2 = "K2";
        Q32.Resposta3 = "Monte Kilimanjaro";
        Q32.Resposta4 = "Makalu";
        Q32.Resposta5 = "Lhotse";
        Q32.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q32);

        var Q33 = new Questao();
        Q33.NivelPergunta = 4;
        Q33.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q33.Pergunta = "Quem foi o líder da Revolução Russa de 1917?";
        Q33.Resposta1 = "Josef Stalin";
        Q33.Resposta2 = "Vladimir Lenin";
        Q33.Resposta3 = "Leon Trotsky";
        Q33.Resposta4 = "Mikhail Gorbachev";
        Q33.Resposta5 = "Nikita Khrushchev";
        Q33.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q33);

        var Q34 = new Questao();
        Q34.NivelPergunta = 4;
        Q34.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q34.Pergunta = "Qual é o órgão responsável por bombear o sangue no corpo humano?";
        Q34.Resposta1 = "Pulmões";
        Q34.Resposta2 = "Cérebro";
        Q34.Resposta3 = "Rins";
        Q34.Resposta4 = "Fígado";
        Q34.Resposta5 = "Coração";
        Q34.RespostaCorreta = 5;
        listaTodasQuestoes.Add(Q34);

        var Q35 = new Questao();
        Q35.NivelPergunta = 4;
        Q35.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q35.Pergunta = "Qual país tem o maior número de habitantes no mundo?";
        Q35.Resposta1 = "Índia";
        Q35.Resposta2 = "China";
        Q35.Resposta3 = "Estados Unidos";
        Q35.Resposta4 = "Indonésia";
        Q35.Resposta5 = "Brasil";
        Q35.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q35);

        var Q36 = new Questao();
        Q36.NivelPergunta = 4;
        Q36.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q36.Pergunta = "Quem escreveu o livro 'Dom Quixote'?";
        Q36.Resposta1 = "Gabriel García Márquez";
        Q36.Resposta2 = "Miguel de Cervantes";
        Q36.Resposta3 = "Jorge Luis Borges";
        Q36.Resposta4 = "Pablo Neruda";
        Q36.Resposta5 = "Machado de Assis";
        Q36.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q36);

        var Q37 = new Questao();
        Q37.NivelPergunta = 4;
        Q37.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q37.Pergunta = "Quantos ossos o corpo humano adulto possui?";
        Q37.Resposta1 = "202";
        Q37.Resposta2 = "206";
        Q37.Resposta3 = "210";
        Q37.Resposta4 = "215";
        Q37.Resposta5 = "220";
        Q37.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q37);

        var Q38 = new Questao();
        Q38.NivelPergunta = 4;
        Q38.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q38.Pergunta = "Quem foi o primeiro homem a pisar na Lua?";
        Q38.Resposta1 = "Buzz Aldrin";
        Q38.Resposta2 = "Yuri Gagarin";
        Q38.Resposta3 = "Neil Armstrong";
        Q38.Resposta4 = "John Glenn";
        Q38.Resposta5 = "Alan Shepard";
        Q38.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q38);

        var Q39 = new Questao();
        Q39.NivelPergunta = 4;
        Q39.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q39.Pergunta = "Em qual país foi construído o Taj Mahal?";
        Q39.Resposta1 = "China";
        Q39.Resposta2 = "Japão";
        Q39.Resposta3 = "Índia";
        Q39.Resposta4 = "Irã";
        Q39.Resposta5 = "Indonésia";
        Q39.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q39);

        var Q40 = new Questao();
        Q40.NivelPergunta = 4;
        Q40.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q40.Pergunta = "Qual foi o país que inventou a bússola?";
        Q40.Resposta1 = "China";
        Q40.Resposta2 = "Grécia";
        Q40.Resposta3 = "Egito";
        Q40.Resposta4 = "Índia";
        Q40.Resposta5 = "Roma";
        Q40.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q40);

        var Q41 = new Questao();
        Q41.NivelPergunta = 5;
        Q41.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q41.Pergunta = "Qual é o maior mamífero do planeta?";
        Q41.Resposta1 = "Elefante";
        Q41.Resposta2 = "Baleia Azul";
        Q41.Resposta3 = "Girafa";
        Q41.Resposta4 = "Urso Pardo";
        Q41.Resposta5 = "Rinoceronte";
        Q41.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q41);

        var Q42 = new Questao();
        Q42.NivelPergunta = 5;
        Q42.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q42.Pergunta = "Qual é o elemento químico representado pela letra 'O'?";
        Q42.Resposta1 = "Ouro";
        Q42.Resposta2 = "Oxigênio";
        Q42.Resposta3 = "Prata";
        Q42.Resposta4 = "Ósmio";
        Q42.Resposta5 = "Cobre";
        Q42.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q42);

        var Q43 = new Questao();
        Q43.NivelPergunta = 5;
        Q43.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q43.Pergunta = "Qual é a capital da Espanha?";
        Q43.Resposta1 = "Madrid";
        Q43.Resposta2 = "Barcelona";
        Q43.Resposta3 = "Sevilha";
        Q43.Resposta4 = "Valência";
        Q43.Resposta5 = "Bilbao";
        Q43.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q43);

        var Q44 = new Questao();
        Q44.NivelPergunta = 5;
        Q44.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q44.Pergunta = "Qual é o principal ingrediente do guacamole?";
        Q44.Resposta1 = "Tomate";
        Q44.Resposta2 = "Abacate";
        Q44.Resposta3 = "Cebola";
        Q44.Resposta4 = "Pimenta";
        Q44.Resposta5 = "Coentro";
        Q44.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q44);

        var Q45 = new Questao();
        Q45.NivelPergunta = 5;
        Q45.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q45.Pergunta = "Qual é o símbolo químico para o sódio?";
        Q45.Resposta1 = "Na";
        Q45.Resposta2 = "S";
        Q45.Resposta3 = "K";
        Q45.Resposta4 = "Mg";
        Q45.Resposta5 = "Ca";
        Q45.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q45);

        var Q46 = new Questao();
        Q46.NivelPergunta = 5;
        Q46.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q46.Pergunta = "Qual é o símbolo químico do ouro?";
        Q46.Resposta1 = "Au";
        Q46.Resposta2 = "Ag";
        Q46.Resposta3 = "Pb";
        Q46.Resposta4 = "Fe";
        Q46.Resposta5 = "Hg";
        Q46.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q46);

        var Q47 = new Questao();
        Q47.NivelPergunta = 5;
        Q47.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q47.Pergunta = "Qual é a principal função da clorofila nas plantas?";
        Q47.Resposta1 = "Armazenar energia";
        Q47.Resposta2 = "Realizar a fotossíntese";
        Q47.Resposta3 = "Absorver água";
        Q47.Resposta4 = "Liberar oxigênio";
        Q47.Resposta5 = "Proteger contra pragas";
        Q47.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q47);

        var Q48 = new Questao();
        Q48.NivelPergunta = 5;
        Q48.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q48.Pergunta = "Qual é o maior órgão do corpo humano?";
        Q48.Resposta1 = "Coração";
        Q48.Resposta2 = "Fígado";
        Q48.Resposta3 = "Pele";
        Q48.Resposta4 = "Pulmões";
        Q48.Resposta5 = "Rins";
        Q48.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q48);

        var Q49 = new Questao();
        Q49.NivelPergunta = 5;
        Q49.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q49.Pergunta = "Qual é a velocidade da luz no vácuo?";
        Q49.Resposta1 = "300.000 km/s";
        Q49.Resposta2 = "150.000 km/s";
        Q49.Resposta3 = "450.000 km/s";
        Q49.Resposta4 = "250.000 km/s";
        Q49.Resposta5 = "500.000 km/s";
        Q49.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q49);

        var Q50 = new Questao();
        Q50.NivelPergunta = 5;
        Q50.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q50.Pergunta = "Quem foi o autor da teoria da relatividade?";
        Q50.Resposta1 = "Isaac Newton";
        Q50.Resposta2 = "Albert Einstein";
        Q50.Resposta3 = "Galileu Galilei";
        Q50.Resposta4 = "Niels Bohr";
        Q50.Resposta5 = "Stephen Hawking";
        Q50.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q50);

        var Q51 = new Questao();
        Q51.NivelPergunta = 6;
        Q51.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q51.Pergunta = "Qual é a capital da Noruega?";
        Q51.Resposta1 = "Oslo";
        Q51.Resposta2 = "Estocolmo";
        Q51.Resposta3 = "Copenhague";
        Q51.Resposta4 = "Helsinque";
        Q51.Resposta5 = "Reiquiavique";
        Q51.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q51);

        var Q52 = new Questao();
        Q52.NivelPergunta = 6;
        Q52.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q52.Pergunta = "Qual é a língua oficial do Brasil?";
        Q52.Resposta1 = "Espanhol";
        Q52.Resposta2 = "Francês";
        Q52.Resposta3 = "Português";
        Q52.Resposta4 = "Inglês";
        Q52.Resposta5 = "Italiano";
        Q52.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q52);

        var Q53 = new Questao();
        Q53.NivelPergunta = 6;
        Q53.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q53.Pergunta = "Qual é o maior deserto do mundo?";
        Q53.Resposta1 = "Deserto do Saara";
        Q53.Resposta2 = "Deserto de Gobi";
        Q53.Resposta3 = "Deserto da Antártica";
        Q53.Resposta4 = "Deserto do Atacama";
        Q53.Resposta5 = "Deserto da Arábia";
        Q53.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q53);

        var Q54 = new Questao();
        Q54.NivelPergunta = 6;
        Q54.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q54.Pergunta = "Quem foi a primeira mulher a ganhar um Prêmio Nobel?";
        Q54.Resposta1 = "Marie Curie";
        Q54.Resposta2 = "Rosalind Franklin";
        Q54.Resposta3 = "Ada Lovelace";
        Q54.Resposta4 = "Barbara McClintock";
        Q54.Resposta5 = "Malala Yousafzai";
        Q54.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q54);

        var Q55 = new Questao();
        Q55.NivelPergunta = 6;
        Q55.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q55.Pergunta = "Qual é a capital da Suécia?";
        Q55.Resposta1 = "Oslo";
        Q55.Resposta2 = "Estocolmo";
        Q55.Resposta3 = "Copenhague";
        Q55.Resposta4 = "Helsinque";
        Q55.Resposta5 = "Reiquiavique";
        Q55.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q55);

        var Q56 = new Questao();
        Q56.NivelPergunta = 6;
        Q56.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q56.Pergunta = "Qual é a fórmula química da água?";
        Q56.Resposta1 = "H2O";
        Q56.Resposta2 = "CO2";
        Q56.Resposta3 = "O2";
        Q56.Resposta4 = "NaCl";
        Q56.Resposta5 = "C6H12O6";
        Q56.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q56);

        var Q57 = new Questao();
        Q57.NivelPergunta = 6;
        Q57.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q57.Pergunta = "Qual é a capital da Itália?";
        Q57.Resposta1 = "Roma";
        Q57.Resposta2 = "Milão";
        Q57.Resposta3 = "Veneza";
        Q57.Resposta4 = "Florença";
        Q57.Resposta5 = "Nápoles";
        Q57.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q57);

        var Q58 = new Questao();
        Q58.NivelPergunta = 6;
        Q58.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q58.Pergunta = "Qual é a moeda oficial do Japão?";
        Q58.Resposta1 = "Yuan";
        Q58.Resposta2 = "Won";
        Q58.Resposta3 = "Dólar";
        Q58.Resposta4 = "Iene";
        Q58.Resposta5 = "Rúpia";
        Q58.RespostaCorreta = 4;
        listaTodasQuestoes.Add(Q58);

        var Q59 = new Questao();
        Q59.NivelPergunta = 6;
        Q59.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q59.Pergunta = "Qual é o maior continente do mundo?";
        Q59.Resposta1 = "África";
        Q59.Resposta2 = "América do Sul";
        Q59.Resposta3 = "Ásia";
        Q59.Resposta4 = "Europa";
        Q59.Resposta5 = "Oceania";
        Q59.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q59);

        var Q60 = new Questao();
        Q60.NivelPergunta = 6;
        Q60.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q60.Pergunta = "Qual é o nome do planeta mais próximo do Sol?";
        Q60.Resposta1 = "Venus";
        Q60.Resposta2 = "Terra";
        Q60.Resposta3 = "Marte";
        Q60.Resposta4 = "Mercúrio";
        Q60.Resposta5 = "Júpiter";
        Q60.RespostaCorreta = 4;
        listaTodasQuestoes.Add(Q60);

        var Q61 = new Questao();
        Q61.NivelPergunta = 7;
        Q61.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q61.Pergunta = "Qual é a principal fonte de energia da Terra?";
        Q61.Resposta1 = "Vento";
        Q61.Resposta2 = "Água";
        Q61.Resposta3 = "Sol";
        Q61.Resposta4 = "Carvão";
        Q61.Resposta5 = "Nuclear";
        Q61.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q61);

        var Q62 = new Questao();
        Q62.NivelPergunta = 7;
        Q62.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q62.Pergunta = "Qual é o país com a maior população do mundo?";
        Q62.Resposta1 = "Índia";
        Q62.Resposta2 = "Estados Unidos";
        Q62.Resposta3 = "China";
        Q62.Resposta4 = "Brasil";
        Q62.Resposta5 = "Indonésia";
        Q62.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q62);

        var Q63 = new Questao();
        Q63.NivelPergunta = 7;
        Q63.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q63.Pergunta = "Qual é o elemento químico com o símbolo Na?";
        Q63.Resposta1 = "Sódio";
        Q63.Resposta2 = "Potássio";
        Q63.Resposta3 = "Nitrogênio";
        Q63.Resposta4 = "Cálcio";
        Q63.Resposta5 = "Magnésio";
        Q63.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q63);

        var Q64 = new Questao();
        Q64.NivelPergunta = 7;
        Q64.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q64.Pergunta = "Qual é o maior rio do mundo?";
        Q64.Resposta1 = "Amazonas";
        Q64.Resposta2 = "Nilo";
        Q64.Resposta3 = "Yangtsé";
        Q64.Resposta4 = "Mississipi";
        Q64.Resposta5 = "Ganges";
        Q64.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q64);

        var Q65 = new Questao();
        Q65.NivelPergunta = 7;
        Q65.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q65.Pergunta = "Quem foi o primeiro homem a pisar na Lua?";
        Q65.Resposta1 = "Yuri Gagarin";
        Q65.Resposta2 = "Buzz Aldrin";
        Q65.Resposta3 = "Neil Armstrong";
        Q65.Resposta4 = "John Glenn";
        Q65.Resposta5 = "Michael Collins";
        Q65.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q65);

        var Q66 = new Questao();
        Q66.NivelPergunta = 7;
        Q66.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q66.Pergunta = "Qual é a capital do Egito?";
        Q66.Resposta1 = "Cairo";
        Q66.Resposta2 = "Líbia";
        Q66.Resposta3 = "Tunis";
        Q66.Resposta4 = "Rabate";
        Q66.Resposta5 = "Nairóbi";
        Q66.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q66);

        var Q67 = new Questao();
        Q67.NivelPergunta = 7;
        Q67.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q67.Pergunta = "Qual é o maior animal do mundo?";
        Q67.Resposta1 = "Elefante";
        Q67.Resposta2 = "Tubarão-baleia";
        Q67.Resposta3 = "Baleia-azul";
        Q67.Resposta4 = "Girafa";
        Q67.Resposta5 = "Orca";
        Q67.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q67);

        var Q68 = new Questao();
        Q68.NivelPergunta = 7;
        Q68.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q68.Pergunta = "Qual é a capital da Austrália?";
        Q68.Resposta1 = "Sydney";
        Q68.Resposta2 = "Camberra";
        Q68.Resposta3 = "Melbourne";
        Q68.Resposta4 = "Brisbane";
        Q68.Resposta5 = "Perth";
        Q68.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q68);

        var Q69 = new Questao();
        Q69.NivelPergunta = 7;
        Q69.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q69.Pergunta = "Qual é o principal gás do efeito estufa?";
        Q69.Resposta1 = "Dióxido de carbono (CO2)";
        Q69.Resposta2 = "Metano (CH4)";
        Q69.Resposta3 = "Óxido nitroso (N2O)";
        Q69.Resposta4 = "Vapor d'água";
        Q69.Resposta5 = "Oxigênio (O2)";
        Q69.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q69);

        var Q70 = new Questao();
        Q70.NivelPergunta = 7;
        Q70.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q70.Pergunta = "Qual é o autor da obra 'Dom Casmurro'?";
        Q70.Resposta1 = "Jorge Amado";
        Q70.Resposta2 = "Machado de Assis";
        Q70.Resposta3 = "Graciliano Ramos";
        Q70.Resposta4 = "Clarice Lispector";
        Q70.Resposta5 = "Carlos Drummond de Andrade";
        Q70.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q70);

        var Q71 = new Questao();
        Q71.NivelPergunta = 8;
        Q71.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q71.Pergunta = "Qual é a capital da Nova Zelândia?";
        Q71.Resposta1 = "Auckland";
        Q71.Resposta2 = "Wellington";
        Q71.Resposta3 = "Christchurch";
        Q71.Resposta4 = "Hamilton";
        Q71.Resposta5 = "Dunedin";
        Q71.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q71);

        var Q72 = new Questao();
        Q72.NivelPergunta = 8;
        Q72.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q72.Pergunta = "Quem pintou a obra 'O Grito'?";
        Q72.Resposta1 = "Edvard Munch";
        Q72.Resposta2 = "Pablo Picasso";
        Q72.Resposta3 = "Vincent van Gogh";
        Q72.Resposta4 = "Salvador Dalí";
        Q72.Resposta5 = "Claude Monet";
        Q72.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q72);

        var Q73 = new Questao();
        Q73.NivelPergunta = 8;
        Q73.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q73.Pergunta = "Qual é o maior planeta do Sistema Solar?";
        Q73.Resposta1 = "Terra";
        Q73.Resposta2 = "Júpiter";
        Q73.Resposta3 = "Saturno";
        Q73.Resposta4 = "Urano";
        Q73.Resposta5 = "Netuno";
        Q73.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q73);

        var Q74 = new Questao();
        Q74.NivelPergunta = 8;
        Q74.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q74.Pergunta = "Qual é o primeiro elemento da tabela periódica?";
        Q74.Resposta1 = "Hélio";
        Q74.Resposta2 = "Oxigênio";
        Q74.Resposta3 = "Hidrogênio";
        Q74.Resposta4 = "Carbono";
        Q74.Resposta5 = "Nitrogênio";
        Q74.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q74);

        var Q75 = new Questao();
        Q75.NivelPergunta = 8;
        Q75.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q75.Pergunta = "Qual é a capital da Grécia?";
        Q75.Resposta1 = "Atenas";
        Q75.Resposta2 = "Roma";
        Q75.Resposta3 = "Istambul";
        Q75.Resposta4 = "Moscovo";
        Q75.Resposta5 = "Cairo";
        Q75.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q75);

        var Q76 = new Questao();
        Q76.NivelPergunta = 8;
        Q76.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q76.Pergunta = "Quem foi o inventor da lâmpada elétrica?";
        Q76.Resposta1 = "Thomas Edison";
        Q76.Resposta2 = "Nikola Tesla";
        Q76.Resposta3 = "Alexander Graham Bell";
        Q76.Resposta4 = "Albert Einstein";
        Q76.Resposta5 = "Benjamin Franklin";
        Q76.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q76);

        var Q77 = new Questao();
        Q77.NivelPergunta = 8;
        Q77.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q77.Pergunta = "Qual é o maior deserto do mundo?";
        Q77.Resposta1 = "Sahara";
        Q77.Resposta2 = "Gobi";
        Q77.Resposta3 = "Ártico";
        Q77.Resposta4 = "Antártico";
        Q77.Resposta5 = "Kalahari";
        Q77.RespostaCorreta = 4;
        listaTodasQuestoes.Add(Q77);

        var Q78 = new Questao();
        Q78.NivelPergunta = 8;
        Q78.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q78.Pergunta = "Qual é a moeda oficial do Japão?";
        Q78.Resposta1 = "Yuan";
        Q78.Resposta2 = "Dólar";
        Q78.Resposta3 = "Iene";
        Q78.Resposta4 = "Won";
        Q78.Resposta5 = "Rúpia";
        Q78.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q78);

        var Q79 = new Questao();
        Q79.NivelPergunta = 8;
        Q79.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q79.Pergunta = "Qual é a principal língua falada no Brasil?";
        Q79.Resposta1 = "Espanhol";
        Q79.Resposta2 = "Inglês";
        Q79.Resposta3 = "Português";
        Q79.Resposta4 = "Francês";
        Q79.Resposta5 = "Italiano";
        Q79.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q79);

        var Q80 = new Questao();
        Q80.NivelPergunta = 8;
        Q80.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q80.Pergunta = "Qual é a teoria que descreve a origem do universo?";
        Q80.Resposta1 = "Teoria da Evolução";
        Q80.Resposta2 = "Teoria do Big Bang";
        Q80.Resposta3 = "Teoria da Relatividade";
        Q80.Resposta4 = "Teoria da Gravidade";
        Q80.Resposta5 = "Teoria da Dinâmica";
        Q80.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q80);

        var Q81 = new Questao();
        Q81.NivelPergunta = 9;
        Q81.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q81.Pergunta = "Qual é a capital da França?";
        Q81.Resposta1 = "Paris";
        Q81.Resposta2 = "Londres";
        Q81.Resposta3 = "Berlim";
        Q81.Resposta4 = "Madrid";
        Q81.Resposta5 = "Roma";
        Q81.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q81);

        var Q82 = new Questao();
        Q82.NivelPergunta = 9;
        Q82.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q82.Pergunta = "Qual é o processo pelo qual as plantas produzem seu alimento?";
        Q82.Resposta1 = "Fotossíntese";
        Q82.Resposta2 = "Respiração";
        Q82.Resposta3 = "Transpiração";
        Q82.Resposta4 = "Fermentação";
        Q82.Resposta5 = "Digestão";
        Q82.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q82);

        var Q83 = new Questao();
        Q83.NivelPergunta = 9;
        Q83.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q83.Pergunta = "Qual é o principal componente do ar?";
        Q83.Resposta1 = "Oxigênio";
        Q83.Resposta2 = "Dióxido de carbono";
        Q83.Resposta3 = "Nitrogênio";
        Q83.Resposta4 = "Argônio";
        Q83.Resposta5 = "Hélio";
        Q83.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q83);

        var Q84 = new Questao();
        Q84.NivelPergunta = 9;
        Q84.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q84.Pergunta = "Quem escreveu 'A Moreninha'?";
        Q84.Resposta1 = "Joaquim Manuel de Macedo";
        Q84.Resposta2 = "Machado de Assis";
        Q84.Resposta3 = "José de Alencar";
        Q84.Resposta4 = "Eça de Queirós";
        Q84.Resposta5 = "Graciliano Ramos";
        Q84.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q84);

        var Q85 = new Questao();
        Q85.NivelPergunta = 9;
        Q85.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q85.Pergunta = "Qual é a fórmula química da água?";
        Q85.Resposta1 = "H2O";
        Q85.Resposta2 = "CO2";
        Q85.Resposta3 = "O2";
        Q85.Resposta4 = "NaCl";
        Q85.Resposta5 = "CH4";
        Q85.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q85);

        var Q86 = new Questao();
        Q86.NivelPergunta = 9;
        Q86.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q86.Pergunta = "Qual é o maior continente do mundo?";
        Q86.Resposta1 = "África";
        Q86.Resposta2 = "Ásia";
        Q86.Resposta3 = "América do Sul";
        Q86.Resposta4 = "Europa";
        Q86.Resposta5 = "Oceania";
        Q86.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q86);

        var Q87 = new Questao();
        Q87.NivelPergunta = 9;
        Q87.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q87.Pergunta = "Qual é o animal terrestre mais rápido?";
        Q87.Resposta1 = "Leão";
        Q87.Resposta2 = "Guepardo";
        Q87.Resposta3 = "Cavalo";
        Q87.Resposta4 = "Antílope";
        Q87.Resposta5 = "Lobo";
        Q87.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q87);

        var Q88 = new Questao();
        Q88.NivelPergunta = 9;
        Q88.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q88.Pergunta = "Quem foi o primeiro presidente do Brasil?";
        Q88.Resposta1 = "Deodoro da Fonseca";
        Q88.Resposta2 = "Getúlio Vargas";
        Q88.Resposta3 = "Juscelino Kubitschek";
        Q88.Resposta4 = "Fernando Henrique Cardoso";
        Q88.Resposta5 = "Lula da Silva";
        Q88.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q88);

        var Q89 = new Questao();
        Q89.NivelPergunta = 9;
        Q89.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q89.Pergunta = "Qual é o movimento literário que enfatiza a razão e a ciência?";
        Q89.Resposta1 = "Romantismo";
        Q89.Resposta2 = "Barroco";
        Q89.Resposta3 = "Iluminismo";
        Q89.Resposta4 = "Modernismo";
        Q89.Resposta5 = "Realismo";
        Q89.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q89);

        var Q90 = new Questao();
        Q90.NivelPergunta = 9;
        Q90.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q90.Pergunta = "Qual é a unidade básica da vida?";
        Q90.Resposta1 = "Órgão";
        Q90.Resposta2 = "Tecido";
        Q90.Resposta3 = "Célula";
        Q90.Resposta4 = "Sistema";
        Q90.Resposta5 = "Organismo";
        Q90.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q90);

        var Q91 = new Questao();
        Q91.NivelPergunta = 10;
        Q91.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q91.Pergunta = "Qual é o fenômeno responsável pelas estações do ano?";
        Q91.Resposta1 = "Rotação da Terra";
        Q91.Resposta2 = "Translação da Terra";
        Q91.Resposta3 = "Atração gravitacional";
        Q91.Resposta4 = "Efeito estufa";
        Q91.Resposta5 = "Oxidação";
        Q91.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q91);

        var Q92 = new Questao();
        Q92.NivelPergunta = 10;
        Q92.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q92.Pergunta = "Qual é a capital da Itália?";
        Q92.Resposta1 = "Milão";
        Q92.Resposta2 = "Roma";
        Q92.Resposta3 = "Veneza";
        Q92.Resposta4 = "Florença";
        Q92.Resposta5 = "Nápoles";
        Q92.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q92);

        var Q93 = new Questao();
        Q93.NivelPergunta = 10;
        Q93.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q93.Pergunta = "Qual é o maior órgão do corpo humano?";
        Q93.Resposta1 = "Coração";
        Q93.Resposta2 = "Fígado";
        Q93.Resposta3 = "Pele";
        Q93.Resposta4 = "Cérebro";
        Q93.Resposta5 = "Pulmão";
        Q93.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q93);

        var Q94 = new Questao();
        Q94.NivelPergunta = 10;
        Q94.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q94.Pergunta = "Qual é o planeta mais próximo do Sol?";
        Q94.Resposta1 = "Vênus";
        Q94.Resposta2 = "Terra";
        Q94.Resposta3 = "Marte";
        Q94.Resposta4 = "Mercúrio";
        Q94.Resposta5 = "Júpiter";
        Q94.RespostaCorreta = 4;
        listaTodasQuestoes.Add(Q94);

        var Q95 = new Questao();
        Q95.NivelPergunta = 10;
        Q95.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q95.Pergunta = "Qual foi o primeiro país a conquistar a independência?";
        Q95.Resposta1 = "Estados Unidos";
        Q95.Resposta2 = "Brasil";
        Q95.Resposta3 = "México";
        Q95.Resposta4 = "França";
        Q95.Resposta5 = "Argentina";
        Q95.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q95);

        var Q96 = new Questao();
        Q96.NivelPergunta = 10;
        Q96.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q96.Pergunta = "Qual é a ciência que estuda os seres vivos?";
        Q96.Resposta1 = "Astronomia";
        Q96.Resposta2 = "Biologia";
        Q96.Resposta3 = "Química";
        Q96.Resposta4 = "Física";
        Q96.Resposta5 = "Geologia";
        Q96.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q96);

        var Q97 = new Questao();
        Q97.NivelPergunta = 10;
        Q97.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q97.Pergunta = "Qual é a maior montanha do mundo?";
        Q97.Resposta1 = "K2";
        Q97.Resposta2 = "Monte Everest";
        Q97.Resposta3 = "Kilimanjaro";
        Q97.Resposta4 = "Makalu";
        Q97.Resposta5 = "Lhotse";
        Q97.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q97);

        var Q98 = new Questao();
        Q98.NivelPergunta = 10;
        Q98.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q98.Pergunta = "Qual é a primeira letra do alfabeto grego?";
        Q98.Resposta1 = "Beta";
        Q98.Resposta2 = "Alfa";
        Q98.Resposta3 = "Ômega";
        Q98.Resposta4 = "Gama";
        Q98.Resposta5 = "Delta";
        Q98.RespostaCorreta = 2;
        listaTodasQuestoes.Add(Q98);

        var Q99 = new Questao();
        Q99.NivelPergunta = 10;
        Q99.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q99.Pergunta = "Qual é a principal função do sistema nervoso?";
        Q99.Resposta1 = "Circulação do sangue";
        Q99.Resposta2 = "Movimentação";
        Q99.Resposta3 = "Coordenação e controle";
        Q99.Resposta4 = "Respiração";
        Q99.Resposta5 = "Digestão";
        Q99.RespostaCorreta = 3;
        listaTodasQuestoes.Add(Q99);

        var Q100 = new Questao();
        Q100.NivelPergunta = 10;
        Q100.ConfigurarDesenho(labelPerg, btnResp1, btnResp2, btnResp3 , btnResp4, btnResp5);
        Q100.Pergunta = "Qual é o gas mais abundante na atmosfera terrestre?";
        Q100.Resposta1 = "Nitrogênio";
        Q100.Resposta2 = "Oxigênio";
        Q100.Resposta3 = "Dióxido de carbono";
        Q100.Resposta4 = "Hélio";
        Q100.Resposta5 = "Argônio";
        Q100.RespostaCorreta = 1;
        listaTodasQuestoes.Add(Q100);
        ProximaQuestao();
    }
   

}