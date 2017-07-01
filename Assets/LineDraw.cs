using UnityEngine;
using System.Collections;

public class LineDraw : MonoBehaviour {
	
	private LineRenderer lineRenderer;
	private float counter;
	private float dist;
	public Transform origin;
	public Transform destination;
	private float lineDrawSpeed = 5f;
	public int S;
	
	
	// Use this for initialization
	void Start () {
		
		
		
		
		S = GameObject.FindWithTag ("MainCamera").GetComponent<Manager> ().ManagerCount;
		
		if (S == 1) {
			GameObject a1 = GameObject.Find ("B0");
			GameObject a2 = GameObject.Find  ("B1");
			origin = a1.transform;
			destination = a2.transform;
		} else if (S == 2) {
			GameObject a2 = GameObject.Find  ("B1");
			GameObject a3 = GameObject.Find  ("B2");
			origin = a2.transform;
			destination = a3.transform;
		} else if(S == 3){
			
			GameObject a3 = GameObject.Find ("B2");
			GameObject a4 = GameObject.Find  ("B3");
			origin = a3.transform;
			destination = a4.transform;
		}
		else if(S ==4){
			
			GameObject a4 = GameObject.Find ("B3");
			GameObject a5 = GameObject.Find  ("B4");
			origin = a4.transform;
			destination = a5.transform;
		}
		else if (S == 5)
		{
			
			GameObject a5 = GameObject.Find("B4");
			GameObject a6 = GameObject.Find("B5");
			origin = a5.transform;
			destination = a6.transform;
		}
		else if (S == 6)
		{
			
			GameObject a6 = GameObject.Find("B5");
			GameObject a7 = GameObject.Find("B6");
			origin = a6.transform;
			destination = a7.transform;
		}
		else
		{
			
		}
		/*
        else{
             GameObject a6 = GameObject.Find("B6");
            GameObject a7 = GameObject.Find("B7");
            origin = a6.transform;
            destination = a7.transform;
        }*/
		
		
		
		Debug.Log (S);
		
		lineRenderer = GetComponent<LineRenderer> ();
		lineRenderer.SetPosition (0, origin.position);
		lineRenderer.SetWidth (.45f, .45f);
		dist = Vector3.Distance (origin.position, destination.position);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (counter < dist) {
			counter += .1f/lineDrawSpeed;
			float x = Mathf.Lerp(0,dist,counter);
			Vector3 pointA = origin.position;
			Vector3 pointB = destination.position;
			
			Vector3 pointAlongLine = x*Vector3.Normalize(pointB -pointA) + pointA;
			lineRenderer.SetPosition(1,pointAlongLine);
			
			
		}
		
		
	}
	
}
