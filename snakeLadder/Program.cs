namespace snakeLadder
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Enter the Program number \n 1.Player start the position");

            int optionCheck = Convert.ToInt32(Console.ReadLine());

            switch (optionCheck)
            {
                case 1:
                    UC1_StartPostiotn obj = new UC1_StartPostiotn();    
                    obj.startPosition();
                    break;
            }
        }
    }
}