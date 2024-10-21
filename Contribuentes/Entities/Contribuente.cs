

namespace Contribuentes.Entities
{
    abstract class Contribuente
    {
        public string Name { get; set; }
        public double RendaAnual { get; set; }
        public Contribuente()
        {

        }
        public Contribuente(string name, double rendaAnual)
        {
            Name = name;
            RendaAnual = rendaAnual;
        }
        public abstract double ContribuicaoAnual();

    }
}
