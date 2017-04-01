using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

	public float start001 = 1.0f;
	public float start002 = 1.0f;
	public float start003 = 1.0f;
	public float start004 = 1.0f;
	public float start005 = 1.0f;

	// Use this for initialization
	void Start () {
		
		StartCoroutine(StartScene001());
		StartCoroutine(StartScene002());
		StartCoroutine(StartScene003());
		StartCoroutine(StartScene004());
		StartCoroutine(StartScene005());
		
		//Application.LoadLevel(1);
	}
	
	IEnumerator StartScene001(){
		yield return new WaitForSeconds(start001);
		//Application.LoadLevel("Scene_001");
		Application.LoadLevel(1);
		//UnityEngine.
	}
	
	IEnumerator StartScene002(){
		yield return new WaitForSeconds(start002);
		Application.LoadLevel(2);
	}
	
	IEnumerator StartScene003(){
		yield return new WaitForSeconds(start003);
		Application.LoadLevel(3);
	}
	
	IEnumerator StartScene004(){
		yield return new WaitForSeconds(start004);
		Application.LoadLevel(4);
	}
	
	IEnumerator StartScene005(){
		yield return new WaitForSeconds(start005);
		Application.LoadLevel(5);
	}
}
