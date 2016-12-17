using UnityEngine;
using System.Collections;

public class BloqueCon : MonoBehaviour {
	private bool haColisionadoConElJugador = false;
	public int puntosGanados = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void onCollisionEnter2D(Collision2D collision){


		if (!haColisionadoConElJugador && collision.gameObject.tag == "Player") {
			haColisionadoConElJugador = true;


			GameObject obj = collision.contacts[0].collider.gameObject;
			if(obj.name == "Personaje"){
				haColisionadoConElJugador = true;
				NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
			}
		}
}
}
