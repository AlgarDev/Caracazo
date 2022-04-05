using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField]
    public Transform myPlayer;
    void Update()
    {
        transform.position = new Vector3(myPlayer.position.x, myPlayer.position.y, -10);
    }
}
