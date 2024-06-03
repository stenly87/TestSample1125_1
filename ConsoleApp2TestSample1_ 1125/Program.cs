class Program
{
    public static void Main()
    { 
        HumanEditVM humanVM = new HumanEditVM();
        humanVM.Human.Name = "Петр";

        Console.WriteLine(humanVM.Human.Name);
    }
}