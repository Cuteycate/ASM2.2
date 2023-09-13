/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Bai3_1_VoTrungKien;
import java.util.*;
import java.util.ArrayList;
import java.util.Comparator;

/**
 *
 * @author Administrator
 */
public class DSHANGHOA_VoTrungKien {
    private ArrayList<HANGHOA_VoTrungKien> ListHH;
    static int n = 0;
    
    public DSHANGHOA_VoTrungKien()
    {
        n = 0;
        ListHH = new ArrayList<HANGHOA_VoTrungKien>();
    }
    
    public void ThemMH ( HANGHOA_VoTrungKien h )
    {
        ListHH.add(h);
        n++;
    }
    
    public void xuatDSTheoLoai(byte Loai)
    {
        System.out.println("\nCac mat hang theo loai "+Loai+"la: ");
        for ( HANGHOA_VoTrungKien h : ListHH )
        {
            if ( h instanceof HANGDIENMAY_VoTrungKien && Loai == 1 )
                h.Xuat();
            else 
                if ( h instanceof HANGTHUCPHAM_VoTrungKien && Loai == 2)
                    h.Xuat();
        }
    }
    
    
      
    public void xuatDS()
    {
        System.out.println("\nDs cac mat hang la:");
        for ( HANGHOA_VoTrungKien h : ListHH )
        {
          System.out.println(h);
          
        }
    }
    
//     public static Comparator<HANGHOA_VoTrungKien> compare = new Comparator<HANGHOA_VoTrungKien>() 
//     {
//        Collections.sort(ListHH, HANGHOA_VoTrungKien.compare);
//        @Override
//        public int compare( HANGHOA_VoTrungKien o1, HANGHOA_VoTrungKien o2) 
//        {
//             return o1.Gia.compareTo(o2.Gia);
//        }
//     };
     
     
     
     public void sapXepTheoGiaTangDan() {
        Collections.sort(ListHH, new Comparator<HANGHOA_VoTrungKien>()
        {
            public int compare(HANGHOA_VoTrungKien h1, HANGHOA_VoTrungKien h2)
            {
                if (h1.getGia() < h2.getGia()) 
                {
                    return -1;
                } 
                else 
                    if (h1.getGia() > h2.getGia()) 
                    {
                    return 1;
                    }
                return 0;
            }
        });
    }
     
    public Float TinhTongGia()
    {
        float Tong = 0;
        for ( HANGHOA_VoTrungKien h : ListHH)
        {
            if ( h instanceof HANGTHUCPHAM_VoTrungKien )
                Tong = Tong + h.Gia;
        }
        return Tong;
    }
    
    public int SoLuongDienMay()
    {
        int count = 0;
        for ( HANGHOA_VoTrungKien h : ListHH)
        {
            if ( h instanceof HANGDIENMAY_VoTrungKien)
                count++;
        }
        return count;
    }
    
    
}
