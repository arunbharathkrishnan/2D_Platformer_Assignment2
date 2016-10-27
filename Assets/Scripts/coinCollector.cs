using UnityEngine;
using System.Collections;

/*
 * Author Name : Arun Bharath Krishnan
 * Last Modified Date : 26-0ct-2014
 * Last Modified by : Arun Bharath Krishnan
 * This Class is to create the method where player can collect the coins.
 */

public class coinCollector : MonoBehaviour {


    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            Destroy(gameObject);
    }

    

}
