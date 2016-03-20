using UnityEngine;
using System.Collections;

public class CollideWall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "BuildingRight") {
			Debug.Log (col.gameObject);
			Debug.Log (col.gameObject.transform.position);
			Destroy(col.gameObject);
		}
        if (col.gameObject.tag == "BuildingLeft")
        {
            Debug.Log(col.gameObject);
            Debug.Log(col.gameObject.transform.position);
            Destroy(col.gameObject);
        }
    }

}
