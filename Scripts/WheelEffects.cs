using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelEffects : MonoBehaviour {
	Vector3 WheelPos;
	Quaternion WheelRot;

	public WheelCollider Wheel;
	// Update is called once per frame
	void Update () {
		Wheel.GetWorldPose (out WheelPos,out WheelRot);
		transform.position = WheelPos;
		transform.rotation = WheelRot;
	}
}
