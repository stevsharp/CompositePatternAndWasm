namespace CompositePatternAndWasm.Interface;

public interface IEmployee
{
    string Name { get; set; }
    string Dept { get; set; }
    string Designation { get; set; }
    void DisplayDetails();
    string Display();
}
