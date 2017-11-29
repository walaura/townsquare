using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class readOnTouch : MonoBehaviour {

	Collider collider;
	Animator animator;
	Text dialog;
	public Canvas dialogCanvas;
	string txt;


	// Use this for initialization
	void Start () {
		collider = GetComponent<Collider>();
		animator = GetComponent<Animator> ();
		txt = transform.parent.GetComponent<TalkyController> ().dialogTxt;
		dialog = dialogCanvas.transform.GetChild(1).GetComponent<Text>();
	}
	
	void OnCollisionEnter(Collision collision)
	{
		animator.enabled = true;
		dialogCanvas.GetComponent<Canvas> ().enabled = true;
		dialog.text = txt;
	}

	void OnCollisionExit(Collision collision)
	{
		animator.enabled = false;
		dialogCanvas.GetComponent<Canvas> ().enabled = false;
	}
		

}
