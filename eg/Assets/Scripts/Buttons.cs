using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

	// Use this for initialization
	void OnMouseDown (){
				transform.localScale = new Vector3 (0.55f, 0.55f, 0.55f);
			}
	void OnMouseUP (){
				transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
}
}
