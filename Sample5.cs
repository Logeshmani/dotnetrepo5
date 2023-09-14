public class Sample5{

    public static void Main(string[] args){

       string StudentName;
       double TotalMarks;
        Console.WriteLine("Enter Student name ");
        StudentName=Console.ReadLine();
        Console.WriteLine("Enter the Marks ");
       TotalMarks= Convert.ToInt32(Console.ReadLine());  // By Sneha

        if(TotalMarks>=70 && TotalMarks<=100){
          Console.WriteLine("grade A");
        }
        else if(TotalMarks>=45 && TotalMarks <70){ // by sanjai
          Console.WriteLine("B grade");

        }

        
          Console.WriteLine($"The {StudentName} has scored ..... ");
       
    }
}
