namespace Program
{
    public class UserName
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Number to find Factor");
            int prime = Convert.ToInt32(Console.ReadLine());
            Prime.PrimeFactors(prime);
        }
    }
}
