using System;

class MainClass {
  public static void Main (string[] args) {
  Pessoa avaliacao = new Pessoa();

  avaliacao.MeusDados("Thiago",20,65,1.75);
  avaliacao.coletarDados();
  

  avaliacao.Emagrecer(64);
 

  avaliacao.Engordar(67);
 

  avaliacao.Crescimento(20,0);
  

  avaliacao.Envelhecer(0,21);
  

  }
}