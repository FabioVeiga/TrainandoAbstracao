using System;

namespace Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Pagamento pagamentoBoleto = new PagamentoViaBoleto();
            pagamentoBoleto.setValor(1000M);
            pagamentoBoleto.setVencimento(new DateTime(2020,10,22));
            pagamentoBoleto.Pagar();
            pagamentoBoleto.MostrarComprovante();

            Pagamento pagamentoCartao = new PagamentoViaCartaoDeCredito();
            pagamentoCartao.setValor(582.45M);
            pagamentoCartao.setVencimento(new DateTime(2020,11,12));
            pagamentoCartao.Pagar();
            pagamentoCartao.MostrarComprovante();

        }

        public abstract class Pagamento {
            public decimal Valor { get; private set; }
            public DateTime Vencimento { get; private set; }
            public void setValor(decimal valor){
                Valor = valor;
            }
            public void setVencimento(DateTime vencimento){
                Vencimento = vencimento;
            }
            public virtual void Pagar(){

                Console.WriteLine("Pagamento básico!");
            }
            public virtual void MostrarComprovante(){
                Console.WriteLine("###############################################");
                Console.WriteLine("Seu pagamento foi realizado com sucesso!");
                Console.WriteLine($"Valor: {Valor}");
                Console.WriteLine($"Vencimento: {Vencimento}");
                Console.WriteLine("Obrigado por usar nossos serviços!");
                Console.WriteLine("###############################################\n");
            }
        }

        public class PagamentoViaBoleto : Pagamento {
            public override void Pagar()
            {
                Console.WriteLine("Pagamento via boleto!");
            }
        }

        public class PagamentoViaCartaoDeCredito : Pagamento {

            public override void Pagar()
            {
                Console.WriteLine("Pagamento via Cartão de Crédito!");
            }
        }
    }
}
