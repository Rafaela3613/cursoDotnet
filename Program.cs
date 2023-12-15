using cursoDotnet.Models;


int soma = 0, numero = 0;

do
{
    Console.WriteLine("Digite um numero (0 para parar)");

    numero = Convert.ToInt32 (Console.ReadLine());

    soma += numero;

} while(numero != 0);
Console.WriteLine($"Total da soma dos numeros digitados é: {soma}");






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