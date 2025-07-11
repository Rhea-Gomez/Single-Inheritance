namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Parent Class ---------");
            Parent parent = new Parent();

            parent.Id = 1;
            parent.Name = "James";

            Console.WriteLine("Print the Parent values");
            Console.WriteLine(parent.ToString());

            Console.WriteLine("\n ----------- Child Class ------------ ");
            Child child = new Child();

            child.Id = 2;
            child.Name = "Jack";
            child.College = "FCRIT";

            Console.WriteLine("\n Print the child values");
            Console.WriteLine(child.ToString());

            Parent parent2 = new Parent(101, "Rhea", 5.3);
            Console.WriteLine("Print Parent 2 values");
            Console.WriteLine(parent2.ToString());

            Child child2 = new Child(105, "Rahul", 5.9, "FCRIT");
            Console.WriteLine("Print Child 2 values");
            Console.WriteLine(child2.ToString());
        }
    }
}
