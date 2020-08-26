u using System;

class MainClass {
  //EXERCICIO 01 
 

  
  public static double Calculadora (double num1, double num2, char oper){
   
   switch (oper){
    case '+': 
     return (num1+num2);
    case '-':
     return (num1-num2);
    case '*':
     return (num1*num2);
    case '/':
     return (num1/num2);
    default:
     return -1;
   
   }

  }
  public static void Main () {
    double num1;
    double num2;
    char oper;

    Console.WriteLine("Digite o primeiro numero: ");
    num1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o primeiro numero: ");
    num2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a Operação(+,-,*,/): ");
    oper = char.Parse(Console.ReadLine());
    Console.WriteLine("Resultado: {0} ", Calculadora(num1,num2,oper));

   
  } 
      
  EXERCICIO 02 
  
  public static double CaixaLanchonete (int codigo, double quant){
    double preco;
    switch (codigo)
    {
     case 100:
      preco = 1.7;
      return (preco*quant);
     case 101:
      preco = 2.3;
       return (preco*quant);
     case 102:
      preco = 2.6;
       return (preco*quant);
     case 103:
      preco = 2.4;
      return (preco*quant);
     case 104:
      preco = 2.5;
      return (preco*quant);
     case 105:
      preco = 1.0;
      return (preco*quant);
     default: 
      return -1; 
    }

  } 
  public static void Main () {
    double quante;
    int codig;
    
   
  
    Console.WriteLine("Digite o codigo: ");
    codig = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quantidade: ");
    quante = double.Parse(Console.ReadLine());
    Console.WriteLine("Preço total: {0} ", CaixaLanchonete(codig,quante));
   
  } 

 using System; 

class MainClass {

  public static void Candidatos  (){
   Console.WriteLine("33 - José Couve");
   Console.WriteLine("25 - Joana Bravo");
   Console.WriteLine("10 - Roberto Nove");
   Console.WriteLine("0  - Voto branco");
   Console.WriteLine("4  - Voto nulo");
  }

  public static void Votacao() {
    string candidato;
    bool validador = true;
    string sair;
      
    int candidato1 = 0;
    int candidato2 = 0;
    int candidato3 = 0;
    int branco = 0;
    int nulo = 0;
    
     do
    {
      Candidatos(); // exibe as opções
      Console.WriteLine("Digite o numero do seu candidato: "); // Opção do candidato
      candidato = Console.ReadLine(); // Opção do candidato
      switch (candidato) { // Faz a contagem de votos
        case "33":
          candidato1++;
          break;
        case "25":
          candidato2++;
          break;
        case "10":
          candidato3++;
          break;
        case "0":
          branco++;
          break;
        case "4":
          nulo++;
          break;  
      }

      Console.WriteLine("Digite s para votar ou qualquer tecla para sair"); //validação para sair ou votar novamente
      sair = Console.ReadLine();
    
      if (sair != "s") { //validação para sair ou votar novamente
       validador = false;
     };     
    } while (validador == true);
   
     if (candidato1 > candidato2 && candidato1 > candidato3)
     {
       Console.WriteLine("O vencedor foi: José Couve");
     }
    else if (candidato2 > candidato1 && candidato2 > candidato3){
       Console.WriteLine("O vencedor foi: Joana Bravo");
    }    
    else if(candidato3 > candidato1 && candidato3 > candidato2)
     {
       Console.WriteLine("O vencedor foi: Roberto Nove");
     }
    else {
      Console.WriteLine("Houve um empate!");
    }
    Console.WriteLine("Nulos: {0}",nulo);
    Console.WriteLine("Brancos: {0}",branco);
  }
  
  public static void Main () {
    Votacao();
  }
}
}