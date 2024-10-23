// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Boa tarde pessoal ! ! !");

#region EXEMPLO_IF

//const string aprovado = "Aprovado !";
//const string reprovado = "Reprovado !";
//const string emRecuperacao = "Em Recuperação !";

//Console.WriteLine("Informe a nota: ");
//decimal nota = Convert.ToDecimal(Console.ReadLine());

//if (nota >= 5)
//{
//    Console.WriteLine(aprovado);

//}
//else if (nota < 5 && nota != 0)
//{
//    Console.WriteLine(reprovado);
//}
//else if (nota == 0)
//    Console.WriteLine(emRecuperacao);

#endregion EXEMPLO_IF

#region EXEMPLO_SWITCH

//const string dias_31 = "Este mês tem 31 dias.";
//const string dias_30 = "Este mês tem 30 dias.";
//const string dias_28 = "Este mês tem 28 dias.";
//const string mesInvalido = "Este mês não existe até o momento.";

//Console.WriteLine("Digite um mês: ");
//string mes = Console.ReadLine();

//switch (mes.ToUpper())
//{
//    case "JANEIRO":
//    case "AGOSTO":
//        Console.WriteLine(dias_30);
//        break;
//    case "FEVEREIRO":
//        Console.WriteLine(dias_28);
//        break;
//    case "MAIO":
//        Console.WriteLine(dias_31);
//        break;

//    default:
//        Console.WriteLine(mesInvalido);
//        break;
//}

#endregion EXEMPLO_SWITCH

#region WHILE

//int[] arrayInt = new int[] { 1, 2, 3, 4, 5 };
//int i = 0;
//while (i < arrayInt.Length)
//{
//    int numero = arrayInt[i];
//    Console.WriteLine(numero);
//    i++;
//}

#endregion WHILE

#region FOR

//int[] arrayInt = new int[] { 1, 2, 3, 4, 5 };

//for (int c = 0; c < arrayInt.Length; c++)
//{
//    int numero = arrayInt[c];
//    Console.WriteLine(numero);
//}

#endregion FOR

#region FOREACH
// usado para listas quando não tem necessidade de trabalhar com índices

int[] arrayInt = new int[] { 1, 2, 3, 4, 5 };
foreach (int numero in arrayInt)
{
    Console.WriteLine(numero);
}

#endregion FOREACH

