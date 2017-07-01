using UnityEngine;
using System.Collections;

public class ballDestroy : MonoBehaviour {
	//public AudioClip ballsound;
	private GameObject g;
	// Use this for initialization
	void Start () {
		//g = GameObject.FindWithTag ("boom");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{		Debug.Log ("111");
		if (other.gameObject.tag == "greenBall") {
			//AudioSource.PlayClipAtPoint (ballsound, transform.position);
			Destroy (gameObject, 1.0f);
			//Instantiate(g,this.transform.position,this.transform.rotation);
		}
	}


}
