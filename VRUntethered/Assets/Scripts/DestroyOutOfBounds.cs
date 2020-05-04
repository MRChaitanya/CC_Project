using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Destroys Pizza object if it goes beyond 30 units with respect to position z
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        //Destroys animals if they go beyond -10 units with respect to postion z
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Gamer Over!!!"); //Displays Game Over in the Debug Window
            Destroy(gameObject);
        }
    }
}
