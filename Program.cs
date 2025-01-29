
using System.ComponentModel;
string letras;
string numero;
string especiais;



Console.WriteLine("----Gerador de Senha----");
Console.Write("Digite a quantidede de caracteres da senha: ");

if (!int.TryParse(Console.ReadLine(), out int qtdSenha))
{
  Console.WriteLine("valor invalido!");
  return;
}


Console.Write("Deseja incluir letras? (s/n):");
letras = Console.ReadLine();

if (letras.ToLower() == "s")

{
  Console.Write("Deseja incluir numeros? (s/n):");
  numero = Console.ReadLine();

  Console.Write("Deseja incluir caracteres especiais? (!@#$%&*) (s/n):");
  especiais = Console.ReadLine();



}

int numeroaleatorio;
Random random = new Random();
for (int i = 0; i < qtdSenha; i++)
{
  numeroaleatorio =+ random.Next(0, 9);
  Console.WriteLine($"senha {numeroaleatorio}");
}









