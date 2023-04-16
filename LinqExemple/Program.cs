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
////var t=d.SelectMany(s=>s).ToList();
////foreach (var item in t)
////{
////    Console.Write(item+" ,");
////}
//var r = from items in d
//		from item in items
//		select item.ToString();
//foreach (var item in r) Console.Write(item+" , ");


//var e=(from f in d
//	  from item in f
//	  where item == 'd'
//	  select item).ToList();

//foreach (var item in e) Console.WriteLine(item);


//List<object> list = new List<object>()
//{ "dsddd",1,true,'q'};
//var re = list.OfType<bool>().ToList();


//var r=from d in list
//	  where  d is bool 
//	  select d;
//foreach (var item in r) Console.Write(item + "  ");



//List<int> ints=new() { 1, 2, 23, 2, 1, 3, 32, 1, 2, 1, 2, 1 };
//var r=ints.Distinct().ToList();
//d(r);


void d(List<int> list)
{
	foreach(var e in list) Console.Write(e + "  ");
}
void dd(List<string> list)
{
	foreach(var e in list) Console.Write(e + "  ");
}


//////////////////////
///


//List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
//List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };
////Method Syntax
//var MS = dataSource2.Except(dataSource1).ToList();

//d(MS);


//List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
//List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };
////Method Syntax
//var MS = dataSource1.Intersect(dataSource2).ToList();

//d(MS);


//List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
//List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };
////Method Syntax
//var MS = dataSource1.Union(dataSource2).ToList();

//d(MS);

//List<int> sequence1 = new List<int> { 1, 2, 3, 4 };
//List<int> sequence2 = new List<int> { 2, 4, 6, 8 };
////Method Syntax
//var MS = sequence1.Concat(sequence2).ToList();
//d(MS);

//var MS = Student.GetAllStudents()
//						  .OrderBy(x => x.FirstName)
//						 .ThenBy(y => y.LastName)
//						  .ToList();
//foreach (var student in MS)
//{
//	Console.WriteLine("First Name :" + student.FirstName + ", Last Name : " + student.LastName);
//}


//public class Student
//{
//	public int ID { get; set; }
//	public string FirstName { get; set; }
//	public string LastName { get; set; }
//	public string Branch { get; set; }
//	public static List<Student> GetAllStudents()
//	{
//		List<Student> listStudents = new List<Student>()
//			{
//				new Student{ID= 101,FirstName = "Preety",LastName = "Tiwary",Branch = "CSE"},
//				new Student{ID= 102,FirstName = "Preety",LastName = "Agrawal",Branch = "ETC"},
//				new Student{ID= 103,FirstName = "Priyanka",LastName = "Dewangan",Branch = "ETC"},
//				new Student{ID= 104,FirstName = "Hina",LastName = "Sharma",Branch = "ETC"},
//				new Student{ID= 105,FirstName = "Anugrag",LastName = "Mohanty",Branch = "CSE"},
//				new Student{ID= 106,FirstName = "Anurag",LastName = "Sharma",Branch = "CSE"},
//				new Student{ID= 107,FirstName = "Pranaya",LastName = "Kumar",Branch = "CSE"},
//				new Student{ID= 108,FirstName = "Manoj",LastName = "Kumar",Branch = "ETC"},
//				new Student{ID= 109,FirstName = "Pranaya",LastName = "Rout",Branch = "ETC"},
//				new Student{ID= 110,FirstName = "Saurav",LastName = "Rout",Branch = "CSE"}
//			};
//		return listStudents;
//	}
//}





//int[] intArray = new int[] { 10, 30, 50, 40, 60, 20, 70, 100 };
//Console.WriteLine("Before Reverse the Data");
//foreach (var number in intArray)
//{
//	Console.Write(number + " ");
//}
//Console.WriteLine();
//IEnumerable<int> ArrayReversedData = intArray.Reverse();
//Console.WriteLine("After Reverse the Data");
//foreach (var number in ArrayReversedData)
//{
//	Console.Write(number + " ");
//}


//List<int> r = new() { 1, 2, 8, 4, 5 };

//var t = r.Average();
//Console.WriteLine(t);char[]
//List<char> r = new List<char>() { 'q', 'e', 'r', 'n','f' };



//List<string> list = new List<string>() { "C#", "Java", "Flutter", "Phyton" };

//string r = list.Aggregate((s1, s2) => s1 + ", " + s2);
//Console.WriteLine(r);


//List<int> s = new() { 1, 2, 3, 2, 2 };
//var r=s.Aggregate((s, s2) => s * s2);
//Console.WriteLine(r);


List<int> ints = new List<int>() { 3, 4, 5, 6, 7, 8, 9 };
bool r = ints.Any(x => x == 3);
Console.WriteLine(r);