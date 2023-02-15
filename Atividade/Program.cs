using System;
namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {

            float val_pag;

            Console.WriteLine("DIGITE O SEU NOME COMPLETO: ");
            string nm = Console.ReadLine();

            Console.WriteLine("DIGITE O SEU ENDEREÇO: ");
            string edrc = Console.ReadLine();

            Console.WriteLine("DIGITE [1]: PESSOA FÍSICA\nDIGITE [2]: PESSOA JURÍDICA ");
            int tipo_fj = Convert.ToInt32(Console.ReadLine()); 

            if(tipo_fj == 1)
            {
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = nm;
                pf.endereco = edrc;

                Console.WriteLine("INFORME O SEU CPF: ");
                pf.cpf = Console.ReadLine();

                Console.WriteLine("INFORME O SEU RG: ");
                pf.rg = Console.ReadLine();

                Console.WriteLine("INFORME O VALOR DA COMPRA: ");
                val_pag = float.Parse(Console.ReadLine());

                pf.Pagar_Imposto(val_pag);

            Console.WriteLine("============= PESSOA FÍSICA ==============");
            Console.WriteLine("NOME COMPLETO: " + pf.nome);
            Console.WriteLine("ENDEREÇO: " + pf.endereco);
            Console.WriteLine("CPF: " + pf.cpf);
            Console.WriteLine("RG: " + pf.rg);
            Console.WriteLine("VALOR DA COMPRA: " + pf.valor.ToString("C") + " R$");
            Console.WriteLine("VALOR DO IMPOSTO: " + pf.valor_imposto.ToString("C") + " R$");
            Console.WriteLine("VALOR TOTAL DA COMPRA: " + pf.total.ToString("C") + " R$");
            }
            if(tipo_fj == 2)
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = nm;
                pj.endereco = edrc;

                Console.WriteLine("INFORME O SEU CNPJ: ");
                pj.cnpj = Console.ReadLine();

                Console.WriteLine("INFORME A INSCRIÇÃO ESTADUAL(IE): ");
                pj.ie = Console.ReadLine();

                Console.WriteLine("INFORME O VALOR DA COMPRA: ");
                val_pag = float.Parse(Console.ReadLine());

                pj.Pagar_Imposto(val_pag);

                Console.WriteLine("============= PESSOA JURÍDICA ==============");
                Console.WriteLine("NOME COMPLETO: " + pj.nome);
                Console.WriteLine("ENDEREÇO: " + pj.endereco);
                Console.WriteLine("CNPJ: " + pj.cnpj);
                Console.WriteLine("INSCRIÇÃO ESTADUAL(IE): " + pj.ie);
                Console.WriteLine("VALOR DA COMPRA: " + pj.valor.ToString("C") + " R$");
                Console.WriteLine("VALOR DO IMPOSTO: " + pj.valor_imposto.ToString("C") + " R$");
                Console.WriteLine("VALOR TOTAL A PAGAR: " + pj.total.ToString("C") + " R$");  
            }
            else
            {
                Console.WriteLine("COMANDO INVÁLIDO");
            }
        }
    }
}
