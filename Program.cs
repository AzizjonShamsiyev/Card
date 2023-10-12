using Card.Models;
using Card.Models.CustomExceptions;
using Card.Models.Enums;

namespace Card
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Cards agroUzcard = new Cards()
            {
                Owner = "Azizjon Shamsiyev",
                Balance = 500_000,
                Type = CardsType.UZCARD
            };
            
            Cards xalqHumo = new Cards()
            {
                Owner = "Madiyor Hakimov",
                Balance = 100_000,
                Type = CardsType.HUMO
            }; 
            
            Cards kapitalVisa = new Cards()
            {
                Owner = "Azizjon Shamsiyev",
                Balance = 50,
                Type = CardsType.VISA
            }; 
            Cards mikroUni = new Cards()
            {
                Owner = "Azizjon Shamsiyev",
                Balance = 100,
                Type = CardsType.UNIONPAY
            };

            try
            {
                Cards.Transfer(kapitalVisa, mikroUni, 50);
                Cards.Transfer(agroUzcard, xalqHumo, 600_000);
                Cards.Transfer(agroUzcard, mikroUni, 50);

            }
            catch (CardTypeNotMatch ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotEnoughMoney ex)
            { 
                Console.WriteLine(ex.Message); 
            }
            finally
            {
                Console.WriteLine("Amaliyotlar yakunlandi!");
            }
        }
    }
}