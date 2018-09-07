using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hometask_2
{
    partial class Converter
    {
        float usd;
        float eur;
        float rub;

        public Converter(float usd, float eur, float rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
    }

    partial class Converter
    {
        public float FromRub(float sum)
        {
            return sum * this.rub;
        }
        public float FromUsd(float sum)
        {
            return sum * this.usd;
        }
        public float FromEur(float sum)
        {
            return sum * this.eur;
        }

        public float ToRub(float sum)
        {
            return sum / this.rub;
        }
        public float ToUsd(float sum)
        {
            return sum / this.usd;
        }
        public float ToEur(float sum)
        {
            return sum / this.eur;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Converter conv = new Converter(50, 100, 1/2);

            Console.WriteLine(conv.ToEur(100));
            Console.WriteLine(conv.FromUsd(20));

            Console.ReadKey();
        }
    }
}
