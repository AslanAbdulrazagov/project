namespace project
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(1);
            list.Find(1);
            foreach (int i in list.FindAll(1)) {
                Console.WriteLine(i);
            }
            
            
        }
    }
}