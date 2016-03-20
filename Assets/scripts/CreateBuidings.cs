using UnityEngine;
using System.Collections;

public class CreateBuidings : MonoBehaviour {
	public GameObject[] Buildings;
    int BuildingNo;
	public float delaytime=1f;
	float timer;
	// Use this for initialization
	void Start () {
		timer = delaytime;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer < 0) {
            BuildingNo = Random.Range(0, 2);
			Instantiate(Buildings[BuildingNo],transform.position,transform.rotation);
			timer =delaytime;
		}
	
	}
}
