



namespace Prototipe.Luck.EF
{
    class LuckDAOEntity: ILuckDAO, IDisposable
    {
        private LuckConext contexto;

        public LuckDAOEntity()
        {
            this.contexto = new LuckConext();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
        public void Adicionar(Luck lu)
        {
            contexto.Lucks.Add(lu);
            contexto.SaveChanges();
        }
        public void Atualizar(Luck lu)
        {
            contexto.Lucks.Update(lu);
            contexto.SaveChanges();
        }

        public IList<Luck> Lucks()
        {
            return contexto.Lucks.ToList();
        }
        public void Remover(Luck lu)
        {
            contexto.Lucks.Remove(lu);
            contexto.SaveChanges();
        }
    }

}