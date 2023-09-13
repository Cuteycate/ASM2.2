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
public class HANGTHUCPHAM_VoTrungKien extends HANGHOA_VoTrungKien
{
    private String ngaysx;
	private String ngaybh;
	public String getNgaysx() {
		return ngaysx;
	}
	public void setNgaysx(String ngaysx) {
		this.ngaysx = ngaysx;
	}
	public String getNgaybh() {
		return ngaybh;
	}
	public void setNgaybh(String ngaybh) {
		this.ngaybh = ngaybh;
	}
	
	public HANGTHUCPHAM_VoTrungKien()
	{
		super();
		this.ngaysx = null;
		this.ngaybh = null;
	}
	
	public HANGTHUCPHAM_VoTrungKien( String ma, String ten, float gia, String sx,String bh )
	{
		super(ma,ten, gia );
		this.ngaysx = sx;
		this.ngaybh = bh;
	}
        
        public HANGTHUCPHAM_VoTrungKien( HANGTHUCPHAM_VoTrungKien p )
        {
            super(p);
            this.ngaysx = p.ngaysx;
            this.ngaybh = p.ngaybh;
        }
	
	
	public void Nhap()
	{
		super.Nhap();
		Scanner x = new Scanner (System.in);
		System.out.print("\nNhap ngay sx: ");
		this.ngaysx = x.nextLine();
		System.out.print("\nNhap ngay bh: ");
		this.ngaybh = x.nextLine();
	}
	
	
	public void Xuat()
	{
		super.Xuat();
		System.out.format("%10s || %10s ||", getNgaysx(),getNgaybh() );
	}
        
           public String toString()
        {
            return super.toString()+ " - " + ngaysx + " - " + ngaybh ;
        }

}
