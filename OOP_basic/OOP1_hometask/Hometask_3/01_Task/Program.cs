using System;

namespace _01_Task
{
    class ClassRoom
    {
        Pupil[] pupils = new Pupil[4];

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            this.pupils[0] = pupil1;
            this.pupils[1] = pupil2;

            Console.WriteLine("Class is not full!");
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            this.pupils[0] = pupil1;
            this.pupils[1] = pupil2;
            this.pupils[2] = pupil3;

            Console.WriteLine("Class is not full!");
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            this.pupils[0] = pupil1;
            this.pupils[1] = pupil2;
            this.pupils[2] = pupil3;
            this.pupils[3] = pupil4;
        }

        public void ShowClassInfo()
        {
            foreach(Pupil p in pupils)
            {
                if(p!=null)
                {
                    p.Read();
                    p.Study();
                    p.Write();
                    p.Relax();
                }
            }
        }
    }

    class Pupil
    {
        public Pupil()
        { }

        public virtual void Study()
        {

        }

        public virtual void Read()
        {

        }

        public virtual void Write()
        {

        }

        public virtual void Relax()
        {

        }
    }

    class ExcelentPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Excelent: reading CLR via C#");
        }

        public override void Relax()
        {
            Console.WriteLine("Excelent: no relax:-(");
        }

        public override void Study()
        {
            Console.WriteLine("Excelent: learning C3");
        }

        public override void Write()
        {
            Console.WriteLine("Excelent: writing code");
        }
    }

    class GoodPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Good: reading a book");
        }

        public override void Relax()
        {
            Console.WriteLine("Good: playing football");
        }

        public override void Study()
        {
            Console.WriteLine("Good: learning html LOL");
        }

        public override void Write()
        {
            Console.WriteLine("Good: writing a poem");
        }
    }

    class BadPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Bad: no read");
        }

        public override void Relax()
        {
            Console.WriteLine("Bad: smoking and vodka");
        }

        public override void Study()
        {
            Console.WriteLine("Bad: no study");
        }

        public override void Write()
        {
            Console.WriteLine("Bad: no write");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil eP = new ExcelentPupil();
            GoodPupil gp = new GoodPupil();
            ExcelentPupil ep2 = new ExcelentPupil();
            BadPupil bp = new BadPupil();

            ClassRoom classRoom = new ClassRoom(eP, gp, ep2, bp);

            classRoom.ShowClassInfo();

            Console.ReadKey();
        }
    }
}
