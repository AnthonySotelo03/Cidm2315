namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        //Insert input
        Console.WriteLine("Please input a letter grade:");
        char grade = Console.ReadLine().ToUpper()[0];
        //To Convert string to uppercase


        int gpa_points;

        switch(grade){
            case 'A':
                gpa_points = 4;
                break;
            case 'B':
                gpa_points = 3;
                break;
            case 'C':
                gpa_points = 2;
                break;
            case 'D':
                gpa_points = 1;
                break;
            case 'F':
                gpa_points = 0;
                break;
            default:
                Console.WriteLine("Wrong letter grade!");
                return;
        }
            Console.WriteLine($"Gpa points: {gpa_points}");
    }
}
