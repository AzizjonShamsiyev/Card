using Card.Models.CustomExceptions;
using Card.Models.Enums;

namespace Card.Models
{
    public class Cards
    {
        public Guid Id { get; }
        public string Owner { get; set; } =string.Empty;
        public CardsType Type { get; set; }

        private decimal balance;
        
        public decimal Balance
        {
            get { return balance; }

            set 
            { 
                if (value >= 0)
                    balance = value; 
                else
                    balance = 0;
            }
        }

        public static void Transfer(Cards send,Cards accept,decimal amount)
        {
            if (send.balance < amount)
                throw new NotEnoughMoney("Kartada mablag' yetarli emas");

            else if (
                (send.Type == CardsType.HUMO || send.Type == CardsType.UZCARD) ==
                (accept.Type == CardsType.VISA || accept.Type == CardsType.UNIONPAY))
                throw new CardTypeNotMatch("Bunday o'tkazmani amalga oshirib bo'lmaydi!");

            else
            {
                Console.WriteLine("Transfer muvaffaqiyatli o'tkazildi !");
            }
        }
    }
}
