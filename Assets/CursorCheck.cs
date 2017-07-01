using UnityEngine;
using System.Collections;

public class CursorCheck : MonoBehaviour {
	private float time;
	private bool check = false;
    public GameObject sidebg;
	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider col) {
		check = true;
		time = 0;
        sidebg.SetActive(true);
	}
	void OnTriggerExit(Collider col){
		check = false;
		time = 0;
        sidebg.SetActive(false);
	}


	
	// Update is called once per frame
	void Update () {
		if (check == true) {
			time += Time.deltaTime;
			if(time >= 2.0f){
                Destroy(GameObject.Find("OverlayDemoShare"));
                Destroy(GameObject.Find("ScoreShare"));
			Application.LoadLevel (1);
			}
		}
	}



}
