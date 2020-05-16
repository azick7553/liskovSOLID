using System;

namespace liskovSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Account
    {
        protected int capital { get; set; }
        public Account(int sum)
        {
            if (sum < 100)
            {
                throw new Exception("Некорректная сумма");
            }
            this.capital = sum;
        }
        public virtual int Capital
        {
            get { return capital; }
            set
            {
                if (value < 100)
                    throw new Exception("Некорректная сумма");
                capital = value;
            }
        }
    }
    class MicroAccount : Account
    {
        public MicroAccount(int sum) : base(sum)
        {

        }
        public override int Capital
        {
            get { return Capital; }
            set
            {
                capital = value;
            }
        }
    }
}
