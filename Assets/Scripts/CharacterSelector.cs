using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterSelector : MonoBehaviour {

	//Controlling the gameobject
	public Text charNameText;
	private string charName;

	// This stores the layers we want the raycast to hit (make sure this GameObject's layer is included!)
	public LayerMask LayerMask = UnityEngine.Physics.DefaultRaycastLayers;

	//Start Method	
	void Start(){
		//Initialize the string for showing the first message.
		charName = "You've chosen: ";
	}

	//Events need for the Lean Touch
	protected virtual void OnEnable()
	{
		// Hook into the OnFingerTap event
		Lean.LeanTouch.OnFingerTap += OnFingerTap;
	}
	
	protected virtual void OnDisable()
	{
		// Unhook into the OnFingerTap event
		Lean.LeanTouch.OnFingerTap -= OnFingerTap;
	}


	//Method while tap or selecting the character
	public void OnFingerTap(Lean.LeanFinger finger)
	{
		// Does the prefab exist?
		// Make sure the finger isn't over any GUI elements
		if (finger.IsOverGui == false)
		{
			var ray = finger.GetRay();
			var hit = default(RaycastHit);
			
			// Was this finger pressed down on a collider?
			if (Physics.Raycast(ray, out hit, float.PositiveInfinity, LayerMask) == true)
			{
				// The collider is the player1 zarapa boy
				if (hit.collider.gameObject.name == "Player1")
				{
					charNameText.text = charName + "Zarapa Boy";
					//almacena en player prefs si escogio hombre
					PlayerPrefs.SetString("gender","man");
				}
				// The collider is the player2 zarapa girl
				else if(hit.collider.gameObject.name == "Player2"){
					charNameText.text = charName + "Zarapa Girl";
					//almacena en player prefs si escogio mujer
					PlayerPrefs.SetString("gender","woman");
				}
			}		
		}
	}	
}
