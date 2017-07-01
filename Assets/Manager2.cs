using UnityEngine;
using System.Collections;

public class Manager2 : MonoBehaviour {
	public int ManagerCount;
	public GameObject lineCreate;
	private GameObject co;
	private bool tr ;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tr = this.gameObject.GetComponent<Create2> ().c; 
		
		if (tr) {
			if(ManagerCount<=6){
				Instantiate(lineCreate,this.transform.position,this.transform.rotation);
				
				ManagerCount++;
			}
		}
		
	}
	
	
	
}

