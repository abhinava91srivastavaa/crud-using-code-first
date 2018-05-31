using System.Collections.Generic;
using data = TSS.Event.Data.Model;


namespace TSS.Event.Data.Contract
{
    public interface IEventRepositories
    {
        void Add(data.Event e);

        void Update(data.Event e);

        void Delete(int Id);

        IEnumerable<data.Event> GetAll();

        data.Event GetEventById(int Id);

        //EmployeeSearchRepository<T> GetEmployeeSearchRepository<T>() where T : class;

        
        //EmployeeSearchRepository<T> GetEmployeeSearchRepository<T>() where T : class;
        //public EmployeeSearchRepository<T> GetEmployeeSearchRepository<T>() where T : class
        //{
        //    var type = typeof(T).Name;
        //    var repositoryType = typeof(EmployeeSearchRepository<>);

        //    /// Activate the requested repository instance, and then return it.   
        //    var repositoryInstance =
        //        Activator.CreateInstance(repositoryType
        //                .MakeGenericType(typeof(T)), _context);

        //    return (EmployeeSearchRepository<T>)repositoryInstance;
        //}

         

        //    param = _unitOfWork.GetEmployeeSearchRepository<EmployeeSearchBO>().SearchByEmployeeEntityID(param);


    }
}
