// Atach to an UI Text object placed wherever you like on the canvas.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessagePromptUI : MonoBehaviour {

	private static Text promptText;

	// Use this for initialization
	void Start () {
		promptText = GetComponent<Text>();
	}

	public static void PickUpPrompt (string itemName) {
		promptText.text = "Press E to pick the " + itemName;
	}

	public static void ClearAreaPrompt () {
		promptText.text = "This area looks good. Press H to signal the flare.";
	}
	
	public static void ErasePrompt () {
		promptText.text = "";
	}

}
