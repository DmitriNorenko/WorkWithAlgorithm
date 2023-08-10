using WorkWithAlgorithm;

namespace WorkWithAlgorithm

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Users[] users = Users.UsersInfo();
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name},Здравствуйте\n");
                if (user.IsPremium == false)
                {
                    Ads.ShowAds();
                    Console.WriteLine(".........................");
                }
                else
                {
                    Console.WriteLine("У вас премиум-подписка!\n");
                    Console.WriteLine(".........................");
                }
            }
            Console.WriteLine("Конец.");
        }
    }
}