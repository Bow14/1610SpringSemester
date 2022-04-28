using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] Vector3 offset = new Vector3(0, 4, -7.83f);
    
    // Update is called once per frame
    void LateUpdate()
    {
        //Offets the camera above the player and follows said player
        transform.position = player.transform.position + offset ;
    }
}
