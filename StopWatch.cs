using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace LogicalPrograms
{
    class StopWatch
    {
        public void CountTime()
        {
            string check = "";
            StopWatch stopWatch = new StopWatch();
            Console.WriteLine(" press S to begun ");
            Console.WriteLine("press T to stop");
            check = Console.ReadLine();
            if (check == "S") 
            {
                //A: Setup and stuff you don't want timed
                var timer = new Stopwatch();
                timer.Start();

                //B: Run stuff you want timed
                timer.Stop();
                Console.WriteLine(timer.Elapsed);
               // TimeSpan timeTaken = timer.Elapsed;
                //string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
            }

        }
            // placeholder for display value
    }

       
    
}
