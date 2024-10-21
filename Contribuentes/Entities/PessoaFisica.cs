namespace Contribuentes.Entities
{
    internal class PessoaFisica : Contribuente
    {
        public double PlanoSaude { get; set; }

        public PessoaFisica() { }

        public PessoaFisica(double planoSaude, string name, double rendaAnual) : base(name, rendaAnual)
        {
            PlanoSaude = planoSaude;
        }

        public override double ContribuicaoAnual()
        {
            double imposto = 0;

            if (RendaAnual < 20000)
            {
                imposto = (RendaAnual * 15) / 100;
            }
            else if (RendaAnual >= 20000)
            {
                imposto = (RendaAnual * 25) / 100;
            }

            if ( PlanoSaude != null)
            {
                imposto -= PlanoSaude / 2;
            }

            return imposto;

        }
    }
}
