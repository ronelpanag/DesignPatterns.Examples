namespace Creational
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("* Builder pattern");
            Builder.Execute(args);
            Console.WriteLine();

            Console.WriteLine("* Fluent Builder pattern with recursive generics");
            var person = Person.New
                .Called("John")
                .WorksAsA("Developer")
                .Build();
            Console.WriteLine(person);
            Console.WriteLine();

            Console.WriteLine("===========================================================");
            Console.WriteLine("* Factory pattern");

            Console.ReadKey();
        }
    }
}