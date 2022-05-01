namespace LibraryManage.Contract.IServices
{
    public interface IRepositoryManager
    {
        IMemberLoginRepository MemberLogin{ get; }
        void Save(); 

    }
}
