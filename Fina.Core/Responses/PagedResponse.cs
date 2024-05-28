namespace Fina.Core.Responses;
public class PagedResponse<TData> : Response<TData>
{
    public int CurrentPage { get; set; }
}