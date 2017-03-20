using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {

	public Transform player;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (Vector3.Distance (player.position, this.transform.position) < 12) {

			Vector3 direction = player.position - this.transform.position;
			//direction.y = 0f;

			this.transform.rotation = Quaternion.LookRotation (direction);

			if (direction.magnitude > 5) {
				anim.SetBool("Walking")
				this.transform.Translate (0f, 0f, 0.1f);
			} else{
				
		}
		
	}
}
