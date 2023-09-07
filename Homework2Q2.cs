namespace Homework2Q2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input the first num:");
        double first_num = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Input the second num:");
        double sec_num = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Input the third num:");
        double third_num = Convert.ToInt16(Console.ReadLine());

        if(first_num<sec_num){
            if(first_num<third_num){
                Console.WriteLine("The smallest value is: "+ first_num);
            }
            else{
                Console.WriteLine("The smallest value is: " +third_num);
            }
        }
        else{
            if(sec_num<third_num){
                Console.WriteLine("The smallest value is:" +sec_num);
            }
            else{
                Console.WriteLine("The smallest value is: "+third_num);
            }
        }
    }
}
