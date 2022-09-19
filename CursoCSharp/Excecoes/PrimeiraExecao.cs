
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{

    public class Conta
    {
        private double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if(valor > Saldo)
            {
                throw new ArgumentException("Saldo Insuficiente, tente novamente!");
            }

            Saldo -= valor;
        }
    }
    class PrimeiraExecao
    {
        public static void Executar()
        {
            var conta = new Conta(1223.45);

            try
            {
                conta.Sacar(1500);
                Console.WriteLine("Retirada com Sucesso!");
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
