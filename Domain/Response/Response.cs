using System.Net;

namespace Domain.Reponce;

public class Response<T>
{
    
    public T Data { get; set; }
    public List<string> Errors { get; set; } = new();
    public HttpStatusCode  StatusCode { get; set; }

    public Response()
    {
        
    }
    public Response(T data)
    {
        Data = data;
        StatusCode = HttpStatusCode.OK;

    }

    public Response(HttpStatusCode code,string message)
    {
        StatusCode = code;
        Errors.Add(message);

    }

    public Response(HttpStatusCode code,List<string> message)
    {
        StatusCode = code;
        Errors.AddRange(message); 
    }

    public Response(HttpStatusCode code, string message, T data)
    {
        StatusCode = code;
        Errors.Add(message);
        Data = data;
    }

    public Response(HttpStatusCode code)
    {
        StatusCode = code; 
    }
}