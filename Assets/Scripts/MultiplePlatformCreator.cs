using UnityEngine;
using System.Collections;

/*
 * Author Name : Arun Bharath Krishnan
 * Last Modified Date : 26-0ct-2014
 * Last Modified by : Arun Bharath Krishnan
 * This Class is to create the multiple platform for the player.
 */

public class MultiplePlatformCreator : MonoBehaviour {

    public int maxPlatforms = 50;
    public GameObject platform;
    public float horizontalMin = 7.5f;
    public float horizontalMax = 14f;
    public float verticalMin = -6f;
    public float verticalMax = 6;


    private Vector2 originPosition;


    void Start()
    {

        originPosition = transform.position;
        spawn();

    }

    void spawn()
    {
        for (int i = 0; i < maxPlatforms; i++)
        {
            // Will create the multiple platform tiles with respect to give sizes
            Vector2 randomPosition = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(verticalMin, verticalMax));
            Instantiate(platform, randomPosition, Quaternion.identity);
            originPosition = randomPosition;
        }
    }


}
