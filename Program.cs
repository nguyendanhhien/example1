//nhap mot so tu ban phim va hien ra man hinh
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("nhap ban kinh hinh tron:");
        double r = Convert.ToDouble(Console.ReadLine());
        double s = Math.PI * r * r;
        Console.WriteLine("Dien tich hinh tron la:" + s);
    }
}