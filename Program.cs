
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




Console.Write("Deseja incluir numeros? (s/n):");
numero = Console.ReadLine();



Console.Write("Deseja incluir caracteres especiais? (@, !, # ou -) (s/n):");
especiais = Console.ReadLine();




string permetidos = "";

Random random = new Random(); // é utilizado o Random() para posibilitar gerar um valor aleatorio dentro de um intevalo da variavel random
if (letras.ToLower() == "s")// letra uma variavel declarada é ToLower é para ler tudo ou converter demaiusculo para minúsculas
  permetidos += "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

if (numero.ToLower() == "s")
  permetidos += "0123456789";

if (especiais.ToLower() == "s")
  permetidos += "@, !, # ou -";



string gerar = new string(Enumerable.Repeat(permetidos, qtdSenha).Select(s => s[random.Next(s.Length)]).ToArray());
Console.WriteLine($"Senha Gerada {gerar}");


// string caminhoArquivo = "bkp.TXT";

//  SalvarSenhaEmArquivo(gerar, caminhoArquivo);

using (StreamWriter escrever = new StreamWriter("senha.txt"))
{
  Console.WriteLine("senha salva");  // Imprime na tela
  escrever.WriteLine($"{gerar}"); // Salva no arquivo
}








