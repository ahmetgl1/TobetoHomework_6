namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> names = new List<string>();    
            names.Add("a");
            names.Add("b");
            names.Add("c");
            names.Add("d");
            names.Add("e");


            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}