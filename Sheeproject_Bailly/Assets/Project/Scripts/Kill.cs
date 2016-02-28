using UnityEngine;
using System.Collections;

public class Kill : MonoBehaviour {

	public void OnCollisionEnter (Collision collision)
	{

		Debug.Log ("collision !");
		HealthController health = collision.gameObject.GetComponent<HealthController> ();

		if (health != null) 
		{
			health.sante -= 1;


		}


	}
}
