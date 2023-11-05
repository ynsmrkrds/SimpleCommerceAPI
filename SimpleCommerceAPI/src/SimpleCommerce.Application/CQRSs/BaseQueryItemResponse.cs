namespace SimpleCommerce.Application.CQRSs
{
    public class BaseQueryItemResponse<T>
    {
        public T Item { get; set; }

        public BaseQueryItemResponse(T item)
        {
            Item = item;
        }
    }
}
