using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyoutofbounds : MonoBehaviour
{
    private float topBound = 35;

    private float lowBound = -15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the players in view games, remove that object 
        if (transform.position.z > topBound )
        {
            Destroy(gameObject);
        }else if (transform.position.z < lowBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        
    }
}
