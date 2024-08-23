using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.X86;
using static LINQ02.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
namespace LINQ02
{
    class EqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            return Sort(x) == Sort(y);
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return Sort(obj).GetHashCode();
        }

        public string Sort(string? x)
        {
            var chars = x.ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Element Operators

            #region Q1

            //var Result = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);

            #endregion

            #region Q2

            //var Result = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);

            #endregion

            #region Q3

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Where(n => n > 5).ElementAt(1);

            #endregion

            #endregion

            #region Aggregate Operators
            #region Q1

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Count(n => n % 2 == 1);

            #endregion

            #region Q2

            //var Result = CustomerList.Select(c => new
            //{
            //    c.CustomerName,
            //    OrderCount = c.Orders.Count()
            //});

            #endregion

            #region Q3

            //var Result = ProductList.Select(p => new
            //{
            //    Category = p.Category,
            //    NumOfProdcts = ProductList.Count(c => c.Category == p.Category)
            //}).ToHashSet();

            #endregion

            #region Q4

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Sum();

            #endregion

            #region Q5

            //var words = File.ReadAllLines("dictionary_english.txt");

            //var Result = words.Sum(x => x.Length);

            #endregion

            #region Q6

            //var words = File.ReadAllLines("dictionary_english.txt");

            //var Result = words.Min(x => x.Length);

            #endregion

            #region Q7

            //var words = File.ReadAllLines("dictionary_english.txt");

            //var Result = words.Max(x => x.Length);

            #endregion

            #region  Q8

            //var words = File.ReadAllLines("dictionary_english.txt");

            //var Result = words.Average(x => x.Length);

            #endregion

            #region Q10

            //var Result = ProductList.GroupBy(p => p.Category).Select(p => new
            //{
            //    category = p.Key,
            //    Price = p.Min(x => x.UnitPrice)
            //});

            #endregion

            #region Q13

            //var Result = ProductList.GroupBy(p => p.Category).Select(p => new
            //{
            //    category = p.Key,
            //    AVG = p.Average(x => x.UnitPrice)
            //});

            #endregion
            #endregion

            #region Set Operators
            #region Q1

            //var Result = ProductList.Select(p => p.Category).Distinct();

            #endregion

            #region Q2

            //var Result = ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CustomerName[0])).Distinct();

            #endregion

            #region Q3

            //var Result = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));

            #endregion

            #region Q4

            //var Result = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CustomerName[0]));

            #endregion

            #region Q5

            //var Result = ProductList.Select(p => p.ProductName[^3..]).Concat(CustomerList.Select(c => c.CustomerName[^3..]));

            #endregion
            #endregion

            #region Partitioning Operators
            #region Q1

            //var Result = CustomerList.Where(c => c.Region == "WA").SelectMany(o => o.Orders).Take(3);

            #endregion

            #region Q2

            //var Result = CustomerList.Where(c => c.Region == "WA").SelectMany(o => o.Orders).Skip(2);


            #endregion

            #region Q3

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.TakeWhile((n, i) => n >= i);

            #endregion

            #region Q4

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile(n => n % 3 != 0);

            #endregion

            #region Q5

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile((n, i) => n >= i);

            #endregion
            #endregion

            #region Grouping Operators
            #region Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var Result = numbers.GroupBy(n => n % 5);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Numbers with Remainder of {item.Key} when devided by 5:");
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}

            #endregion

            #region Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input

            //var words = File.ReadAllLines("dictionary_english.txt");

            //var Result = words.GroupBy(w => w[0]);

            #endregion

            #region Use Group By with a custom comparer that matches words that are consists of the same Characters Together

            //string[] Arr = { "from", "salt", "earn", " last", "near", "form" };

            //var Result = Arr.GroupBy(w => w.Trim(), new EqualityComparer());

            //foreach (var item in Result)
            //{
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //    Console.WriteLine("...............");
            //}

            #endregion 
            #endregion

            //Console.WriteLine(Result);

            //foreach (var Unit in Result)
            //{
            //    Console.WriteLine(Unit);
            //    //foreach (var UnitPrice in Unit)
            //    //{
            //    //    Console.WriteLine(UnitPrice);
            //    //}
            //}

        }
    }
}
