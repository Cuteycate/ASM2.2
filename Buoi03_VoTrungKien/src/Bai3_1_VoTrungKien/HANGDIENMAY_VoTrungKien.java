/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Bai3_1_VoTrungKien;
import java.util.*;
/**
 *
 * @author Administrator
 */
public class HANGDIENMAY_VoTrungKien extends HANGHOA_VoTrungKien
{
    
	private String ThoiGian;
	private float Dnap;
	private float CS;
	
	public String getThoiGian() {
		return ThoiGian;
	}
	public void setThoiGian(String thoiGian) {
		ThoiGian = thoiGian;
	}
	public float getDnap() {
		return Dnap;
	}
	public void setDnap(float dnap) {
		Dnap = dnap;
	}
	public float getCS() {
		return CS;
	}
	public void setCS(float cS) {
		CS = cS;
	}
	
	public HANGDIENMAY_VoTrungKien()
	{
		super();
		this.ThoiGian = null;
		this.Dnap = 0.0f;
		this.CS = 0.0f;
	}
	
	public HANGDIENMAY_VoTrungKien(String ma, String ten , float gia, String Tg, float da, float cs )
	{
		super(ma,ten,gia);
		this.ThoiGian = Tg;
		this.Dnap = da;
		this.CS = cs;
	}
        
        public HANGDIENMAY_VoTrungKien( HANGDIENMAY_VoTrungKien p )
        {
            super(p);
            this.ThoiGian = p.ThoiGian;
            this.Dnap = p.Dnap;
            this.CS = p.CS;
        }
	
	
	public void Nhap()
	{
		super.Nhap();
		Scanner x = new Scanner(System.in);
		System.out.print("\nNhap thoi gian: ");
		this.ThoiGian = x.nextLine();
		System.out.print("\nNhap dien ap: ");
		this.Dnap = x.nextFloat();
		System.out.print("\nNhap Cong Suat: ");
		this.CS = x.nextFloat();
	}
	
	public void Xuat()
	{
		super.Xuat();
		System.out.format("%10s  ||   %10.2f   || %10.2f ",getThoiGian(),getDnap(),getCS() );
	}
	
	   public String toString()
        {
            return super.toString()+" - " + ThoiGian + " - " + Dnap + " - " + CS;
        }
}
