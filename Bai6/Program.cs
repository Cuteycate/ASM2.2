using Bai6;
using System;
using System.Collections.Generic;

class Program
{
    private static object bienSoList;
    private static List<LayBienSoDep> biensoDepList;
    private static object bienso;

    static string Main()

    {
        List<biensoList> biensoLists = new List<biensoList>();
        {
            "29A-12345";
            "51C-67890";
            "43D-98765";
            "12E-54321";
        }

        List<bienSoDepList> bienSoDepLists = LayBienSoDep(bienSoList);

        Console.WriteLine("Danh sách các biển số đẹp:");
        foreach (string bienSo in bienSoDepList)
        {
            Console.WriteLine(bienSo);
        }
    }

    private static List<bienSoDepList> LayBienSoDep(object bienSoList)
    {
        
    }

    static 
        List<LayBienSoDep> LayBienSoDeps(List<danhSachBienSo> danhSachBienSos)
    {
        List <bienSoDepList>bienSoDepLists = new List<bienSoDepList> ();

        foreach (string bienSo in danhSachBienSo)
        {
            if (KiemTraBienSoDep(bienSo))
                NewMethod();
        }

        return biensoDepList;
    }

    private static void NewMethod()
    {
        bienSoDepList.Add(bienso);
    }

    private static bool KiemTraBienSoDep(string bienSo)
    {
        throw new NotImplementedException();
    }

    static bool KiemTraBiensoDep(string bienso)
    {

        if (bienso.Contains("A"))
        {
            return true;
        }

        return false;
    }
}