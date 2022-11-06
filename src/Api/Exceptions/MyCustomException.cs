namespace Api.Exceptions;

public class MyCustomException : Exception
{
    public MyCustomException(string message, string code) : base(message)
    {
        Code = code;
    }

    public string Code { get; }
}