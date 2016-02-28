using UnityEngine;
using System.Collections;

using UnityStandardAssets.Characters.FirstPerson;

public class Gravite : MonoBehaviour {

	float gravite;
	public float strenght;
	private float saveGrav;

	public GameObject player;
	private FirstPersonController controller;

	void Start () {

		controller = player.GetComponent<FirstPersonController> ();
	
	}
	

	void OnTriggerEnter(Collider col)
	{
		col.transform.gameObject.GetComponent<Rigidbody> ().useGravity = false;

		if (col.tag == "Player") 
		{
			saveGrav = controller.m_GravityMultiplier;
			controller.m_GravityMultiplier = 0;
		}



	}

	void OnTriggerStay(Collider col)
	{
		col.transform.position = new Vector3 (col.transform.position.x, col.transform.position.y + strenght, col.transform.position.z);

	}

	void OnTriggerExit(Collider col)
	{
		col.transform.gameObject.GetComponent<Rigidbody> ().useGravity = true;
		if (col.tag == "Player") 
		{
			controller.m_GravityMultiplier = saveGrav;
		}


	}



}
