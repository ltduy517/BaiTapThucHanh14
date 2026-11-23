using System;
delegate void VuotNguongHandler(double nhietDo);
class CamBienNhietDo
{
    private const double Nguong = 35;
    public double NhietDo { get; private set; }
    public event VuotNguongHandler? SuKienVuotNguong;
    public void CapNhat(double t)
    {
        NhietDo = t;
        Console.WriteLine("Cap nhat nhiet do: " + t + " do C");

        if (t > Nguong)
        {
            SuKienVuotNguong?.Invoke(t);
        }
    }
}
class Program
{
    static void CanhBaoManHinh(double t)
    {
        Console.WriteLine("  [Man hinh] CANH BAO: nhiet do " + t + " do C vuot nguong!");
    }
    static void GhiNhatKy(double t)
    {
        Console.WriteLine("  [Nhat ky] Ghi nhan nhiet do cao: " + t + " do C");
    }
    static void Main()
    {
        CamBienNhietDo cb = new CamBienNhietDo();
        cb.SuKienVuotNguong += CanhBaoManHinh;
        cb.SuKienVuotNguong += GhiNhatKy;
        cb.CapNhat(30);
        cb.CapNhat(38);
        cb.SuKienVuotNguong -= GhiNhatKy;
        cb.CapNhat(40);
    }
}