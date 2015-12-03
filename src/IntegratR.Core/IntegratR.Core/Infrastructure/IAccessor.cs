namespace IntegratR.Core
{
    public interface IAccessor<out TService>
    {
        TService Service { get; }
    }
}