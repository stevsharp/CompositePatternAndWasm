using System.Text;

namespace CompositePatternAndWasm.Interface
{
    public class CompositeEmployee : IEmployee
    {
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Designation { get; set; }

        private List<IEmployee> subordinateList = [];

        public void AddEmployee(IEmployee e)
        {
            subordinateList.Add(e);
        }

        public void RemoveEmployee(IEmployee e)
        {
            subordinateList.Remove(e);
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"\n{Name} works in {Dept} department. Designation:{Designation} ");

            foreach (IEmployee e in subordinateList)
            {
                e.DisplayDetails();
            }
        }

        public string Display()
        {
            var stringBld= new StringBuilder();

            stringBld.Append($"\n{Name} works in {Dept} department. Designation:{Designation} ");

            foreach (IEmployee e in subordinateList)
            {
                stringBld.Append(e.Display());
            }

            return stringBld.ToString();
        }
    }
}