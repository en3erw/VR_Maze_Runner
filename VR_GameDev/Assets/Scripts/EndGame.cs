using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

    public GameObject panelText;
    public Text textCanv;

    private void OnTriggerEnter(Collider other)
    {
        panelText.SetActive(true);
        textCanv.text = "Congratulations you found the treasure!!!";
        StartCoroutine(backToMainMenu());
    }

    IEnumerator backToMainMenu()
    {

        yield return new WaitForSecondsRealtime(5.0f);

        SceneManager.LoadScene(0);

    }
}
