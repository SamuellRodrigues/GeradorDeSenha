
Console.WriteLine("----Gerador de Senha----");
Console.Write("Digite a quantidede de caracteres da senha: ");

if (!int.TryParse(Console.ReadLine(), out int qtdSenha))
{
  Console.WriteLine("valor invalido!");


}
else
{
  Console.Write("Deseja incluir letras? (s/n):");
  string letras = Console.ReadLine();

  if (letras.ToLower() == "s")

  {
    Console.Write("Deseja incluir numeros? (s/n):");
    string numero = Console.ReadLine();

    Console.Write("Deseja incluir caracteres especiais? (!@#$%&*) (s/n):");
    string especiais = Console.ReadLine();

    Console.Write("Deseja quantos caracteres especiais?:");
    string especial = Console.ReadLine();


  }
}

Random random = new Random();

string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%&*";
int passwordLength = qtdSenha;



string password = "";
for (int i = 0; i < passwordLength; i++)
{
  password += chars[random.Next(chars.Length)];
}
Console.WriteLine($"Senha aleatória: {password}");




