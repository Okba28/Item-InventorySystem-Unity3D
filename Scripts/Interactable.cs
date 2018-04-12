using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour {

	public float radius = 1.5f;
	private Transform player;
	private bool hasInteracted = false;

	private bool promptRaised = false;

	void Start () {
		player = FindObjectOfType<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().transform;
	}
	public virtual void Interact(){
		// This method is meant to be overwritten by other classes.
		Debug.Log("Interacting with " + transform.name);
	}
	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireSphere(transform.position, radius);		
	}
	void Update(){

		float distance = Vector3.Distance(player.position, transform.position);

		if (promptRaised && distance > radius){
			MessagePromptUI.ErasePrompt();
			promptRaised = false;
		}
		if (distance <= radius && !hasInteracted){ 
			if (!promptRaised){
				MessagePromptUI.PickUpPrompt(transform.name);
				promptRaised = true;
			}
			if (Input.GetKeyDown(KeyCode.E)) {
            	Interact ();
				hasInteracted = true;
				MessagePromptUI.ErasePrompt();
				promptRaised = false;
			}
		}
	}
}    

