Stack L =new Stack();

public class Stack
{
    	
    public List<string> list = new List<string>();
    public void Add(string bukv)
    {
        list.Add(bukv);
    }
    public void Pop()
    {
        try{
            list.RemoveAt(list.Count-1);
        }
        catch(Exception)
        {
            Console.WriteLine("Стек пустой");
        }
    }
    public void Size()
    {
        Console.WriteLine(list.Count);
    }
    public void Top()
    {
        try
        {
        Console.WriteLine(list[list.Count-1]);
        }
        catch (Exception)
        {
            Console.WriteLine("0");
        }
    }   
    
}
