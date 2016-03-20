using UnityEngine;
using System.Collections;

public class MoveBuildings : MonoBehaviour {
	public float buidingspeed=5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (0, 0, 1) * buidingspeed * Time.deltaTime);
	}
}
