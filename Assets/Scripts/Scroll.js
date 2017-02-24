/* Copyright (c) 2007 Technicat, LLC */

var minspeed = 1.0;
var maxspeed = 10.0;
var range = 10.0;

var color = Color.yellow;

private var trans:Vector3;

function Start() {
	GetComponent.<Renderer>().material.color = color;
	var difficulty = gameObject.Find("Score").GetComponent(Score).GetScore();
	trans = new Vector3(0,0,-Random.Range(minspeed,maxspeed*difficulty+minspeed));
}

function Update() {
	if (transform.localPosition.z < range) {
		Score.failure+=1;
		Destroy(gameObject);
	} else {
  	transform.Translate(trans*Time.deltaTime, Space.World);
	}
}
