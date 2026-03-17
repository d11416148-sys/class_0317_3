namespace Class_0317_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test std1 = new Test();

            std1.MyMid = 101;
            std1.MyFinal = -5;

            Console.WriteLine("期中考" + std1.MyMid.ToString());
            Console.WriteLine("期中考" + std1.MyFinal.ToString());


        }
    }
}