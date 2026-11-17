#region Q1
using System.Text;

string title = "clean code";
string upperTitle = title.ToUpper();
Console.WriteLine(title);
Console.WriteLine(upperTitle);
#endregion

Console.WriteLine("--------------------------");

#region Q2
string s01 = "Clean Code";
string s02 = "Clean Code";
Console.WriteLine(ReferenceEquals(s01,s02)); //true
#endregion

Console.WriteLine("--------------------------");

#region Q3
StringBuilder sb = new StringBuilder();
sb.Append("Book List");
sb.Append(" - Updated");
Console.WriteLine(sb);
#endregion

Console.WriteLine("--------------------------");

#region Q4
sb.Replace("Book List", "Library");
Console.WriteLine(sb);
#endregion

Console.WriteLine("--------------------------");

#region Q5
string titlee = "Clean Code";
int pages = 464;
Console.WriteLine("Book: " + titlee + ", Pages: " + pages);
#endregion

Console.WriteLine("--------------------------");

#region Q6
Console.WriteLine($"Book: {titlee}, Pages: {pages}");
#endregion

Console.WriteLine("--------------------------");

#region Q7
string msg = string.Format("Book: {0}, Pages: {1}", titlee, pages);
Console.WriteLine(msg);
#endregion

Console.WriteLine("--------------------------");

#region Q8
if (pages > 300)
    Console.WriteLine("Long Book");
else
    Console.WriteLine("Short Book");
#endregion

Console.WriteLine("--------------------------");

#region Q9
bool isAvailable = true;
if(pages > 300 && isAvailable == true)
    Console.WriteLine("You can borrow this book");
#endregion

Console.WriteLine("--------------------------");

#region Q10
string titleSwitch = "Refactoring";
switch(titleSwitch)
{
    case "Clean Code":
        Console.WriteLine("Great choice!");
        break;
    case "Refactoring":
        Console.WriteLine("Nice pick!");
        break;
    default:
        Console.WriteLine("Never heared of it");
        break;
}
#endregion

Console.WriteLine("--------------------------");

#region Q11
string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
Console.WriteLine(sizeLabel);
#endregion

Console.WriteLine("--------------------------");

#region Q12
string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
for(int i  = 0; i < books.Length; i++)
{
    Console.WriteLine($"{i+1}. {books[i]}");
}
#endregion

Console.WriteLine("--------------------------");

#region Q13
int count = 0;
while (count < books.Length)
{
    Console.WriteLine($"{count + 1}. {books[count]}");
    count++;
}
#endregion

Console.WriteLine("--------------------------");

#region Q14
int countBooks = 0;
do
{
    Console.WriteLine($"Checking book {books[countBooks]}");
    countBooks++;
}
while (countBooks < books.Length);
#endregion

Console.WriteLine("--------------------------");

#region Q15
foreach (string book in books)
{
    Console.WriteLine(book);
}
#endregion

Console.WriteLine("--------------------------");

#region Q16
for (int i = 0; i<books.Length; i++)
{
    if (books[i] == "Refactoring")
        break;
    else
        Console.WriteLine(books[i]);
}
#endregion

Console.WriteLine("--------------------------");

#region Q17
for (int i = 0; i < books.Length; i++)
{
    if (books[i] == "The Pragmatic Programmer")
        continue;
    else
        Console.WriteLine(books[i]);
}
#endregion

Console.WriteLine("--------------------------");

#region Session Task
//Input student information
Console.WriteLine("Enter the student's name");
string studentName = Console.ReadLine();
Console.WriteLine("Enter the student's age");
int studentAge = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the student's grades");
int grade01 = int.Parse(Console.ReadLine());
int grade02 = int.Parse(Console.ReadLine());
int grade03 = int.Parse(Console.ReadLine());

// Calculte the total andd average of grades
int totalGrades = grade01 + grade02 +grade03;
double averageGrades = totalGrades / 3.00;

//Determine student's status
string status = "";
if (averageGrades >= 50)
    status = "Passed";
else
    status = "Failed";

// Determine age category
string ageCategory = "";
if (studentAge >= 18)
    ageCategory = "Adult";
else
    ageCategory = "Minor";

// Print the outputs
Console.WriteLine($"Student Name: {studentName} \nAge: {studentAge} ({ageCategory}) \n \nTotal Grades: {totalGrades} \nAverage: {averageGrades.ToString("0.00")} \n \nStatus: {status}");
#endregion