using System;
namespace w01
{
    class Program
    {
        public static double costToRegister(double applicationCount, double cost){
             return applicationCount * cost ;
         }
        static void Main(string[] args) 
        {
            var age = 0.0;
            var cost = 0.0;
             var enroll=false;
            var MIN_AGE = 16; //capitals-constant
            var name = "";
            var type ="";
            var registrationCost = 0.0;  //m makes it decimal money
            var abc=0.0;
            Console.WriteLine("Hello Welcome to Registration");
            Console.WriteLine("You can check your cost of registration here");
            while(name=="")//age==0
            {
               Console.WriteLine("Enter your name");
               name=Console.ReadLine(); 
            }
            Console.WriteLine($"Hell0 {name}!!!!!");
            Console.WriteLine("Have you enrolled in the university? Reply true/false");
            enroll=bool.Parse(Console.ReadLine());
            if(enroll==true){
                Console.WriteLine("You are Enrolled");
            }
            Console.WriteLine("Please enter your age:");
            var agee=Console.ReadLine();
            age = Convert.ToDouble(agee);
            if(age< 13)
            {
                Console.WriteLine($"sorry you must be {MIN_AGE} to get a application. ");
            }
            else
            {
            while(type=="")
            {
                Console.WriteLine("Enter your application type : graduate/undergraduate");
                // Console.WriteLine(" ");
                type=Console.ReadLine();
                Console.WriteLine("Enter the number of applications");
                abc=Convert.ToDouble(Console.ReadLine());
                switch (type)
                {
                   case "undergraduate":
                          cost = 40;
                         break;
                   case "graduate":
                          cost = 70;
                          break;
                   default:
                         break;     
                }
            }
            }
   var total=Program.costToRegister(abc, cost);
   registrationCost = Convert.ToDouble(total);
   Console.WriteLine($"Your registration cost is {registrationCost}.");
        }
    }
}

