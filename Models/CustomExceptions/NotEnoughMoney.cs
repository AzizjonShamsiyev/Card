namespace Card.Models.CustomExceptions
{
    public class NotEnoughMoney : Exception
    {
        public NotEnoughMoney(string message) : base(message)
        { }
    }
}
