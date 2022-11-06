namespace Api.Exceptions;

public class DoraException : MyCustomException {
    public DoraException() : base("Dora the Destroyer smashed the server again", "420")
    {
    }
}