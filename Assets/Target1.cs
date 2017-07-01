using UnityEngine;
using System.Collections;

public class Target1 : MonoBehaviour {
	public ParticleSystem a;
	public AudioClip ballsound;
	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 10.0f);
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(-1.5f, 0.0f, 0.0f) * Time.deltaTime);
		
	}
	
	void OnTriggerEnter(Collider other)
	{      
		if (other.gameObject.tag == "body") {
			Destroy (gameObject);
			AudioSource.PlayClipAtPoint (ballsound, transform.position);
			Random1.score += 30;
			
			Instantiate(a,this.transform.position,this.transform.rotation);
		}
	}
}
