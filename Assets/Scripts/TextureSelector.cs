using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextureSelector : MonoBehaviour {

	//declaracion de variables 
	public GameObject player;
	public Button texture1, texture2, texture3; //estos tres son los botones correswpondientes a cada textura que se ven en el canvas
	public Texture character1, character2, character3;
	Renderer player_renderer;
	public string gender;


	void OnEnable()
	{
		//obtengo el renderer de el gameObject player para poder acceder a sus propiedades de material y textura
		player_renderer = player.GetComponent<Renderer>();

		//aqui utilize el AddListener para poder agregar funciones con parametros al evento onClick de los botones, en lugar de hacerlo
		//por el inspector (interfaz grafica) de los botones del canvas
		texture1.onClick.AddListener(delegate{changeAppearance(1);});
		texture2.onClick.AddListener(delegate{changeAppearance(2);});
		texture3.onClick.AddListener(delegate{changeAppearance(3);});
	}

	//esta funcion recibe un parametro entero, segun el cual añade una de las texturas que recibe este script como publicas
	void changeAppearance(int texture)
	{
		if(texture==1){
			player_renderer.material.mainTexture= character1;
			PlayerPrefs.SetString("textura",gender+""+texture);
		}
		if(texture==2){
			player_renderer.material.mainTexture= character2;
			PlayerPrefs.SetString("textura",gender+""+texture);
		}
		if(texture==3){
			player_renderer.material.mainTexture= character3;
			PlayerPrefs.SetString("textura",gender+""+texture);
		}
	}
}
