using UnityEngine;
using System.Collections;

public class Follower : MonoBehaviour {


	//bool hasTarget = false;
	//Vector3 posPlayer;

	void Start()
	{
		//posPlayer = GameObject.FindGameObjectWithTag("Player").transform.position;
	}


	// Update is called once per frame
	void Update () {

		//NavMeshAgent na = GetComponent<NavMeshAgent> ();


		/*if (na.velocity.magnitude < 0.5 || Vector3.Distance (na.destination, Camera.main.transform.position) > 3) 
		{
			hasTarget = false;
		}*/

		//GetComponent<CharacterController> ().Move (posPlayer - transform.position * 0.1);
	}
}
