using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {
    public GameObject target;
    public GameObject player;
    public bool teleOnce;
   
    private void OnTriggerEnter(Collider other)
    {
        if (teleOnce)
            player.transform.position = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z);
        else
            teleOnce = false;
    }

}
