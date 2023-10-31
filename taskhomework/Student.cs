using System.Text.RegularExpressions;

namespace taskhomework;
internal class Student
{
    private static int _id = 1;
    private string _fullname;
    private string _groupNo;
    private int _age;
    public int ID { get;}
    public string Fullname
    {
        get => _fullname;
        set
        {
            if (!String.IsNullOrWhiteSpace(value) && CheckFullname(value))
            {
                _fullname = value;
            }
            else
            {
                Console.WriteLine("Wrong Fullname! \nEnter Fullname:");
                Fullname = Console.ReadLine();
            }
        }
    }
    public string GroupNo
    {
        get => _groupNo;
        set
        {
            if (!String.IsNullOrWhiteSpace(value) && CheckGroupNo(value))
            {
                _groupNo = value;
            }
            else
            {
                Console.WriteLine("Wrong GroupNo! \nEnter Group No:");
                GroupNo = Console.ReadLine();
            }
        }
    }
    public int Age 
    { 
        get => _age;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Age can't be negative! \nEnter Age:");
                Age = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                _age = value;
            }
        } 
    }

    public Student(string fullname, string groupNo, int age)
    {
        ID = _id;
        _id++;
        Fullname = fullname;
        GroupNo = groupNo;
        Age = age;
    }

    public static bool CheckGroupNo(string groupNo)
    {
        if (groupNo.Length == 4)
        {
            string contains3digits = groupNo.Substring(1);
            bool has3digits = int.TryParse(contains3digits, out int result);
            if ((groupNo[0] >= 65 && groupNo[0] <= 90) && has3digits)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    } 

    public static bool CheckFullname (string fullname)
    {   
        fullname = fullname.Trim().ToLower();
        bool containsSpace = fullname.Contains(' ');
        if (containsSpace)
        {
            int spaceIndex = fullname.IndexOf(' ');
            string Name = Char.ToUpper(fullname[0]) + fullname.Substring(1, spaceIndex);
            string Surname = Char.ToUpper(fullname[spaceIndex+1]) + fullname.Substring(spaceIndex+2);
            Console.WriteLine(Name + Surname);
            return true;
        }
        return false;
    }
}
