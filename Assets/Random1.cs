using UnityEngine;
using System.Collections;

public class Random1 : MonoBehaviour {
	public static int score;
	
	public GameObject flyPrefab1;
	public GameObject flyPrefab2;
	private float x1 = 6.0f;
	public float y1;
	public float z1 = 0;
	
	private float x2 = -6.0f;
	public float y2;
	public float z2 = 0;
	
	
	public Vector3 place1;
	public Vector3 place2;
	
	private string sendScore;
	private string sendTable;
	// Use this for initialization
	void Start () {
		StartCoroutine (time1 (1.5f));
		StartCoroutine (time2 (1.5f));
		
	}
	
	IEnumerator time1(float waitTime) {
		for(int i=0; i<=40; i++) {
			generator1 ();
			yield return new WaitForSeconds (waitTime);
		}
	}
	
	IEnumerator time2(float waitTime) {
		for (int j=0; j<=40; j++) {
			generator2 ();
			yield return new WaitForSeconds (waitTime);
		}
		
	}
	void generator1() {
		y1 = Random.Range (0.0f, 1.6f);
		place1 = new Vector3 (x1, y1, z1);
		Instantiate (flyPrefab1, place1, Quaternion.identity);
	}
	
	void generator2() {
		y2 = Random.Range (0.0f, 1.6f);
		place2 = new Vector3 (x2, y2, z2);
		Instantiate (flyPrefab2, place2, Quaternion.identity);
	}
	
	IEnumerator gameover(float waitTime) {
		yield return new WaitForSeconds (waitTime);
		score = 0;
		Destroy(GameObject.Find("share2"));
		
		Application.LoadLevel(0);
	}
	
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("TimeLabel").GetComponent<ControlTime> ().s.value== 0) {
			Debug.Log("123213");
			sendScore = score.ToString();
			sendTable = "Insert into bodygame(Score) values ('";
			GameObject.Find("Main Camera").GetComponent<DbBody>().score1 = sendScore;
			GameObject.Find("Main Camera").GetComponent<DbBody>().BodyTable = sendTable;
			GameObject.Find("Main Camera").GetComponent<DbBody>().SendData();
			score = 0;
			Destroy(GameObject.Find("share2"));
			Destroy (GameObject.Find ("ShareOne"));
			
			Application.LoadLevel(0);
			
		}
		
		
	}
}
