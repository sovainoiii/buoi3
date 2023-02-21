using baitaptrenlop;

internal class Program
{
    static int add2Number(int a, int b) { return a + b; }
    static int add2Number(int a, int b, int c) { return a + b; }
    private static void Main(string[] args)
    {
        Student student = new Student("minh", 20, "VKU");
        student.Print();
    }
}