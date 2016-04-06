using UnityEngine;
using System.Collections;

public class InitializeTextureSelection : MonoBehaviour {

	//declaracion de un string que cotenga el genero escogido
	string gender;

	//esta funcion basicamente toma la variable gender cuyo valor depende de la seleccion del usuario, y carga una de las dos 
	//escenas de seleccion de apariencia (texturas)
	public void initialize(){

		//saca el genero de player prefs
		gender = PlayerPrefs.GetString("gender");

		//estructuras de seleccion simples para cargar la escena segun el genero escogido
		if (gender.Equals ("man")) {
			Application.LoadLevel("selectManAppearance");
		}
		
		if (gender.Equals ("woman")) {
			Application.LoadLevel("selectWomanAppearance");
		}
	}
}
