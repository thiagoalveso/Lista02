using System; 

class Pessoa { 

 private string nome;
 private int idade;
 private double peso, altura; 


public void MeusDados (string nom, int idad, double pes, double alt){
  nome = nom;
  idade = idad;
  peso = pes;
  altura = alt;

}


public void coletarDados (){
  Console.WriteLine("Nome: {0}, Idade: {1}, Peso: {2}, Altura: {3}", nome, idade, peso, altura);

} 


public void Envelhecer (int ano, int idade2){
  if ( ano > 365 ) {
    idade2 = idade + 1;
 }
  if (idade2 > idade ){
    Console.WriteLine("Envelheceu!");
  }
  ano++;
  Console.WriteLine("Idade atual: {0}", idade2);
}

public void Crescimento (int atual , double crescer) {
  if ((atual> idade) && (atual <= 21)){
  
   crescer = (altura + 0.05);
  
  }
  else {
    crescer = altura;
  }
 Console.WriteLine("Tamanho atual: {0}", crescer);
  
}
public void Emagrecer (double emagreceu) {
  if (emagreceu < peso){
   Console.WriteLine("Comparando peso atual e antigo:  {0}kg", emagreceu - peso);
  }
  else { 
    Console.WriteLine("Nenhuma mudança no seu peso.");
  }

}
public void Engordar (double engordou) {
  if (engordou > peso){
   Console.WriteLine("Comparando peso atual e antigo:  +{0} kg", engordou - peso);
  }
  else { 
    Console.WriteLine("Nenhuma mudança no seu peso.");
  }





}
}