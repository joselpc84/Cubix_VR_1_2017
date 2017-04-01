using UnityEngine;
using System.Collections;

public class LightsTimer : MonoBehaviour {

	public bool triggerFinalState = false;
	public float waitTime = 1.0f;
	
	// Use this for initialization
	void Start () {
		
		gameObject.GetComponent<Light>().enabled = !triggerFinalState;
		StartCoroutine(WaitLights());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	IEnumerator WaitLights(){
		
		yield return new WaitForSeconds(waitTime);
		gameObject.GetComponent<Light>().enabled = triggerFinalState;
		
	}
}
