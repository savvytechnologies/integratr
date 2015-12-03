namespace IntegratR.Core
{
    public class ExecutionContext : IExecutionContext, IAccessor<IServiceProvider>
    {
        private IAccessor<IServiceProvider> _context;
        IServiceProvider IAccessor<IServiceProvider>.Service => ((IAccessor<IServiceProvider>)_context).Service;
        public bool EnsureCreated()
        {
            return true;
        }
    }
}