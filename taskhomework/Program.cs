using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace taskhomework;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Fullname: ");
        string fullname = Console.ReadLine();
        Console.WriteLine("Enter GroupNo: ");
        string groupno = Console.ReadLine();
        Console.WriteLine("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Student student = new Student(fullname, groupno, age);
    }
}