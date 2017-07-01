using UnityEngine;
using System.Collections;

public class scri : MonoBehaviour {

	private Vector3[] point;
	private int hight;
	private Vector3[] returnValue;
	float t_min = 0;
	float t_max = 1;
	// Use this for initialization
	
	private Vector3 Calculation(float t){
		int h = hight;
		int temph;
		int tempn;
		int n = 0;
		int hn = 0;
		float blend = 0, muk = 0, smuk = 0;
		
		Vector3 localPoint = new Vector3();
		muk = 1;
		smuk = Mathf.Pow (1 - t, (float)(h));
		for (int cnt=0; cnt<=h; cnt++) {
			temph=h;
			tempn=cnt;
			n = cnt;
			hn = h - n;
			blend = muk * smuk;
			muk *= t;
			smuk /= (1 - t);
			while (temph>=1) {
				blend *= temph;
				temph--;
				if (tempn >= 1) {
					blend /= (float)tempn;
					tempn--;
				}
				if (hn > 1) {
					blend /= (float)hn;
					hn--;
				}
			}
			localPoint.x += this.point[cnt].x * blend;
			localPoint.y += this.point[cnt].y * blend;
			localPoint.z += this.point[cnt].z * blend;
			
		}
		return localPoint;
	}
	
	private int[] Pascal(){
		int[][] p = new int[hight][];
		
		for (int cnt1=0; cnt1<=this.hight; cnt1++) {
			p[cnt1]=new int[cnt1+1];
			for(int cnt2=0;cnt2<p[cnt1].Length;cnt2++){
			p[cnt1][cnt2]=cnt1>0&&cnt2>0&&cnt1>cnt2?p[cnt1-1][cnt2]+p[cnt1-1][cnt2-1]:1;
			}
		}
		return p[hight];
	}
	public Vector3[] Return(Vector3[] point){
		Set (point);
		returnValue = new Vector3[200];
		int cnt = 0;
		for (float t=0; t<1-0.005f; t+=0.005f) {
			returnValue[cnt]=Calculation (t);
			cnt++;
		}
		return returnValue;
	}
	private void Set(Vector3[] point){
		this.point = point;
		this.hight = point.Length - 1;
	}
	private void init(){
		this.point = null;
		this.hight = 0;
	}
}



/*
 private void Calculation(){
 int h = hight;
 int n = 0;
 int hn = 0;
 float blend=0, muk=0, smuk=0;
 float t_min = 0;
 float t_max = 1;
 float t = t_min;

 muk = 1;
 smuk = Mathf.Pow (1 - t, (float)(h));
 for (int cnt=0; cnt<=h; cnt++) {
 n=cnt;
 hn=h-n;
 blend=muk*smuk;
 t*=t;
 smuk/=(1-t);
 while(h>=1){
 blend*=h;
 h--;
 if(n>=1){
 blend/=(float)n;
 n--;
 }
 if(hn>1){
 blend/=(float)hn;
 hn--;
 }
 }
 localPoint[cnt].x+=localPoint[cnt].x*blend;
 localPoint[cnt].y+=localPoint[cnt].xblend;
 localPoint[cnt].z+=blend;
 }
 }
 }
*/