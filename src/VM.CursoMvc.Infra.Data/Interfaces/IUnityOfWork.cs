namespace VM.CursoMvc.Infra.Data.Interfaces
{
    public interface IUnityOfWork
    {
        void BeginTransaction();

        void SaveChanges();
    }
}