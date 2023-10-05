using System;
using System.Globalization;
/*//-------------------------------------------------- STRINGS PRACTICE ----------------------------------------------------------------
// string pool
/0==null
string s1 || string s2=null;
string s3="";
string s1 = "Hello";
string s2 = "Hello";
char[] c1 = { 'H', 'e', 'l', 'l', 'o' };
string s3= new string(c1);
char[] c2 = { 'H', 'e' };
string s4 = new string(c2);
char[] c3 = { 'l', 'l', 'o' };
string s5 = new string(c3);
string s6 = "He";
string s7 = "llo";
Console.WriteLine($"s1 : {s1}");
Console.WriteLine($"s1 : {s2}");
Console.WriteLine($"s1 : {s3}");
Console.WriteLine($"s1 : {s4}");
Console.WriteLine($"s1 : {s5}");
Console.WriteLine($"s1 : {s6}");
Console.WriteLine($"s1 : {s7}");
Console.WriteLine(Object.ReferenceEquals(s1, s2));
Console.WriteLine(Object.ReferenceEquals(s1, s3));
Console.WriteLine(Object.ReferenceEquals(s2, s3));
Console.WriteLine(Object.ReferenceEquals(s1, s4+s5));
Console.WriteLine(Object.ReferenceEquals(s1, s6+s7));
Console.WriteLine(Object.ReferenceEquals(s3, s4+s5));
Console.WriteLine(Object.ReferenceEquals(s3, s6+s7));
Console.WriteLine(Object.ReferenceEquals(s4+s5, s6+s7));
                                            
                                          // string functions
Console.WriteLine("\nUPPERCASE STRING : "+s1.ToUpper());
Console.WriteLine("LOWERCASE STRING : "+s1.ToLower());
Console.WriteLine("Index of O in hello : " + s1.IndexOf('O'));
Console.WriteLine("Index of o in hello : " + s1.IndexOf('o'));
Console.WriteLine("Substring from 0 to 2 in hello : " + s1.Substring(0, 3));
string temp = " TEMPORARY STRING ";
Console.WriteLine("NORMAL STRING WITHOUT TRIM : " + temp);
Console.WriteLine("NORMAL STRING WITH TRIM : " + temp.Trim());
Console.WriteLine("Check whether temp contains string : " + temp.Contains("string"));
Console.WriteLine("Check whether temp contains string : " + temp.Contains("STRING"));
Console.WriteLine("Check if temp begins with be : " + temp.StartsWith("be"));
Console.WriteLine("Check if temp begins with Te : " + temp.StartsWith("TE"));
Console.Write(" String to char array of temp : ");
char[] chars = temp.ToCharArray();
foreach(char c in chars)
    Console.WriteLine(c);
string r = "Ritika Narang";
Console.WriteLine("splitting string into array of strings : ");
string[] arrofst = r.Split(" ");
foreach(string s in arrofst)
Console.WriteLine(s);
Console.WriteLine("Length of string r is :" + r.Length);
Console.WriteLine("Inserting r at 0 in r : " + r.Insert(0,"r"));
Console.WriteLine("Replacing r with K in r : " +  (r.Replace('R','r')));
Console.WriteLine("Removing K in r : " + r.Remove(5,7));
Console.WriteLine("Type of r is : " + r.GetType());
Console.WriteLine("Type of r is : " + r.GetTypeCode());
string q1 = "ritika";
string q2 = "RITIKA";
Console.WriteLine(q1.Equals(q2));
Console.WriteLine(q1.CompareTo(q2));

//---------------------------------------------- array functions --------------------------------------------------------------------- 

var arr = new int[4] { 1, 2, 3, 4 };
Console.WriteLine("\nLength of array is : " + arr.Length);
Console.WriteLine("Clear array : ");
Array.Clear(arr, 0, 3);
foreach(var i in arr)
    Console.Write(i);
Array.Reverse(arr);
Console.Write("\n");
for (int i=0;i<arr.Length;i++)
    Console.Write(arr[i]);
Array.Sort(arr);
Console.Write("\n");
for (int i = 0;i<arr.Length;i++)
    Console.Write(arr[i]);
int[] another=new int[3];
Array.Copy(another,arr, 3);
Console.Write("\n"+another);

//------------------------------------------------ Lists -----------------------------------------------------------------------------
var list = new List<int>() {1,2,3,4};
list.Add(1);
list.AddRange(new List<int>() { 5, 6, 7, 8 });
Console.WriteLine();
Console.Write("\nList elements are : ");
foreach(var i in list)
    Console.Write(i);
Console.WriteLine("\nLast element of list is : " + list[list.Count-1]);
Console.WriteLine("Index of 1 in list is : " + list.IndexOf(1));
Console.WriteLine("Last index of 1 in list is :" + list.LastIndexOf(1));
Console.WriteLine("Remove 1 from list : " + list.Remove(1));
Console.WriteLine("check whether ist contains number 1 : " + list.Contains(1));
Console.Write("Remove all 1 from list : ");
for (int i=0;i<list.Count;i++)
{
    if (list[i] == 1)
        list.Remove(list[i]);
    else
        Console.Write(list[i]);
}
Console.WriteLine("\ncheck whether ist contains number 1 : " + list.Contains(1));
Console.Write("\n");
*/
//---------------------------------------- EXERCISES ---------------------------------------------------------------------
// QUES 1
//var li = new List<string>();
//while(true)
//{
//    Console.Write("Enter Name : ");
//    var input = Console.ReadLine();
//    if (String.IsNullOrWhiteSpace(input))
//        break;
//    li.Add(input);
//}

//if (li.Count == 1)
//    Console.WriteLine("{0} liked your post." , li[0]);
//else if (li.Count == 2)
//    Console.WriteLine("{0}, {1} liked your post." , li[0], li[1]);
//else
//{
//    int size=li.Count-2;
//    Console.WriteLine("{0}, {1} and {2} liked your post." , li[0], li[1], size);
//}

//QUES 2
Console.Write("Enter Name : ");
var str= Console.ReadLine();
char[] arr = new char[str.Length];
for(int i=0; i<str.Length; i++)
{
    arr[i] = str[i];
}
int start = 0;
int end = arr.Length - 1;
while (start < end)
{
    char temp = arr[start];
    arr[start] = arr[end];
    arr[end] = temp;
    start++;
    end--;
}
string revStr = new string(arr);
Console.WriteLine(revStr);

//Question 3

