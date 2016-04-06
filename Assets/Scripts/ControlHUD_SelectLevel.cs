using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class ControlHUD_SelectLevel : MonoBehaviour {
	
	// The current level in which the character is standing
	public string currentLevel = "";

	//genero escogido por el usuario
	string gender;
	
	void Start () {
		//cojo el genero que este almcenado en player prefs para poder devolverme a el pro el boton back
		gender = PlayerPrefs.GetString("gender");
	}

	void Update () {

	}
	

	// This method works when the user clicked "Select level" or "Play level"
	// The level clicked will be played by the user
	public void selectLevel(){
		Application.LoadLevel(currentLevel);
	}

	public void back(){
		if (gender.Equals ("man")) {
			Application.LoadLevel("selectManAppearance");
		}
		
		if (gender.Equals ("woman")) {
			Application.LoadLevel("selectWomanAppearance");
		}
	}
}
