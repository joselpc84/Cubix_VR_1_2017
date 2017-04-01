using UnityEngine;
using System.Collections;

public class SceneTransitioner : MonoBehaviour {

	public float startNextSceneTime = 1.0f;
	public float fadeTime = 3.0f;
	public Transform faderRef;
	private bool startTransition = false;
	private bool transitionDone = false;

	// Use this for initialization
	void Start () {
		StartCoroutine(StartNextScene());
	}
	
	// Update is called once per frame
	void Update () {
		if (startTransition)
		{
			faderRef.gameObject.SetActive(true);
			StartCoroutine(WaitFade());
		}
	}
	
	IEnumerator StartNextScene(){
		yield return new WaitForSeconds(startNextSceneTime);
		startTransition = true;
		
	}
	IEnumerator WaitFade(){
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel(Application.loadedLevel + 1);
		
	}
	
}
