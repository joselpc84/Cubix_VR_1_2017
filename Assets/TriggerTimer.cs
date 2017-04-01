using UnityEngine;
using System.Collections;

public class TriggerTimer : MonoBehaviour {

	public bool triggerFinalState = true;
	public bool fadeLightShaft = false;
	public float waitTime = 1.0f;

	// Use this for initialization
	void Start () {
	
		gameObject.GetComponent<LightShafts>().enabled = false;
		StartCoroutine(WaitLightRaysOn());
		//StartCoroutine(WaitLightRaysOff());
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(gameObject.GetComponent<LightShafts>().m_Brightness >= 0 && fadeLightShaft){
			gameObject.GetComponent<LightShafts>().m_Brightness -= 0.0001f;
			
		}
		else if(gameObject.GetComponent<LightShafts>().m_Brightness <= 0 && fadeLightShaft)
		{
			fadeLightShaft = false;
			//gameObject.GetComponent<Light>().flare = offFlare;
			gameObject.GetComponent<LightShafts>().enabled = false;
			//gameObject.GetComponent("Halo");
			
		}
		
	
	}
	
	IEnumerator WaitLightRaysOn(){
	
		yield return new WaitForSeconds(waitTime);
		gameObject.GetComponent<LightShafts>().enabled = triggerFinalState;
		fadeLightShaft = true;
	
	}
}
