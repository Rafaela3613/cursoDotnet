using cursoDotnet.Models;


string opcao;

while(true)
{
  Console.Clear();
  Console.WriteLine("Digite a sua opcao:");
  Console.WriteLine("1 - Cadastrar cliente");
  Console.WriteLine("2 - Buscar cliente");
  Console.WriteLine("3 - Apagar cliente");
  Console.WriteLine("4 - Encerrar");

  opcao = Console.ReadLine();

  switch(opcao)
  {
      case "1":
      Console.WriteLine("Cadastro de cliente");
      break;

      case "2":
      Console.WriteLine("Busca de cliente");
      break;

      case "3":
      Console.WriteLine("Apagar cliente");
      break;

      case "4":
      Console.WriteLine("Encerrar");
      Environment.Exit(0);
      break;

    default:
    Console.WriteLine("Opcao invalida");
    break;
  }
}







//int numero = 5;
//int contador = 0;

//while (contador <= 10){
  //        Console.WriteLine($" {contador}° Execucao : {numero} x {contador} = {numero * contador}");
    //    contador++;

      //  if(contador == 6){
        //break;
        //}
//}



//int numero = 5;

//for(int contador = 0; contador <= 10; contador++){
  //      Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//}


//Calculadora calc = new Calculadora();

//calc.Somar(10, 30);
//calc.Subtrair(15, 5);
//calc.Multiplicar(25, 8);
//calc.Divisao(46, 12);
//calc.Potencia(3, 3);
//calc.Seno(30); 
//calc.Coseno(30);
//calc.Tangente(30);
//calc.RaizQuadrada(9);

//int numeroIncremento = 10;

//Console.WriteLine("Incrementando o 10");
//numeroIncremento++;
//Console.WriteLine(numeroIncremento);

//int numeroDecremento = 20;

//Console.WriteLine("Decrementando o 20");
//numeroDecremento--;
//Console.WriteLine(numeroDecremento);






//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Rafaela";
//pessoa1.Idade = 29;
//pessoa1.Apresentar();