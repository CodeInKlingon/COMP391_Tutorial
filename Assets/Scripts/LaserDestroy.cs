using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDestroy : MonoBehaviour {


    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "laser") {
            Destroy(col.gameObject);
            Destroy(gameObject);
                
        } else if (col.gameObject.tag == "Player") {
            print("hit player");
            Destroy(gameObject);
        }


    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
