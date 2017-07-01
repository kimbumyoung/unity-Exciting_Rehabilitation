using UnityEngine;
using System.Collections;

public class RandomCreate1 : MonoBehaviour {
	public GameObject flyPrefab;
	public float x = -3.0f;
	public float y;
	public float z = 0;
	public float a = -1.0f;
	
	public Vector3 place;
	// Use this for initialization
	void Start () {
		StartCoroutine (time (1.5f));
		
	}
	
	IEnumerator time(float waitTime) {
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		yield return new WaitForSeconds (waitTime);
		generator ();
		
		
		
	}
	void generator() {
		y = Random.Range (0.0f, 1.6f);
		place = new Vector3 (x, y, z);
		Instantiate (flyPrefab, place, Quaternion.identity);
	}
	
	
	
	// Update is called once per frame
	void Update () {
		flyPrefab.transform.Translate(new Vector3(a*1.0f, 0.0f, 0.0f) * Time.deltaTime);
		
		
	}
}
