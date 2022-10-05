using ConsoleApp;

internal class Program
{
    public static void addStudent(Group gr, Student st)
    {
        gr.AddStudent(st);
    }
    private static void Main(string[] args)
    {
        List<Group> groups = new List<Group>();
        string? temp, temp1;
        while (true)
        {
            switch (Console.ReadLine())
            {
                case "addGroup":
                    Console.WriteLine("enter group name:");
                    Group gr = new(Console.ReadLine());
                    groups.Add(gr); break;
                case "addGoodStudent":
                    Console.WriteLine("enter group name for student:");
                    temp = Console.ReadLine();
                    Console.WriteLine("enter group name of the student:");
                    temp1 = Console.ReadLine();
                    foreach (Group g in groups)
                    {
                        if (g.GetName() == temp) g.AddStudent(new GoodStudent(temp1));
                    }
                    break;
                case "addBadStudent":
                    Console.WriteLine("enter group name for student:");
                    temp = Console.ReadLine();
                    Console.WriteLine("enter name of the student:");
                    temp1 = Console.ReadLine();
                    foreach (Group g in groups)
                    {
                        if (g.GetName() == temp) g.AddStudent(new BadStudent(temp1));
                    }
                    break;
                case "showGroupInfo":
                    foreach (Group g in groups)
                    {
                       Console.WriteLine(g.GetFullInfo());
                    }
                    break;
            }
        }
    }
}