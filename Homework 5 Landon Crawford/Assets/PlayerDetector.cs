using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray playerRay = new Ray(transform.position, Vector3.right);
        RaycastHit hit;

        if (Physics.Raycast(playerRay, out hit, 5))
        {
            print(hit.transform.gameObject);
        }
        else
        {
            print("nothing ahead");
        }
    }
}
