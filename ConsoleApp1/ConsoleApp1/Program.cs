#region HomeWorkMethod

//Console.WriteLine(MaxValue(-8, -1, -7, -4, -3, -5, -6, -8, -9, -4, -5));

//int MaxValue(params int[] arr)
//{
//	int Max = arr[0];
//	foreach (int number in arr)
//	{
//		if (number > Max)
//		{
//			Max = number;
//		}
//	}
//	return Max;
//}

//int[] arr = { 1, 6, 3, 7, 3, 4 };
//int num = 7;

//bool result = Search(arr, num);

//Console.WriteLine(result);

//bool Search(int[] arr, int num)
//{
//	foreach (int number in arr)
//	{
//		if (number == num)
//		{
//			return true;
//		}
//	}
//	return false;
//}



//void Search(int[] arr, int num)
//{
//	foreach (var item in arr)
//	{
//		if (item == num)
//		{
//			Console.WriteLine("Var");
//			return;
//		}
//	}
//	Console.WriteLine("Yox");
//}




//void Search(int[] arr, int num)
//{
//	bool status = false;
//	foreach (var item in arr)
//	{
//		if (item == num)
//		{
//			status = true;
//			break;
//		}
//	}
//	if (status)
//	{
//		Console.WriteLine("Var");
//	}
//	else
//	{
//		Console.WriteLine("Yox");
//	}

//}


#endregion

#region Value Type
//int a = 5;

//int b = a;
//b = 7;

//Console.WriteLine(a);
//Console.WriteLine(b);
#endregion

#region Referance Type

//int[] arr = { 1, 5, 9 };

//int[] arr2 = arr;

//arr2[0] = 99;


//Console.WriteLine(arr[0]);
//Console.WriteLine(arr2[0]);

//int[] arr = { 1, 4, 2, 7, };


//Change(arr);
//Console.WriteLine(arr[0]);

//void Change(int[] arr)
//{
//    arr[0] = 3;
//}
#endregion

#region ref out
//int num=10;

//Change( num);

//Console.WriteLine(num);

//void Change( int num)
//{
//    num = 55;
//    //num = 44;
//}
#endregion

//string name = "Isa";

//Change(name);

//Console.WriteLine(name);

//void Change(string data)
//{
//    data = "Test";
//}

//int[] arr = { 1, 3, 5 };

//int[] arr2 = { 1, 3, 5 };

//string name = "Isa";

//string name2 = "Isa";

//int num = 10;  //stack(num=10)

//int num2 = num;    //stack(num2=10)

//num2 = 20;           //stack(num2=20)


//int[] arr = { 1, 3, 5 };  // (heap--aa1)

//int[] arr2 = { 1, 3, 5 };  // (heap--aa2)

//int[] arr3 = arr;   // (heap--aa1)

//arr3[0] = 9;

//string name = "Samir"; //--09
////gedib baxacaq string poolda samir yoxdusa yaradacaq vardisa var olani istifade edecek

//string name2 = "Samir";  //--09

//string name3 = "test";  //--10

//string name4 = name3;  //--10
//name4 = "Faxri";  //--11

//int[] num = { 199,30,67 };

//Console.WriteLine(num[0]);

//string Name = "Hacar";

//foreach (var item in Name)
//{
//    Console.WriteLine(item);
//}

//string numstr = "10";

//int.TryParse(numstr, out int num);

//Console.WriteLine(num);

//long num = Convert.ToInt64(numstr);

//string sentence = "Hello World P136";

//sentence.Trim();

//Console.WriteLine(sentence.Length);
//var result=sentence.Reverse().ToArray();

//Console.WriteLine(result);

//char[] arr=sentence.ToCharArray();

//arr[0] = 'a';

//string sentence = "Hello World P136";

//string[] strings=sentence.Split(' ');

////string[] arr = { "Hello", "World", "P136" };
//foreach (var item in strings)
//{
//    Console.WriteLine(item);
//}


//olleH dlroW 631P


string sentence = Console.ReadLine();
string[] arr = sentence.Split(' ');

string result = string.Empty;
foreach (string item in arr)
{
	for (int i = item.Length - 1; i >= 0; i--)
	{
		result += item[i];
	}
	result += " ";
}

Console.WriteLine(result);
//olleH dlroW 631P 



//string Data = "Hello World";

//for (int i = Data.Length-1; i >=0; i--)
//{
//    Console.Write(Data[i]);
//}
