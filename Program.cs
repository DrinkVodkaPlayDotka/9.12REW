Stack L =new Stack();
StackExtensions SL=new StackExtensions();
// L.Add("1"); Тест для доп.задание 1
// L.Add("2");
// L.Add("3");
// SL.Add("6");
// SL.Add("5");
// SL.Add("4");
// SL.Merge(L.list,SL.list);
// L.Print(); 




public class Stack
{
    	
    public List<string> list = new List<string>();
    public void Print()
    {
        for (int i=0 ;i< list.Count;i++)
        {
            Console.WriteLine(list[i]);
        }
    }
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
public class StackExtensions :Stack
{
    public List<string> St = new List<string>();
    
    public List<string> Merge (List<string> s1,List<string> s2)
    {
        s2.Reverse();
        for (int i=0;i<s2.Count;i++)
        {
            s1.Add(s2[i]);
        }
        return s1;
    }
}
