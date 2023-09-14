namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        //Question 1
        Console.Write("Please input two numbers: ");

        int a = Convert.ToInt16(Console.ReadLine());
        int b = Convert.ToInt16(Console.ReadLine());
        int largest = QuestionOne(a,b);
        Console.WriteLine($"a = {a}; b = {b}");
        Console.WriteLine($"The largest number is: {largest}");


        //Question 2 
        Question2(int N, string shape);
    }

    //Question1 Method
    static int QuestionOne(int a, int b){
        if(a>b){
            return a;
        }
        else{
            return b;
        }
        
    }
    //Question2 Method
    //Unfinished
    static int Question2(int N, string shape)
    {
        
        Console.WriteLine("Please input shape:");
        shape = Convert.ToInt16(Console.ReadLine());


        if(shape == "right"){
            for(int row = 0; row<5; row++){
                for(int col = 0; col<5; col++)
                {
                    if(row<=col)
                    Console.Write('*');
                }
                Console.WriteLine("");
            }
        }

    }
}
