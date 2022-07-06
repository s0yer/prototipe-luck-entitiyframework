

namespace Prototipe.Luck.EF
{
    public class Luck
    {
        public int Id { get; internal set; }
        public int numero { get; internal set; }

        public override string ToString()
        {
            return $"Luck: {this.Id}, {this.numero}";
        }

    }
}