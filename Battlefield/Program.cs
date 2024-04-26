using Battlefield;

List<Student> students = new();

int numStudents = -1;
while (numStudents <= 0)
{
  Console.WriteLine("How many students?");
  string numString = Console.ReadLine();
  bool success = int.TryParse(numString, out numStudents);
}

// Get type of student
Console.WriteLine("What kind of student? te/es/it");
string studentType = Console.ReadLine();

if (studentType == "te")
{
  for (int i = 0; i < numStudents; i++)
  {
    students.Add(new TeStudent());
  }
}
else if (studentType == "es")
{
  for (int i = 0; i < numStudents; i++)
  {
    students.Add(new EsStudent());
  }
}
else if (studentType == "it")
{
  for (int i = 0; i < numStudents; i++)
  {
    students.Add(new ItStudent());
  }
}
else
{
  Console.WriteLine("You didn't choose a valid student type!");
}

Console.ReadLine();