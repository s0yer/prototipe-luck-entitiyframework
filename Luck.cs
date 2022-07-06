

namespace Prototipe.Luck.EF
{
    public class Luck
    {
        public int Id { get; internal set; }
        public int Numero { get; internal set; }
        public DateTime DataTempo { get; internal set; }
        

        public override string ToString()
        {
            return $"Luck: {this.Id}, {this.Numero}, {this.DataTempo}";
        }

    }
}