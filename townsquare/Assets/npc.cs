using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Renderer rend = GetComponent<Renderer>();
		rend.materials[0].SetColor("_Color", transform.parent.GetComponent<TalkyController> ().color);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}