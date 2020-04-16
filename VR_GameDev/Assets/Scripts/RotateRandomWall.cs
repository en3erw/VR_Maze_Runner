using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRandomWall : MonoBehaviour {

    public List<GameObject> list;
    public List<GameObject> list2;
    public GameObject root;
    public float timer;
    public float rotateSpeed = 100.0f;

	void Start () {
        list = new List<GameObject>();
        list2 = new List<GameObject>();
        for (int i = 0; i < root.transform.childCount; i++)
        {
            if (root.transform.GetChild(i).gameObject.transform.localScale.x <= 9.0f)
            {
                
                list.Add(root.transform.GetChild(i).gameObject);
            }
        }
        
        for (int i = 0; i < 6; i++)
        {
            int random = Random.Range(0, list.Count);
            list2.Add(list[random].gameObject);
        }


    }
	
	void Update () {
        timer += Time.deltaTime;
        if (timer > 5)
        {
            for (int i = 0; i < list2.Count; i++)
            {
                  list2[i].transform.Rotate(0, (timer/ rotateSpeed), 0);
            }
        }
	}
}
