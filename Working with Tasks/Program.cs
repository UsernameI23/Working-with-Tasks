namespace threadRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read, Set Go...");
            int t1Location = 0;
            int t2Location = 0;
            int t3Location = 0;
            int t4Location = 0;
            int t5Location = 0;

            //Creating Threads
            Task t1 = Task.Run(() =>
            {
                Thread.CurrentThread.Name = "Speedy Gonzales";
                for (int i = 0; i < 100; i++)
                {
                    if (t1Location < 100 && t2Location < 100 && t3Location < 100 && t4Location < 100 && t5Location < 100)
                        MoveIt(ref t1Location);
                }

            });
            Task t2 = Task.Run(() =>
            {
                Thread.CurrentThread.Name = "Road Runner";
                for (int i = 0; i < 100; i++)
                {
                    if (t1Location < 100 && t2Location < 100 && t3Location < 100 && t4Location < 100 && t5Location < 100)
                        MoveIt(ref t1Location);
                }

            });
            Task t3 = Task.Run(() =>
            {
                Thread.CurrentThread.Name = "Bugs Bunny";
                for (int i = 0; i < 100; i++)
                {
                    if (t1Location < 100 && t2Location < 100 && t3Location < 100 && t4Location < 100 && t5Location < 100)
                        MoveIt(ref t1Location);
                }

            });
            Task t4 = Task.Run(() =>
            {
                Thread.CurrentThread.Name = "Daffy Duck";
                for (int i = 0; i < 100; i++)
                {
                    if (t1Location < 100 && t2Location < 100 && t3Location < 100 && t4Location < 100 && t5Location < 100)
                        MoveIt(ref t1Location);
                }

            });
            Task t5 = Task.Run(() =>
            {
                Thread.CurrentThread.Name = "Porky Pig";
                for (int i = 0; i < 100; i++)
                {
                    if (t1Location < 100 && t2Location < 100 && t3Location < 100 && t4Location < 100 && t5Location < 100)
                        MoveIt(ref t1Location);
                }

            });
            //t3.Priority = ThreadPriority.AboveNormal;

            //Executing the methods
            //t1.Start();
            //t2.Start();
            //t3.Start();
            //t4.Start();
            //t5.Start();
            Task.WaitAny(t1);
            Task.WaitAny(t2);
            Task.WaitAny(t3);
            Task.WaitAny(t4);
            Task.WaitAny(t5);
            Console.WriteLine("Race has ended");
        }
        static void MoveIt(ref int location)
        {
            location++;
            Console.WriteLine($"{Thread.CurrentThread.Name} location={location}");
            if (location >= 100)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} is the winner");
                return;

            }
        }

    }
}

