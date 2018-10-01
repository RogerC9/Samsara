using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public Vector3 speed;
	void Start ()
    {
		
	}
	
	void Update ()
    {
        transform.Translate(Time.deltaTime * speed);
    }


}
