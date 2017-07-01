using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PowerUp : MonoBehaviour
{

	#region Settings
	public float rotationSpeed = 99.0f;
	public bool reverse = false;
	#endregion

	void Update ()
	{
		if(this.reverse)
			transform.Rotate(Vector3.back * Time.deltaTime * this.rotationSpeed);
			//transform.Rotate(0, 0, Time.deltaTime * this.rotationSpeed);
		else
			transform.Rotate(Vector3.forward * Time.deltaTime * this.rotationSpeed);
			//transform.Rotate(0, 0, -(Time.deltaTime * this.rotationSpeed));
	}
}
