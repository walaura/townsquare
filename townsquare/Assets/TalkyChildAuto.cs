using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkyChildAuto : MonoBehaviour {

	public string dialogTxt;
	public Color color;

	// Use this for initialization
	void Awake () {
		var controller = transform.GetChild (0).GetComponent<TalkyController> ();
		controller.dialogTxt = dialogTxt;
		controller.color = color;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
