//List<int> integerList = new List<int>()
//			{
//				1, 2, 3, 4, 5, 6, 7, 8, 9, 10
//			};
////Step2: Query
////LINQ Query using Query Syntax to fetch all numbers which are > 5
//var QuerySyntax = integerList.Where(obj => obj > 5).ToList();
////Step3: Execution
//foreach (var item in QuerySyntax)
//{
//	Console.Write(item + " ");
//}



//List<int> integerList = new List<int>()
//			{
//				1, 2, 3, 4, 5, 6, 7, 8, 9, 10
//			};
////LINQ Query using Mixed Syntax
//var MethodSyntax = (from obj in integerList
//					where obj > 5
//					select obj).Sum();
////Execution
//Console.Write("Sum Is : " + MethodSyntax);




//var r = new { name = "s", id = 4 };
//Console.WriteLine(r.id.GetType);



//List<string> d = new List<string>() { "qweds", "das" };
//var t=d.SelectMany(s=>s).ToList();
//foreach (var item in t)
//{
//    Console.Write(item+" ,");
}