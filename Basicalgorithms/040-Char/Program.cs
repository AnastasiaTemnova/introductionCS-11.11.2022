using System.Linq;

char c='a';
c='\x0064';
c='\u0064';
char b='a';
System.Console.WriteLine((int)b);
System.Console.WriteLine(c.ToString()+b.ToString());
if (b>='0' && b<='9') System.Console.WriteLine("It's digit");
if (b>='A' && b<='Z') System.Console.WriteLine("It's big Latin");
if (b>='a' && b<='z' || b>='A' && b<='Z') System.Console.WriteLine("It's big Latin");

if (Char.IsDigit(b)) System.Console.WriteLine("It's digit"); 


string s="asdf";
//immutable string (неизменяемые строки);
System.Console.WriteLine(s[0]);
for(int i=0;i<s.Length;i++)
System.Console.WriteLine(s[i]);
//s[0]='S';
char[] cc=s.ToCharArray();
cc[0]='S';
s=new String(cc);

System.Text.StringBuilder sb=new System.Text.StringBuilder("asda");
sb[0]='s';

s=sb.ToString();

//for (int i=0;i<100000;i++);
//s=s+"1";//создает новую строку
for (int i=0;i<1000000;i++);
sb.Append("1");

string s1="Hello";
string s2="Hello";
System.Console.WriteLine(s1==s2);
System.Console.WriteLine(s1.CompareTo(s2));
System.Console.WriteLine(string.Compare(s1,2,s2,3,4,true));

//s1.Length
s2=s1.Substring(2,4);
System.Console.WriteLine(s1.IndexOf("as"));
s1=s1.Replace("ab","ba");

Random random1=new Random(100);
Random random2=new Random(100);
random2=random1;
System.Console.WriteLine(random1==random2);