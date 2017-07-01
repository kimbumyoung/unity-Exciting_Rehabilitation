using UnityEngine;
using System.Collections;

public class BodeyManager : MonoBehaviour {
	public int score;

	// Use this for initialization
	void Start () {
        GameObject.Find("U_CharacterFront 1").transform.FindChild("U_Char").gameObject.SetActive(true);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
