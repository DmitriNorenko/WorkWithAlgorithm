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
                if(user.IsPremium == false)
                {
                    Ads.ShowAds();
                }
                else
                {
                    Console.WriteLine("У вас премиум-подписка!");
                }
            }
            Console.WriteLine("Конец.");
        }
    }
}