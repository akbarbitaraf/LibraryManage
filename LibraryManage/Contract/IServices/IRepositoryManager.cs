namespace LibraryManage.Contract.IServices
{
    public interface IRepositoryManager
    {
        IAuthRepository AuthRepository{ get; }
        void Save(); 

    }
}
