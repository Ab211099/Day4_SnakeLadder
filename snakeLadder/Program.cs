namespace snakeLadder
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Enter the Program number \n 1.Player start the position\n 2.Check the number on die \n 3.Player check ");

            int optionCheck = Convert.ToInt32(Console.ReadLine());

            switch (optionCheck)
            {
                case 1:
                    UC1_StartPostiotn obj = new UC1_StartPostiotn();    
                    obj.startPosition();
                    break; 
                case 2:
                    UC2_dieCheck obj1 = new UC2_dieCheck();    
                    obj1.dieCheck();
                    break;
                case 3:    
                    UC3_option_check.Checkoption();
                    break;
            }
        }
    }
}