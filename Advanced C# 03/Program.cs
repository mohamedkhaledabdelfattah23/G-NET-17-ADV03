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








        }
    }
}
