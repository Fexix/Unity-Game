using UnityEngine;
using System.Collections;

public class SeguirPersonaje : MonoBehaviour {

	public Transform personaje;
	public float separacion =3f;
	// Update is called once per frame
	void Update () {
		if (personaje != null)
						
						
						
 	transform.position = new Vector3(personaje.position.x+separacion, transform.position.y, transform.position.z);
	
	}
}
