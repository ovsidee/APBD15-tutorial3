namespace APBD15_tut3;

public class OverfillException : Exception
{
    public OverfillException(string message) : base(message) { }
}