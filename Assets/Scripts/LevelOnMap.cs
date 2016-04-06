using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelOnMap : MonoBehaviour {

	// Level that the user probably will play
	public string level = "";

	//variable para retroalimentar en texto del nivel escogido
	public Text text_level;

	// Game object that contains the Control Script where
	// is the actions of buttons like "Select Level"
	public GameObject controlHUD;

	void Start () {
		level = this.gameObject.name;


	}
	
	void Update () {

	}

	// When user click or touch the level, the control object knows what is the current
	// level that the user probably will play
	void OnMouseDown(){
		controlHUD.GetComponent<ControlHUD_SelectLevel>().currentLevel = level;
		text_level.text = "Has escogido "+level;
	}
}
