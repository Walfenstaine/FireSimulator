using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerSensor : MonoBehaviour {

	void OnTriggerEnter(Collider oser){
		if (oser.tag == "Player") {
            Mask.rid.EnterSmoke();
		}
	}
	void OnTriggerExit(Collider oser){
		if (oser.tag == "Player") {
            Mask.rid.ExitSmoke();
		}
	}
}
