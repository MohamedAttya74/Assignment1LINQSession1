namespace Assignment1LINQSession1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region LINQ - Restriction Operators
            ///     1.  Find all products that are out of stock.
            /// var Result = ProductList.Where(P => P.UnitsInStock == 0);
            /// foreach (var Product in Result)
            ///     Console.WriteLine(Product);

            ///  2. Find all products that are in stock and cost more than 3.00 per unit
            /// var Result = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3.00M);
            /// foreach (var Product in Result)
            ///         Console.WriteLine(Product);

            /// // Returns digits whose name is shorter than their value.
            ///      string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            ///        var Result = Arr.Select((N ,I) => new { Name = N , Index = I })
            ///            .Where( item => item.Name.Length < item.Index)
            ///                    .Select(item => item.Index);
            /// foreach (var num in Result)
            /// {
            ///     Console.WriteLine(num);
            /// }


            #endregion

            #region LINQ - Ordering Operators
            //1. Sort a list of products by name
            ///  var Result = ProductList.OrderBy(P => P.ProductName);
            ///  foreach (var Item in Result)
            ///      Console.WriteLine(Item);
            ///      


            //2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            ///  string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            ///       var Result = Arr.OrderBy(W => W , StringComparer.OrdinalIgnoreCase);
            ///  foreach (var num in Result)
            ///       Console.WriteLine(num);

            //3. Sort a list of products by units in stock from highest to lowest.
            ///  var Result = ProductList.OrderByDescending(P => P.UnitsInStock > 0);
            ///  foreach (var num in Result)
            ///  {
            ///      Console.WriteLine(num);
            ///  }

            // 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            ///     string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            /// 
            ///  var Result = Arr.OrderBy(W => W.Length).ThenBy(W => W);
            ///  foreach (var num in Result)
            ///  {
            ///      Console.WriteLine(num);
            ///  }

            // 5. Sort first by word length and then by a case-insensitive sort of the words in an array.
            ///   string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            ///  var Result  = words.OrderBy(word => word.Length)
            ///                        .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);
            ///  foreach (var num in Result)
            ///  {
            ///      Console.WriteLine(num);
            ///  }

            // 6. Sort a list of products, first by category, and then by unit price, from highest to lowest
            ///  var Result = ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);
            ///  foreach (var num in Result)
            ///  {
            ///      Console.WriteLine(num);
            ///  }

            // 7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            ///     string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            ///  var Result  = Arr.OrderBy(word => word.Length)
            ///                     .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);
            ///  foreach (var num in Result)
            ///  {
            ///      Console.WriteLine(num);
            ///  }

            // 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            /// string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            ///
            /// var Result = Arr.Where(P => P.Length >1 && P.Contains("i"))
            ///                                 .Reverse()   ;
            /// foreach (var num in Result)
            /// {
            ///     Console.WriteLine(num);
            /// }




            #endregion

            #region LINQ – Transformation Operators

            //  1.Return a sequence of just the names of a list of products
            ///  var Result = ProductList.Select(P => P.ProductName);
            ///  foreach (var num in Result)
            ///  {
            ///      Console.WriteLine(num);
            ///  }

            //2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            /// string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            /// var Result = words.Select(W => new { Upper = W.ToUpper(), Lower = W.ToLower() });
            /// foreach (var num in Result)
            /// {
            ///     Console.WriteLine(num);
            /// }


            // 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type
            /// var Result = ProductList.Select(P => new
            /// {
            ///     P.ProductName,
            ///     P.UnitPrice,
            ///     P.ProductID,
            ///     P.UnitsInStock,
            /// });
            /// foreach (var num in Result)
            /// {
            ///     Console.WriteLine(num);
            /// }

            // 4. Determine if the value of ints in an array match their position in the array.
            ///   int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            /// 
            ///   var Result = Arr.Select((Num, I) => Num > I);
            ///   foreach (var num in Result)
            ///   {
            ///       Console.WriteLine(num);
            ///   }

            // 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            ///      int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            ///      int[] numbersB = { 1, 3, 5, 7, 8 };
            ///   var Result =   from a in numbersA
            ///                   from b in numbersB
            ///                   where a < b
            ///                   select new { A = a, B = b };
            /// 
            ///  foreach (var num in Result)
            ///  {
            ///      Console.WriteLine($"{num.A} is less than {num.B}");
            ///  }
            // 6. Select all orders where the order total is less than 500.00.
            ///var Result = CustomerList.SelectMany(C => C.Orders);
            ///foreach (var num in Result)
            ///{
            ///    Console.WriteLine(num);
            ///}

            // 7. Select all orders where the order was made in 1998 or later.
            /// var Result = CustomerList.SelectMany(C => C.Orders.OrderDate >= 1998);
            /// foreach (var num in Result)
            /// {
            ///     Console.WriteLine(num);
            /// }

            //


            #endregion

        }
    }
}
