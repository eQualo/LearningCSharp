using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Task
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }

    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Play");
        }
        void  IPlayable.Pause()
        {
            Console.WriteLine("Pause play");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Stop play");
        }
        void IRecordable.Pause()
        {
            Console.WriteLine("Pause record");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine("Stop record");
        }
        public void Record()
        {
            Console.WriteLine("Record");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            (player as IRecordable).Record();
            (player as IRecordable).Stop();

            (player as IPlayable).Play();
            (player as IPlayable).Pause();
        }
    }
}
