using cursoDotnet.Models;


int[] arrayInteiros = new int[4];

  
  arrayInteiros[0]= 72;
  arrayInteiros[1]= 64;
  arrayInteiros[2]= 50;
  arrayInteiros[3]= 1;

Console.WriteLine("Percorrendo o array com o FOR");

for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
  Console.WriteLine($"Posicao N {contador} - {arrayInteiros[contador]}");
}  

Console.WriteLine("Percorrendo o array com o FOREACH ");

int contadorForeach = 0;

foreach(int valor in arrayInteiros)
{
  Console.WriteLine($"Posicao N {contadorForeach} - {valor}");
  contadorForeach++;
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