using UnityEngine;
using System.Collections;

public class put_texture : MonoBehaviour {

	// Use this for initialization
	public Texture man1, man2, man3, woman1, woman2, woman3;
	string texture_selection;
	
	void Start () {
		Renderer renderer = GetComponent<Renderer>();
		texture_selection=PlayerPrefs.GetString("textura");
		
		poner_textura (renderer);
		
	}
	
	void poner_textura(Renderer renderer){
		if(texture_selection.Equals("man1")){
			renderer.material.mainTexture= man1;
		}
		if(texture_selection.Equals("man2")){
			renderer.material.mainTexture= man2;
		}
		if(texture_selection.Equals("man3")){
			renderer.material.mainTexture= man3;
		}
		if(texture_selection.Equals("woman1")){
			renderer.material.mainTexture= woman1;
		}
		if(texture_selection.Equals("woman2")){
			renderer.material.mainTexture= woman2;
		}
		if(texture_selection.Equals("woman3")){
			renderer.material.mainTexture= woman3;
		}
	}
}
