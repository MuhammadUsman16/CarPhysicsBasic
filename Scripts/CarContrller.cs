using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarContrller : MonoBehaviour {
	public WheelCollider FL, FR, RL, RR;
	public float AccelerationSpeed;
	public float SteerAngle;
	public bool Isbraking = false;
	public float Braketorque;
	public ParticleSystem BrakeParticle;

	void FixedUpdate () {
		//Acceleration Of Car.
		if (!Isbraking) 
		{
			float Xaxis = Input.GetAxis ("Horizontal");
			float Yaxis = Input.GetAxis ("Vertical");

			FL.steerAngle = Xaxis * SteerAngle;
			FR.steerAngle = Xaxis * SteerAngle;

			RR.motorTorque = Yaxis * AccelerationSpeed;
			RL.motorTorque = Yaxis * AccelerationSpeed;
		}
		// Braking of Car.
		if(Input.GetKey (KeyCode.Space))
		{
			Isbraking = true;
			if (Isbraking)
			{
				RR.brakeTorque = Braketorque;
				RL.brakeTorque = Braketorque;

				FL.brakeTorque = Braketorque;
				FR.brakeTorque = Braketorque;

				BrakeParticle.Emit (1);
				Isbraking = false;
			}  
		}
		else  
		{
			RR.brakeTorque = 0f;
			RL.brakeTorque = 0f;
			FL.brakeTorque = 0f;
			FR.brakeTorque = 0f;
		}
	}
}
