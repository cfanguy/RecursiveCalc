using System;

namespace Recursion
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("3 + 2 = " + this.AddSub(3, 2, "Add"));
            Console.WriteLine("3 + -2 = " + this.AddSub(3, -2, "Add"));
            Console.WriteLine("-3 + 2 = " + this.AddSub(-3, 2, "Add"));
            Console.WriteLine("5 - 3 = " + this.AddSub(5, 3, "Sub"));
            Console.WriteLine("5 - -3 = " + this.AddSub(5, -3, "Sub"));
            Console.WriteLine("-5 - 3 = " + this.AddSub(-5, 3, "Sub"));
            Console.WriteLine("7 * 5 = " + this.Mult(7, 5));
            Console.WriteLine("7 * -5 = " + this.Mult(7, -5));
            Console.WriteLine("2 ^ 10 = " + this.Power(2, 10));

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Program app = new Program();
        }

        int AddSub(int num1, int num2, string op)
        {
            int result = 0;

            if (op.Equals("Add") && num2 > 0)
                num1++;
            else
                if (op.Equals("Add") && num2 < 0)
                    num1--;
                else
                    if (op.Equals("Sub") && num2 > 0)
                        num1--;
                    else
                        if (op.Equals("Sub") && num2 < 0)
                            num1++;

            if (num2 < 0)
                num2++;
            else
                if (num2 > 0)
                    num2--;

            if (num2 > 0 || num2 < 0)
                result = this.AddSub(num1, num2, op);
            else
                if (num2 == 0)
                    result = num1;

            return result;
        }

        int Mult(int num1, int num2)
        {
            int result = 0;

            if (num2 > 0)
            {
                num2--;
                result = this.Mult(num1, num2) + num1;
            }
            else
                if (num2 < 0)
                {
                    num2++;
                    result = this.Mult(num1, num2) - num1;
                }
                else
                    if (num2 == 0)
                        result = 0;

            return result;
        }

        int Power(int num, int pow)
        {
            int ans = 0;

            if (pow > 0)
            {
                pow--;
                ans = this.Power(num, pow) * num;
            }
            else
                if (pow == 0)
                    ans = 1;

            return ans;
        }
    }
}