using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overwritesteering : MonoBehaviour {
    public waypoint startWaypoint;
	// Use this for initialization
	void Start () {
        VehicleController vc = GameObject.FindObjectOfType<VehicleController>();
        vc.transform.GetComponent<VehicleInputController>().enabled = false;
        vc.transform.GetComponent<VehiclePathController>().enabled = false;
        waypointMovementManagerV2 wmm = vc.transform.gameObject.AddComponent<waypointMovementManagerV2>();
        wmm.startWaypoint=startWaypoint;
        vc.transform.gameObject.AddComponent<AIInput>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
