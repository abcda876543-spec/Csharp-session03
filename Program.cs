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

            #region Question 5 
            int pages5 = 300;
            double doublepage = pages5;
            Console.WriteLine(doublepage);
            #endregion

            #region Question 6
            double price = 49.99;
            int x = (int)price;   // explicit casting
            Console.WriteLine(x);

            #endregion

            #region Question 7
            string pagesText = "464";
            int text = Convert.ToInt32(pagesText);
            Console.WriteLine(text);
            #endregion

            #region Question 8

            string yearText = "2023";
            int year = int.Parse(yearText);

            Console.WriteLine(year);

            string badText = "abc";

            if (int.TryParse(badText, out int badNumber))
            {
                Console.WriteLine(badNumber);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }

            #endregion
        }
    }
}
