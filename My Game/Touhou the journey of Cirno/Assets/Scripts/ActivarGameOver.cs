using UnityEngine;
using System.Collections;

public class ActivarGameOver : MonoBehaviour {
	public GameObject camaraGameOver;
	public AudioClip gameOverClip;
	public float volumen = 0.5f;


	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "PersonajeHaMuerto");
	
	}
	 void PersonajeHaMuerto(Notification notificacion){
		audio.Stop ();
		audio.clip = gameOverClip;
		audio.loop = true;
		audio.volume = volumen;
		audio.Play();
		camaraGameOver.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
