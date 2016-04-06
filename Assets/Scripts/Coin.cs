using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Coin: MonoBehaviour {

	// Game object that represents to Character/Player
	private GameObject player;


	void Start(){
		player = GameObject.Find("character");
	}

	void Update(){

	}

	// Method that works when an object collides with
	// the coin (this game object), if the collider is
	// the character the coin dissapear
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		{
			if(this.tag == "diamond"){
				player.GetComponent<PlayerParams>().diamonds++;
				player.GetComponent<PlayerParams>().showDiamonds();
			}
			Destroy (this.gameObject);
		}
	}
}