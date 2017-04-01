using UnityEngine;
using System.Collections;

public class SceneManager005 : MonoBehaviour {

	public Transform MaleElderly;
	public Transform FemaleElderly;
	public Transform Logo;
	public Transform Lights;
	public float waitToTurnLightsOff = 1.0f;
	public float waitToIncrLogoBright = 1.0f;
	public float waitToTriggerLogo = 1.0f;
	private bool lightsOffTrigger = false;
	private bool logoOnTrigger = false;

	// Use this for initialization
	void Start () {
	
		MaleElderly.transform.gameObject.SetActive(true);
		FemaleElderly.transform.gameObject.SetActive(true);
		Logo.transform.gameObject.SetActive(false);
		StartCoroutine(LightsManager());
		StartCoroutine(LogoManager());
	}
	
	// Update is called once per frame
	void Update () {
		if(Lights.GetChild(0).GetComponent<Light>().intensity >= 0 && lightsOffTrigger && !logoOnTrigger){
			for(int i=0;i<=5;i++)
			{
				Lights.GetChild(i).GetComponent<Light>().intensity -= 0.005f;
			}
		}
		else if(Lights.GetChild(0).GetComponent<Light>().intensity < 0 && lightsOffTrigger && !logoOnTrigger)
		{
			lightsOffTrigger = false;
			for(int i=0;i<=5;i++)
			{
				Lights.GetChild(i).GetComponent<Light>().intensity = 0.0f;
			}
		}
		else if(Lights.GetChild(0).GetComponent<Light>().intensity < 0.11f && logoOnTrigger && !lightsOffTrigger)
		{
			for(int i=0;i<=5;i++)
			{
				Lights.GetChild(i).GetComponent<Light>().intensity += 0.0025f;
			}
		}
		else if(Lights.GetChild(0).GetComponent<Light>().intensity >= 0.11f && logoOnTrigger && !lightsOffTrigger)
		{
			StartCoroutine(LogoTrigger());
			logoOnTrigger = false;
		}
	}
	
	IEnumerator LightsManager(){
		yield return new WaitForSeconds(waitToTurnLightsOff);
		lightsOffTrigger = true;
	}
	
	IEnumerator LogoManager(){
		yield return new WaitForSeconds(waitToIncrLogoBright);
		logoOnTrigger = true;
		lightsOffTrigger = false;
		//Logo.transform.gameObject.SetActive(true);
		MaleElderly.transform.gameObject.SetActive(false);
		FemaleElderly.transform.gameObject.SetActive(false);
	}
	
	IEnumerator LogoTrigger(){
		yield return new WaitForSeconds(waitToTriggerLogo);
		Logo.transform.gameObject.SetActive(true);
		
	}
}
