using UnityEngine;
using System.Collections;

public class qwer : MonoBehaviour {
	//int size = 2;
	//public GameObject[] tempGO = new GameObject[2];
	//	List<GameObject> tmd = new List<GameObject> ();
	//int[] b = new int[6];
	int i=0,j=0,b,jung=0;
	int[] val = new int[5];
	// Use this for initializatio
	void Start () {


		shuffle ();
		
	

		
	}

	void shuffle(){
		for (i=0; i<=3; i++) {
			
			b = Random.Range (0, 5);
			
			
			
			for (j=0; j<=i; j++) { //값이 들어간 배열값들과 현재 랜덤값들을 비교
				if (val [j].Equals (b)) { //중복된 값이 있으면
					i = i - 1;  //값을 넣지 않고 현제 배열로 다시한번 값을 찾기위해
					jung = 1;  //중복되었다는 것을 알려줌
					
				}
			}
			
			if (jung != 1) {  //중복되지 않았을때
				val [i] = b;  //배열값에 랜덤값을 넘겨줌
			} else { 
				jung = 0;   //중복되엇을시 배열에 값을 넣지 않고 중복변수에 0을줌
			}
		}
		for(i=0;i<val.Length;i++){
			Debug.Log(val[i]);
			
		}

	}

}
