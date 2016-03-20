using UnityEngine;
using System.Collections;

public class ChangeScense : MonoBehaviour {
	public void change(int scenseNo){
		Application.LoadLevel (scenseNo);
	}

	public void exit(){
		Application.Quit ();
	}

}
