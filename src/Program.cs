//***********************************Beepio, Developed by SpaciousCoder78***********************************
//including
using System;
using System.Timers;

//beepio class
class beepio {
    //main function
    public static void Main(string[] args) {

        while (true)
        {
            //menu
            Console.WriteLine("-------------------------Beepio----------------------");
            Console.WriteLine("1.Start the Beep Timer");
            Console.WriteLine("2.App Info");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter the Option: ");
            //reading input
            string selection = Console.ReadLine();
            //converting string to int for usage
            int selectint = Int32.Parse(selection);
            //if else statements to choose the options
            if (selectint == 1)
            {
                beeptimer();
            }
            else if (selectint == 2)
            {
                info();
            }
            else if (selectint == 3)
            {
                break;
            }
        }

    }
    //beeptimer function
    public static void beeptimer()
    {
        //

        Console.WriteLine("************BEEP TIMER***********");

        // Create a timer with a two-minute interval (120,000 milliseconds).
        System.Timers.Timer timer = new System.Timers.Timer(120000);

        // Hook up the Elapsed event for the timer.
        timer.Elapsed += OnTimedEvent;

        timer.AutoReset = true;
        timer.Enabled = true;

        Console.WriteLine("Press Enter to stop the beep timer.");

        // Start the timer.
        timer.Start();

        // Wait for the user to press Enter to stop the timer.
        Console.ReadLine();

        // Stop and dispose of the timer when the user presses Enter.
        timer.Stop();
        timer.Dispose();
    }

    private static void OnTimedEvent(object sender, ElapsedEventArgs e)
    {
        // Perform the desired action (in this case, beep) every 2 minutes.
        Console.Beep(1060,1060);
    }
    //info function
    public static void info()
    {
        Console.WriteLine("*********************Beepio***********************");
        Console.WriteLine("Version 1.0");
        Console.WriteLine("Developed By SpaciousCoder78");
    }


}
