namespace Poem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myPart1 = new Part1();
            var myPart2 = new Part2();
            var myPart3 = new Part3();
            var myPart4 = new Part4();
            var myPart5 = new Part5();
            var myPart6 = new Part6();
            var myPart7 = new Part7();
            var myPart8 = new Part8();
            var myPart9 = new Part9();
            myPart1.AddPart();            
            myPart2.AddPart(myPart1.Poem);
            myPart3.AddPart(myPart2.Poem);
            myPart4.AddPart(myPart3.Poem);
            myPart5.AddPart(myPart4.Poem);
            myPart6.AddPart(myPart5.Poem);
            myPart7.AddPart(myPart6.Poem);
            myPart8.AddPart(myPart7.Poem);
            myPart9.AddPart(myPart8.Poem);

            Console.WriteLine("1 PART");
            Console.WriteLine(string.Join("\n",myPart1.Poem));
            Console.WriteLine("2 PART");
            Console.WriteLine(string.Join("\n", myPart2.Poem));
            Console.WriteLine("3 PART");
            Console.WriteLine(string.Join("\n", myPart3.Poem));
            Console.WriteLine("4 PART");
            Console.WriteLine(string.Join("\n", myPart4.Poem));
            Console.WriteLine("5 PART");
            Console.WriteLine(string.Join("\n", myPart5.Poem));
            Console.WriteLine("6 PART");
            Console.WriteLine(string.Join("\n", myPart6.Poem));
            Console.WriteLine("7 PART");
            Console.WriteLine(string.Join("\n", myPart7.Poem));
            Console.WriteLine("8 PART");
            Console.WriteLine(string.Join("\n", myPart8.Poem));
            Console.WriteLine("9 PART");
            Console.WriteLine(string.Join("\n", myPart9.Poem));

           
            Console.ReadLine();
        }
    }
}
