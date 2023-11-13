namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new();

            MyList<int> values = new();

            names.Add("Ahmet");
            names.Add("Fatih");
            names.Add("Güzeller");


            values.Add(1);
            values.Add(2);  
            values.Add(3);
            values.Add(4);
                
            values.Add(5);

     

        }
    }
}