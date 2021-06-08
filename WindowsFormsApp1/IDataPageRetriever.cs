using System.Data;

namespace WindowsFormsApp1
{
    public interface IDataPageRetriever
    {
        DataTable SupplyPageOfData(int v, int rowsPerPage);
    }
}