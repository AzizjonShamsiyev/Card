namespace Card.Models.CustomExceptions
{
    public class CardTypeNotMatch : Exception
    {
        public CardTypeNotMatch(string message) : base(message)
        { }
    }
}
