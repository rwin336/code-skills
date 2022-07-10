namespace Packt.Shared;

public class PersonComparer : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        if(x is null || x.Name is null|| y is null || y.Name is null)
        {
            return 0;
        }
        // Compare the Name Lengths
        int result = x.Name.Length.CompareTo(y.Name.Length);

        if(result == 0) 
        {
            // ... then compare by the names
            return x.Name.CompareTo(y.Name);
        }
        else  // result will be either -1 or 1
        {
            return result;
        }
    }
}
