/* Copyright (c) 2007-2008 Technicat, LLC */

var depth = -1.0;

var color = Color.red;

var fallTorque:Vector3;

function Start() {
	GetComponent.<Renderer>().material.color = color;
	gameObject.AddComponent.<Rigidbody>();
	GetComponent("Rigidbody").AddTorque(Random.Range(-fallTorque.x,fallTorque.x),
										Random.Range(-fallTorque.y,fallTorque.y),
										Random.Range(-fallTorque.z,fallTorque.z));
	gameObject.SetActiveRecursively(true);
}

function Update() {
	if (transform.localPosition.y < depth) {
		Score.success += 1;
		Destroy(gameObject);
	}
}
