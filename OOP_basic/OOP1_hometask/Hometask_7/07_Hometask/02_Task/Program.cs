using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Task
{
    struct Train
    {
        private string destination;
        private int number;
        private DateTime time;

        public Train(string dest, int num, DateTime time)
        {
            this.destination = dest;
            this.number = num;
            this.time = time;
        }

        public string Destination
        {
            get { return this.destination; }
        }
        public int Number
        {
            get { return this.number; }
        }
        public DateTime Time
        {
            get { return this.time; }

        }
    }

    class Schedule
    {
        Train[] trains;

        public Schedule(int numOfTrains)
        {
            this.trains = new Train[numOfTrains];
        }

        public void AddTrainToSchedule()
        {
            string dest;
            int num;
            DateTime time;
            Console.WriteLine("Input information about train #{0}", this.trains.Length+1);
            Console.WriteLine("Number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Destination");
            dest = Console.ReadLine();
            Console.WriteLine("Time");
            time = Convert.ToDateTime(Console.ReadLine());
            Train newTrain = new Train(dest, num, time);
            Train[] bufTrains = new Train[trains.Length+1];
            for (int i = 0; i < this.trains.Length; i++)
            {
                bufTrains[i] = this.trains[i];
            }
            bufTrains[trains.Length] = newTrain;
            this.trains = bufTrains;                
        }

        public void SetTrainArray()
        {
            string dest;
            int num;
            DateTime time;
            for (int i = 0; i < this.trains.Length; i++)
            {
                Console.WriteLine("Input information about train #{0}", i+1);
                Console.WriteLine("Number");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Destination");
                dest = Console.ReadLine();
                Console.WriteLine("Time");
                time = Convert.ToDateTime(Console.ReadLine());
                this.trains[i] = new Train(dest, num, time);
            }
        }

        public void ShowSchedule()
        {
            foreach (Train train in this.trains)
            {
                Console.WriteLine("Information about train #{0}:\nDestination: {1}\nTime: {2}\n", train.Number, train.Destination, train.Time);

            }
        }

        public void SortByNumber()
        {
            Train bufTrain;
            for (int i = 0; i < this.trains.Length; i++)
            {
                for (int j = 0; j < this.trains.Length - 1; j++)
                {
                    if (this.trains[j].Number > this.trains[j+1].Number)
                    {
                        bufTrain = this.trains[j + 1];
                        this.trains[j + 1] = this.trains[j];
                        this.trains[j] = bufTrain;
                    }
                }
            }
        }

        public void SearchByNumber(int number)
        {
            foreach (Train train in this.trains)
            {
                if (train.Number == number)
                    Console.WriteLine("Information about train #{0}:\nDestination: {1}\nTime: {2}\n", train.Number, train.Destination, train.Time);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input amount of trains");
            Schedule schelude = new Schedule(Convert.ToInt32(Console.ReadLine()));

            schelude.SetTrainArray();

            schelude.ShowSchedule();

            schelude.SearchByNumber(1);
            schelude.AddTrainToSchedule();

            schelude.SortByNumber();
            schelude.ShowSchedule();
        }
    }
}
