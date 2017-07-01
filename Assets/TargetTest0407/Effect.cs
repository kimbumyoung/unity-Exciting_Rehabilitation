using UnityEngine;
using System.Collections;

public class Effect : MonoBehaviour {
	public AudioClip ballsound;
	public ParticleSystem a;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{      
		if (other.gameObject.tag == "greenBall") {
			Destroy (gameObject);
			AudioSource.PlayClipAtPoint (ballsound, transform.position);
			Managerment.score += 10;

			Instantiate(a,this.transform.position,this.transform.rotation);
		}
	}
}
