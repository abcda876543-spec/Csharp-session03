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
        }
    }
}
