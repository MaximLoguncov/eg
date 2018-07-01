using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {


	void OnMouseDown (){
				transform.localScale = new Vector3 (0.025f, 0.025f, 0.025f);
			}

	void OnMouseUp (){
				transform.localScale = new Vector3 (0.019f, 0.019f, 0.019f);
}
}
