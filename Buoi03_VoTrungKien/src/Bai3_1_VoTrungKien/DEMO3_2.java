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
public class DEMO3_2 {
    public static void main(String[] args)
	{
		byte chon;
		Scanner doc = new Scanner (System.in);
		DSHANGHOA_VoTrungKien dshh = new DSHANGHOA_VoTrungKien();
		HANGHOA_VoTrungKien h;
		do{
			System.out.println("\n1.Them mot mat hang vao danh sach.");
			System.out.println("\n2.Xuat mat hang theo loai.");
                        System.out.println("\n3.Sap Xep Tang Dan Theo Gia.");
                        System.out.println("\n4.Tinh Tong Gia Hang Thuc Pham.");
                        System.out.println("\n5.Tinh So Luong Hang Dien May");
                        System.out.println("\n6.Xuat Danh Sach.");
			System.out.println("\n0.Thoat.");
			System.out.println("\nChon chuc nang: "); 
			chon = doc.nextByte();
			switch(chon)
			{
				case 1: 
                                        System.out.println("\n************************");
					System.out.println("\n1.Hang Dien May ");
					System.out.println("\n2.Hang Thuc Pham ");
					System.out.println("\nHay chon mat hang ");
					byte Loai = doc.nextByte();
					if ( Loai == 1)
						h = new HANGDIENMAY_VoTrungKien();
					else 
						h = new HANGTHUCPHAM_VoTrungKien();
						h.Nhap();
						dshh.ThemMH(h);
						break;
				case 2:
					System.out.println("\nXuat danh sach mat hang DM/TP");
					byte Loaimh = doc.nextByte();
					dshh.xuatDSTheoLoai(Loaimh);
					break;
                                case 3:
                                        System.out.println("Sap Xep Danh Sach tang dan theo gia");                                     
                                        dshh.sapXepTheoGiaTangDan();
                                        break;
                                case 4: 
                                        System.out.println("Tong gia cua Hang Thuc Pham la: " + dshh.TinhTongGia());
                                        break;
                                case 5: 
                                        System.out.println(" so luong hang dien may la:  "+dshh.SoLuongDienMay());
                                        break;
                                case 6:
                                        dshh.xuatDS();
                                        break;
				default: chon = 0;break;
					
						
			}
		}while(chon != 0);
	}
}
