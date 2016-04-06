using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerParams : MonoBehaviour {

	public int diamonds = 0;
	public Text text_diamonds;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//esta funcion permite mostrar los diamantes capturados por el jugador a traves de un texto en el canvas
	public void showDiamonds(){
		text_diamonds.text = ""+diamonds;
	}
}
