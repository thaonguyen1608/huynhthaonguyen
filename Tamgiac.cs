using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Tamgiac
    {
        private double ma, mb, mc;

    public Tamgiac()
    {
        ma = mb = mc = 0;
    }

    public Tamgiac(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0 || (a + b <= c) || (a + c <= b) || (b + c <= a))
        {
            ma = mb = mc = 0;
        }
        else
        {
            ma = a;
            mb = b;
            mc = c;
        }
    }

    public double Ma
    {
        get { return ma; }
        set
        {
            if (value > 0 && value + mb > mc && value + mc > mb)
                ma = value;
        }
    }

    public double Mb
    {
        get { return mb; }
        set
        {
            if (value > 0 && value + ma > mc && value + mc > ma)
                mb = value;
        }
    }

    public double Mc
    {
        get { return mc; }
        set
        {
            if (value > 0 && value + ma > mb && value + mb > ma)
                mc = value;
        }
    }

    public double TinhChuVi()
    {
        return ma + mb + mc;
    }

    public double TinhDienTich()
    {
        double p = TinhChuVi() / 2;
        return Math.Sqrt(p * (p - ma) * (p - mb) * (p - mc));
    }

    public string KieuTamGiac()
    {
        if (ma == mb && mb == mc)
            return "Tam giác đều";
        else if (ma == mb || mb == mc || ma == mc)
            return "Tam giác cân";
        else if (ma != mb && mb != mc && ma != mc)
            return "Tam giác thường";
        else
            return "Không phải tam giác";
    }

    public override string ToString()
    {
        return ("Thông tin 3 cạnh: {ma}, {mb}, {mc}\nKiểu tam giác: {KieuTamGiac()}\nChu vi: {TinhChuVi()}\nDiện tích: {TinhDienTich()}");
    }
}

    
}

