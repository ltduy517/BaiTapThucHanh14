using System;
delegate void XuLyKetQua(string ten, double diem);
class Program
{
    static void InKetQua(string ten, double diem)
    {
        Console.WriteLine(ten + ": " + diem);
    }
    static void CanhBao(string ten, double diem)
    {
        if (diem < 5)
        {
            Console.WriteLine("Can cai thien");
        }
        else
        {
            Console.WriteLine("Dat");
        }
    }
    static void Main()
    {
        XuLyKetQua? xl = InKetQua;
        xl += CanhBao;
        xl?.Invoke("Duy", 10  );
        Console.WriteLine();
        xl -= CanhBao;
        xl?.Invoke("duy",10);
    }
}