



namespace Prototipe.Luck.EF
{
    interface ILuckDAO
    {
        void Adicionar(Luck lu);
        void Atualizar(Luck lu);
        void Remover(Luck lu);
        IList<Luck> Lucks();
    }
}