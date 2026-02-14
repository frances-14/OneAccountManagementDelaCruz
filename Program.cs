namespace AccountManagementDelaCruz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Account Management System");

            string usn = "user123";
            string pw = "user1234";

            Console.WriteLine("Enter Username: ");
            string usnInput = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string pwInput = Console.ReadLine();

            if (usnInput == usn && pwInput == pw)
            {
                Console.WriteLine("Login Successful.");
            }
            else
            {
                Console.WriteLine("Invalid Credentials");
            }
        }
    }
}
