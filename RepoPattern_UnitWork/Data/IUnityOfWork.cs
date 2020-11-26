namespace RepoPattern_UnitWork.Data
{
    //funcao de esternalizar  commit e rollback pra fora dos repositorios, para nao ficar restrito nos repositorios
    public interface IUnityOfWork
    {
        void Commit();
        void Rollback();
    }
}