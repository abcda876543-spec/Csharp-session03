namespace C__Session03
{
    class Book {
        string Title;
         int Pages;
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            #region Question 1 
            Book myBook = new Book();
            object obj = myBook;
            Console.WriteLine(obj);
            #endregion
            #region Question 2 
            Console.WriteLine(myBook.ToString());
            Console.WriteLine(myBook.Equals(myBook));
            Console.WriteLine(myBook.GetHashCode());
            Console.WriteLine(myBook.GetType());
            #endregion


            #region Question 3 
            //it is a compile time error
            int pages = 464;

            #endregion

            #region Question 4
            try
            {
                int number = 10;
                int number1 = 0;
                int result = number / number1;
            }
            catch (DivideByZeroException) {
                Console.WriteLine("cannot divide by zero");
                    }
            finally {
                Console.WriteLine("Done");
                    }
            #endregion

        }
    }
}
