namespace basics05
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1st q
            double[] Prices = { 25.5, 40.0 };
            Console.WriteLine(Prices[1]);
            #endregion

            #region 2nd q

            int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };

            Console.WriteLine(shelfCopies[1, 0]);

            #endregion

            #region 3

            static void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Library!");
            }

            PrintWelcomeMessage();
            #endregion



        }
    }
}