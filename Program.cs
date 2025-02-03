
using System.ComponentModel;
string letras;
string numero;
string especiais;




Console.WriteLine("----Gerador de Senha----");
Console.Write("Digite a quantidede de caracteres da senha: ");

if (!int.TryParse(Console.ReadLine(), out int qtdSenha) || qtdSenha <= 0)
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




string permitidos = "";

Random random = new Random(); // é utilizado o Random() para posibilitar gerar um valor aleatorio dentro de um intevalo da variavel random
if (letras.ToLower() == "s")// letra uma variavel declarada é ToLower é para ler tudo ou converter demaiusculo para minúsculas
  permitidos += "ABCDEFGHIJKLMNOPQRSTUVMXYZÇ" + "ABCDEFGHIJKLMNOPQRSTUVMXYZÇ".ToLower();

if (numero.ToLower() == "s")
  permitidos += "0123456789";

if (especiais.ToLower() == "s")
  permitidos += "@!#-";

  if (string.IsNullOrEmpty(permitidos))
        {
            Console.WriteLine("Nenhum tipo de caractere foi selecionado. Não é possível gerar uma senha.");
            return;
        }



string gerar = new string(Enumerable.Repeat(permitidos, qtdSenha).Select(s => s[random.Next(s.Length)]).ToArray());
Console.WriteLine($"Senha Gerada {gerar}");



string caminhoArquivo = "senha.txt";
using (StreamWriter escrever = new StreamWriter("senha.txt",true))
{
  Console.WriteLine("senha salva");  
  escrever.WriteLine($"{gerar}"); 
}
if (File.Exists(caminhoArquivo))
        {
            Console.Write("Deseja recuperar senha(s/n):");
            string resposta = Console.ReadLine()?.ToLower();

            if (resposta == "s")
            using (StreamReader ler = new StreamReader(caminhoArquivo))
            {
                string linha;
                
                while ((linha = ler.ReadLine()) != null)
                {
                    Console.WriteLine(linha);  
                }
            }
        }







