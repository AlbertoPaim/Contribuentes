
namespace Contribuentes.Entities
{
    internal class PessoaJuridica : Contribuente
    {
        public int NumberOfEmployees { get; set; }

        public PessoaJuridica() { }

        public PessoaJuridica(int numberOfEmployees, string name, double rendaAnual) : base(name, rendaAnual)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double ContribuicaoAnual()
        {
            double imposto = 0;

            if (NumberOfEmployees > 10)
            {
                imposto = (RendaAnual * 14) / 100;
            }
            else
            {
                imposto = (RendaAnual * 16) / 100;
            }

            return imposto;
        }
    }
}
