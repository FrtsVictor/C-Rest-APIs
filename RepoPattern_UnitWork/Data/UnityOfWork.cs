namespace RepoPattern_UnitWork.Data
{
    public class UnityOfWork : IUnityOfWork
    {

        private readonly DataContext _context;

        public UnityOfWork(DataContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            // garbageCollector will clean automaticaly
        }
    }
}