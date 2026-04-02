namespace Advanced_C__03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             
             
             Exercise 1: Student Grade Manager
           
                3. Sort the grades ascending, then print
                4. Get the first grade above 90
                5. Get all grades below 75 (failing grades)
                6. Remove all failing grades (below 75)
                7. Check if any grade equals 100
                8. Create a List&lt;string&gt; where each grade becomes &quot;Grade: X&quot;
             

             
             */


            #region Exercise 1
            //List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];


            //Console.WriteLine("Grades: " + string.Join(", ", grades));

            //Console.WriteLine($"Count: {grades.Count}");

            //Console.WriteLine($"First: {grades.First()}");

            //Console.WriteLine($"Last: {grades.Last()}");

            //grades.Sort();
            //Console.WriteLine("Grades: " + string.Join(", ", grades));

            //int first = grades.Find(x => x > 90);
            //Console.WriteLine($"First > 90: {first}");


            //List<int> gra = grades.FindAll(x => x < 75);

            //Console.WriteLine("Grades below 75 : " + string.Join(", ", gra));



            //grades.RemoveAll(g => g < 75);

            //Console.WriteLine("\nAfter removing failing grades:");
            //grades.ForEach(g => Console.Write(g + " "));


            //bool has100 = grades.Contains(100);
            //Console.WriteLine($"\nContains 100? {has100}");


            //List<string> gradeStrings = grades
            //    .Select(g => $"Grade: {g}")
            //    .ToList();


            //Console.WriteLine("Formatted Grades:");
            //gradeStrings.ForEach(Console.WriteLine);


            #endregion

            #region Exercise 2
            //SortedList<int, string> leaderboard = new SortedList<int, string>()
            //{

            //    {500, "Ahmed"},
            //    {200, "Sara"},
            //    {800, "Ali"},
            //    {350, "Mona"}

            //};

            //foreach (var item in leaderboard)
            //{
            //    Console.WriteLine($"{item.Key} : {item.Value}");

            //}

            //Console.WriteLine($"First Score: {leaderboard.Keys[0]}");

            //Console.WriteLine($"First Player: {leaderboard.Values[0]}");

            //Console.WriteLine(leaderboard.ContainsKey(500));

            //if (leaderboard.TryGetValue(999, out string player))
            //    Console.WriteLine(player);
            //else
            //    Console.WriteLine("Score not found");


            //leaderboard.Remove(200);

            //Console.WriteLine("Updated leaderboard:");

            //foreach (var entry in leaderboard)
            //{

            //    Console.WriteLine($"{entry.Key} : {entry.Value}");

            //}

            #endregion


            #region Exercise 3
            //Dictionary<string, string> phoneBook = new ()
            //{
            //    {"Ahmed", "0100"},
            //    {"Sara", "0101"},
            //    {"Ali", "0102"},
            //    {"Mona", "0103"}
            //};


            //phoneBook["Omar"] = "0104";


            //bool added01 = phoneBook.TryAdd("Ahmed", "9999");

            //Console.WriteLine($"Added successfully? {added01}");


            //bool added02 = phoneBook.TryAdd("Ahmed", "9999");

            //Console.WriteLine($"TryAdd success: {added02}");


            //Console.WriteLine(phoneBook.ContainsKey("Khaled"));


            //string number = phoneBook.GetValueOrDefault("Khaled", "Not Found");

            //Console.WriteLine(number);


            //Console.WriteLine("Names:");

            //Console.WriteLine(string.Join(" ", phoneBook.Keys));

            //Console.WriteLine("Numbers:");

            //Console.WriteLine(string.Join(" ", phoneBook.Values));


            #endregion

            #region Exercise 4
            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //{
            //    "ahmed@test.com",
            //    "AHMED@test.com",
            //    "sara@test.com",
            //    "Sara@Test.Com"
            //};

            //Console.WriteLine($"Stored Emails Count: {emails.Count}");

            //HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            //HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };


            //var union = new HashSet<int>(setA);
            //union.UnionWith(setB);


            //var intersect = new HashSet<int>(setA);
            //intersect.IntersectWith(setB);


            //var except = new HashSet<int>(setA);
            //except.ExceptWith(setB);



            //Console.WriteLine("Union:" + string.Join(" ", union));


            //Console.WriteLine("Intersect:" + string.Join(" ", intersect));


            //Console.WriteLine("Except:" + string.Join(" ", except));


            //HashSet<int> subset = new HashSet<int> { 1, 2 };

            //Console.WriteLine(subset.IsSubsetOf(setA)); 
            #endregion



        }
    }
}
