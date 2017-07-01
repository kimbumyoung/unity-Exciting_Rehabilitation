using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreUpdate : MonoBehaviour {
	Text scoreLabel;
	// Use this for initialization
	void Start () {
		scoreLabel = GetComponent<Text> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreLabel.text = Random1.score.ToString ();
		
	}
}
