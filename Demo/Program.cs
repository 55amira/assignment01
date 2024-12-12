namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region revision
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Hello, World!");
            #endregion

            #region variable declartion
            ////int Number;
            ////Number =5;
            ////Console.WriteLine(Number);

            //int Number = 5;
            //int Number1, Number2, Number3;
            //int Number4=2,Number5=6,Number7=10;
            //Console.WriteLine(Number5);
            //Number4 = 30;
            //Console.WriteLine(Number4); 
            #endregion


            #region ValueType
            //int Number;
            //Number = 10;

            //Int32 Number2;

            //Console.WriteLine(Number);
            #endregion


            #region HEAP

            ////piont P01;
            ////declare refernce from type point
            ////P01 can refer to object from type point
            ////8 Byte Will Be Allocated At Stack For P01 
            ////0 Byte Will Be Allocted At HEAP for P01

            //Point P01 = new Point();
            //Console.WriteLine(P01);

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //Point P02 = new Point();
            //P02.X = 12;
            //Console.WriteLine(P02.X);
            //Console.WriteLine(P01.X);
            //P01 = P02;

            //Console.WriteLine(P02.X);
            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01);
            //Console.WriteLine(P02); 
            #endregion

            #region Object
            //object O01;
            //O01 = new object();
            //O01 = 1;
            //O01 = 'A';
            //O01 = 2.22;
            //O01 = new Point();
            //Console.WriteLine(O01);


            //Point P01 = new Point();
            ////P01.ToString();

            //Console.WriteLine(P01.ToString());

            //Console.WriteLine(P01.GetType());

            //Console.WriteLine(P01.GetHashCode());

            ////P01.GetType();
            ////P01.GetHashCode();  
            ////P01.Equals();

            #endregion

            #region Casting implicit||explicit
            //int X = 10;
            //double Y = X;// implicit casting 
            //Console.WriteLine(Y);


            //double A = 2.5;
            //int B = (int)A;
            //Console.WriteLine(B);

            //long S = 11111111111111;
            //int C = (int)S;
            //Console.WriteLine(C); 
            #endregion

            #region Convert,parse,TryParse
            //Console.WriteLine("Enter Your Age");
            //int Age = int.Parse(Console.ReadLine());
            //Console.WriteLine(Age);

            //Console.WriteLine("Enter Your Age");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Age);

            //Console.WriteLine("Enter Your GPA:");
            //double GPA = double.Parse(Console.ReadLine());
            //Console.WriteLine(GPA);

            //TryParse

            //Console.WriteLine("Enter Your Age");
            //int Age;
            //bool Flage = int.TryParse(Console.ReadLine(), out Age);
            //Console.WriteLine(Age);
            //Console.WriteLine(Flage);


            #endregion

            #region Discarde

            //double X = 1.5;
            //float Y = 1.5f;
            //decimal Z = 1.5m;

            //int X=1_000_000_000;
            //Console.WriteLine(X);

            #endregion


        }
    }
}
