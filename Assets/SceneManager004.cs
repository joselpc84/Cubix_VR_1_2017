using UnityEngine;
using System.Collections;

public class SceneManager004 : MonoBehaviour {

	public Transform baby;
	public Transform LightForLightShaft;
	public float waitToGiveBirth = 1.0f;
	public float waitToShutOffLightShaft = 1.0f;
	private bool fadeLightShaft = false;
	
	// Use this for initialization
	void Start () {
	
		//baby.transform.gameObject.SetActive(false);
		baby.GetChild(0).GetChild(0).GetComponent<SkinnedMeshRenderer>().enabled = false;
		baby.GetChild(0).GetChild(1).GetComponent<SkinnedMeshRenderer>().enabled = false;
		LightForLightShaft.transform.gameObject.GetComponent<LightShafts>().enabled = false;
		StartCoroutine(ManagerInit());
		StartCoroutine(ManagerEnd());
	}
	
	// Update is called once per frame
	void Update () {
	
		if(LightForLightShaft.GetComponent<LightShafts>().m_Brightness >= 0 && fadeLightShaft){
			LightForLightShaft.GetComponent<LightShafts>().m_Brightness -= 0.01f;
		}
		else if(LightForLightShaft.GetComponent<LightShafts>().m_Brightness <= 0 && fadeLightShaft)
		{
			fadeLightShaft = false;
			//gameObject.GetComponent<Light>().flare = offFlare;
			LightForLightShaft.GetComponent<LightShafts>().enabled = false;
			//gameObject.GetComponent("Halo");
		}
	
	}
	
	IEnumerator ManagerInit(){
		
		yield return new WaitForSeconds(waitToGiveBirth);
		//baby.gameObject.SetActive(true);
		LightForLightShaft.transform.gameObject.GetComponent<LightShafts>().enabled = true;
		baby.GetChild(0).GetChild(0).GetComponent<SkinnedMeshRenderer>().enabled = true;
		baby.GetChild(0).GetChild(1).GetComponent<SkinnedMeshRenderer>().enabled = true;
	}
	
	IEnumerator ManagerEnd(){
		
		yield return new WaitForSeconds(waitToShutOffLightShaft);
		//LightForLightShaft.transform.gameObject.GetComponent<LightShafts>().enabled = false;
		fadeLightShaft = true;
		
	}
}
