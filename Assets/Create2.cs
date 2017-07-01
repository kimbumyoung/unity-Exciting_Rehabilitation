using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
public class Create2 : MonoBehaviour {
	public GameObject a;
	public GameObject b;
	Vector3 pos;
	public int Number;
	private IEnumerator coroutine;
	public bool c = false;
	private float x = -30;
	private GameObject textOb;
	public int Number1;
	public string bb;
	public string cc;
	//public static string[] scoreArray1 = new string[7];
	public int max;
	void Awake(){
		this.gameObject.GetComponent<DbBody> ().SelectUsingReader ();
	}
	
	void Start(){
		Number = 0;
		Number1 = 0;
		coroutine = create (0.1f);

		Debug.Log(max);
		//this.gameObject.GetComponent<Db> ().SelectUsingReader ();
		//scoreArray1[1] =  this.gameObject.GetComponent<Db> ().scoreArray;
		StartCoroutine (coroutine);
		
	}
	
	
	void Update(){
		if (Number >=7) {
			
			
			StopCoroutine(coroutine);
			
			c = true;
			
		}
		
	}
	
	IEnumerator create(float w)
	{		int i=6;
		while (true) {
			yield return new WaitForSeconds (w);
			
			pos = new Vector3 (x, (Convert.ToInt32(DbBody.scoreArray1[i])*0.005f), 0);
			
			bb = Number.ToString();
			Debug.Log("1"+bb);
			GameObject ob = (GameObject)Instantiate(a, pos, Quaternion.Euler(0, 0, 18));
			ob.name = "B" + bb;
			//  GameObject.Find("t" + Number1.ToString()).GetComponent<Text>().text = "999";
			cc = Number.ToString();
			GameObject.Find(cc).GetComponent<Text>().text =DbBody.scoreArray1[i];
			
			i--;
			
			Number++;
			x += 8;
			StartCoroutine (coroutine);
		}
	}
}
