using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour {
    public GameObject particle;
	
	void Start () {
        particle.SetActive(false);
    }
	
    private void OnTriggerEnter(Collider other)
    {
        particle.SetActive(true);
    }

}
