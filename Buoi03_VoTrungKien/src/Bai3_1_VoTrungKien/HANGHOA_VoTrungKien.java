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
public class HANGHOA_VoTrungKien {
        protected String MaHang;
	protected String TenHang;
	protected float Gia;
	
	public String getMaHang() {
		return MaHang;
	}
	public void setMaHang(String maHang) {
		MaHang = maHang;
	}
	public String getTenHang() {
		return TenHang;
	}
	public void setTenHang(String tenHang) {
		TenHang = tenHang;
	}
	public float getGia() {
		return Gia;
	}
	public void setGia(float gia) {
		Gia = gia;
	}
	
	public HANGHOA_VoTrungKien()
	{
		this.MaHang = null;
		this.TenHang = null;
		this.Gia = 0.0f;
	}
	
	public HANGHOA_VoTrungKien(String ma, String ten, float gia )
	{
		this.MaHang = ma;
		this.TenHang = ten;
		this.Gia = gia;
	}
        
        public HANGHOA_VoTrungKien(HANGHOA_VoTrungKien p )
        {
            this.MaHang = p.MaHang;
            this.TenHang = p.TenHang;
            this.Gia = p.Gia;
        }
	
	public void Nhap()
	{
		Scanner x = new Scanner ( System.in);
		System.out.print("\nNhap ma: ");
		this.MaHang = x.nextLine();
		System.out.print("\nNhap Ten: ");
		this.TenHang = x.nextLine();
		System.out.print("\nNhap Gia: ");
		this.Gia = x.nextFloat();
		
	}
	
	public void Xuat()
	{
		System.out.format(" %10s || %10s || %10.2f ||", getMaHang(), getTenHang(), getGia() );
	}
	
        public String toString()
        {
            return MaHang + " - " + TenHang + " - " + Gia;
        }
	
}
