namespace DependencyInjection.Services
{
    public class Operation : IOperationScoped, IOperationSingleton, IOperationTransient
    {
        public Operation() 
        {
            OperationId = Guid.NewGuid().ToString();
        }  
        public string OperationId { get; }
    }
}
