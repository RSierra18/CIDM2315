namespace Homework9;

class Student
{
    private int studentID;
    private string studentName;

    public int StudentID
    {
        get { return studentID; }
    }
    public string StudentName
    {
        get { return studentName; }
    }

    public static List<Student> studentList = new List<Student>();

    public Student()
    {
        studentID = 0;
        studentName = "Unknown";
        studentList.Add(this);
    }

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(111, "Alice");
        Student s2 = new Student(222, "Bob");
        Student s3 = new Student(333, "Cathy");
        Student s4 = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>();


        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        if (gradebook.ContainsKey("Tom") == false)
        {
            gradebook.Add("Tom", 3.3);
        }

        double sum = 0;
        int count = 0;
        foreach (double gpa in gradebook.Values)
        {
            sum += gpa;
            count++;
        }
        double averageGpa = sum / count;
        Console.WriteLine("The average GPA: " + averageGpa.ToString("F2"));

        foreach (Student s in Student.studentList)
        {
            string name = s.StudentName;

            if (gradebook.ContainsKey(name))
            {
                double gpa = gradebook[name];

                if (gpa > averageGpa)
                {
                    s.PrintInfo();
                }
            }
        }
            

        
    }
}


