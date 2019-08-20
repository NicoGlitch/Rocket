using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour {

    Rigidbody rbd;
    public int SPEEDFACTOR = 1000;
    public int ORIGINE = 1;

    // Use this for initialization
    void Start () {
        rbd = gameObject.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxis("Jump")!=0)
        {
            print("space key was pressed");
            rbd.AddRelativeForce(new Vector3(0, Input.GetAxis("Jump") * Time.deltaTime * SPEEDFACTOR), 0);

        }

        if(Input.GetAxis("Horizontal") != 0)
        {
            rbd.AddForceAtPosition(new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * SPEEDFACTOR, 0, 0),new Vector3(0, ORIGINE, 0));

        }
    }
}
