 using BootCamp___Pottencial.Models;

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Luis";
// pessoa1.Idade = 22;
// pessoa1.Cidade = "Salto/SP";
// pessoa1.Aprensentar();

// // Sessão - tipos de dados,DateTime, sintaxe e identação
// string apresentacao = "Olá, seja bem-vindo";
// int quantidade = 1;
// double altura = 1.83;
// decimal preco = 5.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da váriavel quantidade: " + quantidade);
// Console.WriteLine("Valor da váriavel altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da váriavel preco: "+ preco);
// Console.WriteLine("Valor da váriavel condicao: "+ condicao);

//  DateTime dataAtual = DateTime.Now;
//  Console.WriteLine(dataAtual);

//  int a = 10;
//  int b = 20;

//  int c = a + b;
//  c = c + 5;
//  Console.WriteLine(c);





//  // Condicionais - IF / ELSE IF / ELSE

//  int quantidadeEstoque = 4;
//  int quantidadeCompra = 3;
//  bool possivelVenda = quantidadeCompra < 0 && quantidadeEstoque >= quantidadeCompra;

//  Console.WriteLine($"Quantidade em Estoque: {quantidadeEstoque}");
//  Console.WriteLine($"Quantidade da Compra: {quantidadeCompra}");
//  Console.WriteLine($"É possível efetuar a venda? {possivelVenda}");

//  if(quantidadeCompra == 0){
//     Console.WriteLine("Venda Inválida, insira a quantidade desejada");
//  }
//  else if(possivelVenda){
//     Console.WriteLine("Venda realizada com sucesso.");
//  }
//  else {
//     Console.WriteLine("Não é possível efetuar a venda. Não temos a quantidade desejada em estoque.");
//  }





//  // Switch case

//  Console.WriteLine("Digite uma letra:");
//  string letra = Console.ReadLine();

//  switch (letra) {
//    case "a":
//    case "e":
//    case "i":
//    case "o":
//    case "u":
//    Console.WriteLine("É uma vogal.");
//       break;

//    default:
//       Console.WriteLine("Não é uma vogal.");
//       break;
//  }



//=====================================Calculadora==================================
// Calculadora calc = new Calculadora();

//  calc.Somar(10,25);
//  calc.Subtrair(126, 4232);
//  calc.Dividir(3424, 54);
//  calc.Multiplicar(32, 75);
//  calc.Modulo(3243, 86);
//  calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(210);

// int numeroIncremento = 10;

// Console.WriteLine(numeroIncremento);
// Console.WriteLine("Incrimentando ao valor anterior");
// // numero = numero + 1;
// numeroIncremento++; //metodo mais simples e limpo de incremento.
// Console.WriteLine(numeroIncremento);

// //Para decremento:
// int numeroDecremento = 20;
// Console.WriteLine(numeroDecremento);
// Console.WriteLine("Decrementando ao valor anterior");
// //numero = numero - 1;
// numeroDecremento--; //metodo mais simples e limpo de decremento
// Console.WriteLine(numeroDecremento);



//=====================================Laços de Repetição===========================

                                //FOR
// int numero = 10;

// for(int contador = 0; contador <= 10; contador++){
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");

// recebe a declaração da variável, condição, e incrimento.

// }

                                //WHILE
// int numero = 5;
// int contador = 0;
// while(contador <= 10){
//     Console.WriteLine($"{contador + 1}º Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if(contador == 6){
//         break;
//     }
//     // é bem mais simples que o laço For. recebe somente os parâmetros e o incrimento.
// }

                                //DO WHILE

// int soma =  0;
// int numero = 0;

// do {
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// }while(numero != 0);
// Console.WriteLine($"O total da soma dos números digitados é: {soma}");



                                            //Exemplo de menu interativo no console.

string opcao;
bool exibirMenu =  true;
while(exibirMenu) {
    Console.WriteLine("Digite uma opção");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao){        //pode-se usar if / else if / else
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Buscar cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}