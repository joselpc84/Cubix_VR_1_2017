using UnityEngine;
using System.Collections;

public class LightsManager_003 : MonoBehaviour {

	public float waitStartTime = 1.0f;
	public float waitEndTime = 1.0f;
	private bool fadeLightShaft = false;
	//public Flare offFlare;

	// Use this for initialization
	void Start () {
		//gameObject.GetComponent<LightShafts>().enabled = true;
		StartCoroutine(WaitLightRaysOn());
		StartCoroutine(WaitLightRaysDimOff());
	}
	
	// Update is called once per frame
	void Update () {
	
		if(gameObject.GetComponent<LightShafts>().m_Brightness >= 0 && fadeLightShaft){
			gameObject.GetComponent<LightShafts>().m_Brightness -= 0.01f;
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
		
		yield return new WaitForSeconds(waitStartTime);
		gameObject.GetComponent<LightShafts>().enabled = true;
		//fadeLightShaft = true;
		
		
	}
	
	IEnumerator WaitLightRaysDimOff(){
		
		yield return new WaitForSeconds(waitEndTime);
		//gameObject.GetComponent<LightShafts>().enabled = false;
		fadeLightShaft = true;
		
		
	}
}
