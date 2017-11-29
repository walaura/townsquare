using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class TalkyDispatcher : MonoBehaviour {

	string[] talkys;
	public GameObject talky;
	public TextAsset tweets;

	// Use this for initialization
	void Start () {

		var tweetsAsJson = JSON.Parse (tweets.text);

		var pos = 0;

		for (var i = 0; i < 30; i++) {
			pos = pos + 5;

			var clonePosition = new Vector3 (Random.Range (-30.0f, 30.0f), 10f, Random.Range (-30.0f, 30.0f));

			Ray ray = new Ray (clonePosition, Vector3.down);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit, 20.0f)){
				Debug.Log (hit.point);
			}

			var clone = Instantiate(talky, hit.point, Quaternion.AngleAxis(Random.Range(0.0f,360.0f), Vector3.up));
			
			var controller = clone.GetComponent<TalkyController> ();
			controller.dialogTxt = tweetsAsJson["statuses"][i]["text"].Value;
			controller.color = Random.ColorHSV ();
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
