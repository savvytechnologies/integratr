namespace IntegratR.Core
{
    public interface ITransformation
    {
        IDataSource DataSource { get; }

        IRow[] Rows { get; set; }

        IDataDestination DataDestination { get; }

        void Process();
    }
}