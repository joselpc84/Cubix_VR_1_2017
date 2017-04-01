#pragma strict
var fadeTime : float = 5;
var fadeTexture : Texture;
private var fadeOut : boolean = false;
private var tempTime : float;
private var time : float = 0.0;

function Start(){
	fadeOut = true;

}

function Update(){
	if (fadeOut){
		if(time < fadeTime)
		{
			time += Time.deltaTime;
			tempTime = Mathf.InverseLerp(0.0, fadeTime, time);
		}
	}
	
	if(tempTime >= 1.0) enabled = false;
}

function OnGUI(){
	if(fadeOut){
		GUI.color.a = tempTime + 0.1;
		GUI.DrawTexture(Rect(0, 0, Screen.width, Screen.height), fadeTexture);
	}
}