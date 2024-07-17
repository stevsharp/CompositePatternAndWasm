namespace CompositePatternAndWasm.Interface
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Designation { get; set; }

        public string Display()
        {
            return $"\t{Name} works in {Dept} department. Designation:{Designation}";
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"\t{Name} works in {Dept} department. Designation:{Designation}");
        }
    }
}
