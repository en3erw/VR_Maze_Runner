using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    public float time = 50.0f;
    public Text text;
    public GameObject panelLose;

	void Start () {
        panelLose.SetActive(false);
	}

	void Update () {
        time -= Time.deltaTime;
        if (time >= 20.0f)
        {
            text.text = time.ToString().Substring(0,4);

        }
        else if (time >= 0.0f)
        {
            text.text = time.ToString().Substring(0, 5);
            text.color = new Color32(250, 20, 20, 250);

        }
        else if (time >= -6.0f)
        {
            panelLose.SetActive(true);
            
        }
        else if (time <= -7.0f)
        {
            SceneManager.LoadScene(0);
        }

    }




}
