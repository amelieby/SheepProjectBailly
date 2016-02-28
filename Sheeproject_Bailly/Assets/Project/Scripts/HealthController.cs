using UnityEngine;
using System.Collections;

public class HealthController : MonoBehaviour {

	public float sante = 1;


	void Update () {

		if (sante == 0) 
		{
			Destroy (this);

		}
	
	}
}
