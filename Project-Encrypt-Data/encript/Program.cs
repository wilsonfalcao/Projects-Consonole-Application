using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encript
{
    class Program
    {
        static void Main(string[] args)
        {
            Criptografia encripty = new Criptografia();
                    String valorCriptografado = encripty.Encrypt(DateTime.Now.ToLocalTime().ToString("ddMMyyyyHHMMss"));
                    String valorDescriptografado = encripty.Decrypt(valorCriptografado);
                    Console.WriteLine(valorCriptografado);
                    Console.WriteLine(valorDescriptografado);
            /*while (1 > 0)
            {
                Console.WriteLine("Digite o nome para conversão base64");
                string nome = Console.ReadLine();
                var base64 = System.Text.Encoding.UTF8.GetBytes(nome);
                Console.WriteLine("Nome convertindo");
                string stringtex = Convert.ToBase64String(base64);
                Console.WriteLine(stringtex);
                Console.WriteLine("Nome traduzido");
                Console.WriteLine(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(stringtex)));
            }*/
            Console.WriteLine(DateTime.Now.ToLocalTime().ToString("ddMMyyyy"));
            Console.ReadKey();
        }
    }
}
