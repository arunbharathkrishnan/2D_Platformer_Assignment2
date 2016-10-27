using UnityEngine;
using System.Collections;

/*
 * Author Name : Arun Bharath Krishnan
 * Last Modified Date : 26-0ct-2014
 * Last Modified by : Arun Bharath Krishnan
 * This Class is to kill the player life, if he fells down.
 */

public class DeathCode : MonoBehaviour {


    

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("DeathPlane"))
        {
            Destroy(this.gameObject);
        }
    }
}
