namespace ValueAndReferenceTypes;

internal class Program
{
    static void Main(string[] args)
    {


        int number1 = 10;
        int number2 = 70;
        number1  = number2;
        number2 = 65;

        Console.WriteLine(number1); //Value Types


        int[] numbers1 = { 10, 20,30,40 };  
        int[] numbers2 = {  570, 60,70,80 };  
        numbers1 = numbers2;
        numbers2[0] = 154;
        

        Console.WriteLine(numbers1[0]);







    }
}