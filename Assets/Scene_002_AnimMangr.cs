using UnityEngine;
using System.Collections;

public class Scene_002_AnimMangr : MonoBehaviour {

	public Transform init_boy;
	public Transform init_teen;
	public float waitToInitMorph = 5.0f;
	public float waitToEndMorph = 10.0f;

	// Use this for initialization
	void Start () {
	
		init_boy.GetChild(0).gameObject.SetActive(true);
		init_boy.GetChild(1).gameObject.SetActive(false);
		init_teen.GetChild(0).gameObject.SetActive(false);
		init_teen.GetChild(1).gameObject.SetActive(false);
				
		StartCoroutine(ManagerInit());
		StartCoroutine(ManagerEnd());
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	IEnumerator ManagerInit(){
		
		yield return new WaitForSeconds(waitToInitMorph);
		init_boy.GetChild(0).gameObject.SetActive(false);
		init_teen.GetChild(0).gameObject.SetActive(true);
		
		
	}
	
	IEnumerator ManagerEnd(){
		
		yield return new WaitForSeconds(waitToEndMorph);
		init_teen.GetChild(0).gameObject.SetActive(false);
		init_boy.GetChild(1).gameObject.SetActive(true);
		
	}
}
