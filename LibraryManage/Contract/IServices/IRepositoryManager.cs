namespace LibraryManage.Contract.IServices
{
    public interface IRepositoryManager
    {
        IAuthRepository AuthRepository{ get; }
        IOperationRepository operationRepository { get; }
        IEmployeeRepository employeeRepository { get; }


        void Save(); 

    }
}
