using NCMB;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class UnityChanScript : MonoBehaviour {

	//public Texture2D textureToDisplay;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnGUI(){
		//getMessage from server
		NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject> ("Message");
		query.WhereEqualTo ("placeid", "1");
		query.FindAsync ((List<NCMBObject> objectList,NCMBException e) => {
			if (objectList.Count != 0) {
				NCMBObject obj = objectList [0];
				string message = (string) obj["msg"];
				GUI.Label(new Rect(0,0,Screen.width,Screen.height), message);
				//Save log
				NCMBObject testClass = new NCMBObject ("ShowLog");
				testClass ["message"] = "Unitychan is showed";
				testClass.SaveAsync ();
			} else {

			}
		});

		

	}
	
	
}
