using System;

namespace Methods_Projection
{
    class Program
    {
      static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 345;
            int b = 5;
           
           int c= Sum(a, b);
            int h = Multiplication(a, b);
            int q = Division(a, b);
            int m = Difference(a, b);
            Console.WriteLine($"the multiplication is {h} ");
            Console.WriteLine($"the sum is " + c);
            Console.WriteLine($"Its division is {q}");
            Console.WriteLine($"the diffrence is {m}");
        }
       static  public int Sum(int x, int y)
        {
            int a = x;
            int b = y;
            int result = a + b;
            return result;
        }
        static public int Multiplication(int x, int y)
        {
            int a = x;
            int b = y;
            int result = a* b;
            return result;
        }
    static    public int  Division( int x , int y)
        {
            int a = x;
            int b = y;
            int result = a/b;
            return result;
        }
        static public int Difference (int x, int y)
        {
            int a = x;
            int b = y;
            int result = a-b;
            return result;
        }
        /*static void Main(String[] args)
        {
            Greetings();
           int getresult = Add();
           Add();
            int get = Division();
            Console.WriteLine(getresult);
            Console.WriteLine(get);
        }
      static  public int Add()
        {
            int a = 45;
            int b = 67, add;
            add = a + b;
            return add;
            
        }
        static public int Division()
        {
            int v = 90000;
            int r = 30 , division;
            division = v / r;
            return division;

        }
        static void Greetings()
        {
            Console.WriteLine("hello world");
        }*/
    }
}
