using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
    
    public Transform center;
    public float degreespersec = -65f;
    private Vector3 v;
    public bool rotateAroundSelf;
    
	// Use this for initialization
	void Start () {
    
        v = transform.position - center.position;
            }
	
	// Update is called once per frame
	void Update () {
        v = Quaternion.AngleAxis(degreespersec * Time.deltaTime, Vector3.forward) * v;
        transform.position = center.position + v;
        if (rotateAroundSelf)
        {
            transform.Rotate(0, 0, 50 * Time.deltaTime);
        }
	}
    
}
