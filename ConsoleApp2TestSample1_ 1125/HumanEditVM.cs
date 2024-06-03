public class HumanEditVM
{
    public HumanEditVM()
    {
        
    }
    public HumanEditVM(Human human)
    {
        Human = new Human { Name = human.Name, Birthday = human.Birthday };
    }

    public Human Human { get; set; } = new Human();

}
