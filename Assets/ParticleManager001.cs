using UnityEngine;
using System.Collections;

public class ParticleManager001 : MonoBehaviour {

	public float waitTime = 1.0f;
	
	// Use this for initialization
	void Start () {
		//gameObject.SetActive(false);
		gameObject.GetComponent<ParticleSystem>().Clear();
		gameObject.GetComponent<ParticleSystem>().Stop();
		
		StartCoroutine(WaitParticlesOn());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	IEnumerator WaitParticlesOn(){
		
		yield return new WaitForSeconds(waitTime);
		//gameObject.SetActive(false);
		gameObject.GetComponent<ParticleSystem>().Play ();
		
	}
}
