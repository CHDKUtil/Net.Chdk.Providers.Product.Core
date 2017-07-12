namespace Net.Chdk.Providers.Product
{
    public interface IProductProvider
    {
        string[] GetProductNames();
        string GetCategoryName(string productName);
    }
}