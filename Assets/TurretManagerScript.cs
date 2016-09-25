using UnityEngine;
using System.Collections;

public class TurretManagerScript : MonoBehaviour {

	private Animator _animator;

	void Start () {
		_animator = this.GetComponent<Animator> ();
	}

	private void PlayShootAnimation(){
		_animator.SetTrigger ("Shoot");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			PlayShootAnimation ();
		}
	}
}
