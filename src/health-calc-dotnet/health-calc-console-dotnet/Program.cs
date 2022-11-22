// See https://aka.ms/new-console-template for more information
using health_calc_pack_dotnet;
IMC objIMC = new IMC();

Console.WriteLine("Insira sua altura e peso");
Console.Write("Altura: ");
var Altura = Console.ReadLine();

Console.Write("Peso: ");
var Peso = Console.ReadLine();

double ValorIMC = objIMC.CalcularIMC(double.Parse(Altura), double.Parse(Peso));
var Resultado = objIMC.RetornarClassificacaoIMC(ValorIMC);
Console.Write("IMC: " + ValorIMC);
Console.Write("\n");
Console.Write("Classificação: " + Resultado);
Console.Write("\n");

