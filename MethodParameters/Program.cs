
//namespace MethodParameters
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int x = 20;
//            DemoMethod(ref x);
//            Console.WriteLine(x);

//        }
//        public static void DemoMethod(ref int x) //value parameters 20 printed  //ref key for reference parameter 30 printed
//        {
//            x = 30;
//        }
//    }
//}



namespace MethodParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalsum, totalproduct;
            DemoMethod(4, 6, out totalsum, out totalproduct);

            Console.WriteLine(totalsum);
            Console.WriteLine(totalproduct);
            
        }
        public static void DemoMethod(int x, int y, out int sum, out int product)
        {
             sum = x+ y;
             product = x * y;
            
        }
    }
}


/* Method Parameters in C#
 

value Parameters: The variables x is passed by value to the method DemoMethod. Any changes that take place inside the
method have no effect on the original value of the variable.


Reference Parameters: The ref method parameter keyword on method parameter causes a method to refer to the same
variable when control passes back to the calling method.

Output Parameters: A return statement can be used for returning only one value from a function. However,using output
parameters, you can return two or more values from a function.

Parameter Arrays:C# Parameter array is decleared with the params modifier.Parameter type must be decleared as an array-
Single params array per method is allowed. Must be the last argument in the method's parameter list.





 */