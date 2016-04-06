using UnityEngine;
using System.Collections;

public class InitializeGame : MonoBehaviour {


	//con esta funcion se carga la escena de seleccion de nivel (mapa) al presionar el boton de empezar del canvas
	public void initialize(){
		Application.LoadLevel ("scene_test_sprint_01_B_select_levels_in_the_map");
	}
}
