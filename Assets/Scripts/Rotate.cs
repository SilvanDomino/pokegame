using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float rotationSpeed = 5;
    public float rotationPower = 3;
    public float i = 0;
	
	// Update is called once per frame
	void Update () {
        float r = Mathf.Sin(i);
        this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, Mathf.Sin(r)*rotationPower));

        i += Time.deltaTime * rotationSpeed;
	}
}
