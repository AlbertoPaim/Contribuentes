using Contribuentes.Entities;

namespace Contribuentes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número de contribuentes:");
            int numeroContribuentes = int.Parse(Console.ReadLine());

            List<Contribuente> contribuentes = new List<Contribuente>();

            for (int i = 0; i < numeroContribuentes; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");
                Console.WriteLine("Pessoa fisica ou Juridica? (cpf ou pj)");
                string tipoPessoa = Console.ReadLine();

                Console.WriteLine("Nome?:");
                string nome = Console.ReadLine();

                Console.WriteLine("Renda anual");
                double rendaAnual = double.Parse(Console.ReadLine());

                if (tipoPessoa == "cpf")
                {
                    Console.WriteLine("Plano saude:");
                    double planoSaude = double.Parse(Console.ReadLine());
                    contribuentes.Add(new PessoaFisica { Name = nome, PlanoSaude = planoSaude, RendaAnual = rendaAnual });
                }
                else
                {
                    Console.WriteLine("Numero de funcionarios:");
                    int numeroFuncionarios = int.Parse(Console.ReadLine());
                    contribuentes.Add(new PessoaJuridica { Name = nome, RendaAnual = rendaAnual, NumberOfEmployees = numeroFuncionarios });
                }
            }

            foreach (Contribuente i in contribuentes)
            {
                Console.WriteLine("TAXES:");

                Console.WriteLine($"{i.Name}: $ {i.ContribuicaoAnual().ToString("F2")}");
            }

        }
    }
}
