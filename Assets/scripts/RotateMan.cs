using UnityEngine;
using System.Collections;

public class RotateMan : MonoBehaviour {

	Vector3 manrot;
	private HingeJoint2D HJ;
	private JointMotor2D JM;

	public float turnSpeed= 100f;
	public float motor= 5f;

	void Start () {

	}

	void Update ()
	{
		RaycastHit2D hit;
		hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero);
		HJ = GetComponent<HingeJoint2D> ();
		JointMotor2D Motor = HJ.motor;

		manrot = Input.acceleration;

		if (manrot.x<0) {
			if(gameObject.transform.rotation.z<=0.015f && gameObject.transform.rotation.z>= -0.015)
				{transform.Rotate (Vector3.back, 35*manrot.x* Time.deltaTime);}
			else{transform.Rotate (Vector3.back, 30*manrot.x * Time.deltaTime);}

		}
		
		if (manrot.x>0) {
			if(gameObject.transform.rotation.z<=0.015f && gameObject.transform.rotation.z>= -0.015)
			{transform.Rotate (Vector3.back, 35*manrot.x* Time.deltaTime);}
			else{transform.Rotate (Vector3.back, 30*manrot.x * Time.deltaTime);}
		}

		if (gameObject.transform.rotation.z < 0f) // Rightside
		{
			if(gameObject.transform.rotation.z<-0.017f){transform.Rotate (Vector3.back, 8* Time.deltaTime);}
			else if (gameObject.transform.rotation.z< -0.15f){transform.Rotate (Vector3.back, 11* Time.deltaTime);}
			else if (gameObject.transform.rotation.z< -0.13f){transform.Rotate (Vector3.back, 13* Time.deltaTime);}
			else if (gameObject.transform.rotation.z< -0.11f){transform.Rotate (Vector3.back, 11* Time.deltaTime);}
			else if (gameObject.transform.rotation.z< -0.09f){transform.Rotate (Vector3.back, 9* Time.deltaTime);}
			else if (gameObject.transform.rotation.z< -0.07f){transform.Rotate (Vector3.back, 7* Time.deltaTime);}
			else if (gameObject.transform.rotation.z< -0.05f){transform.Rotate (Vector3.back, 5* Time.deltaTime);}
			else if (gameObject.transform.rotation.z< -0.015f){transform.Rotate (Vector3.back, 3* Time.deltaTime);}
		}

		if (gameObject.transform.rotation.z > 0f) // Leftside
		{
			if(gameObject.transform.rotation.z>0.017f){transform.Rotate (Vector3.back, -8* Time.deltaTime);}
			else if (gameObject.transform.rotation.z> 0.15f){transform.Rotate (Vector3.back, -11* Time.deltaTime);}
			else if (gameObject.transform.rotation.z> 0.13f){transform.Rotate (Vector3.back, -13* Time.deltaTime);}
			else if (gameObject.transform.rotation.z> 0.11f){transform.Rotate (Vector3.back, -11* Time.deltaTime);}
			else if (gameObject.transform.rotation.z> 0.09f){transform.Rotate (Vector3.back, -9* Time.deltaTime);}
			else if (gameObject.transform.rotation.z> 0.07f){transform.Rotate (Vector3.back, -7* Time.deltaTime);}
			else if (gameObject.transform.rotation.z> 0.05f){transform.Rotate (Vector3.back, -5* Time.deltaTime);}
			else if (gameObject.transform.rotation.z> 0.015f){transform.Rotate (Vector3.back, -3* Time.deltaTime);}
		}


		if (gameObject.transform.rotation.z > 0.24f || gameObject.transform.rotation.z < -0.24f) {
			Application.LoadLevel(6);

		}
		
		if (Input.touchCount>0) {			
			if (hit.collider != null) {
				if (hit.transform.gameObject.tag == "LeftArr") {
					if(Input.GetTouch(0).phase==TouchPhase.Stationary){
						transform.Rotate (Vector3.back, -turnSpeed * Time.deltaTime);
					} 
				}
				if (hit.transform.gameObject.tag == "RightArr") {
					if(Input.GetTouch(0).phase==TouchPhase.Stationary){
						transform.Rotate (Vector3.back, turnSpeed * Time.deltaTime);
					} 
				}
			}
		}
	}
}

