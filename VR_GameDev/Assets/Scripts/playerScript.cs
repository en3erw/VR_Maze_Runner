using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

    public class playerScript : MonoBehaviour
    {
    public float gazeTime = 1.5f;
    private float timer;
    private bool gazedAt;
    public Material mat;
    public float x,y,z;
    public float scaleFactor;
    public bool materialInc;

    public TextMesh pass;
        void Update()
        {
        if (gazedAt)
        {
            timer += Time.deltaTime;
            if (timer <= 0.4f)
            {
              //  transform.localScale = new Vector3((timer * scaleFactor) + x, (timer *scaleFactor) + y, z);
             
            }
            if (timer >= gazeTime)
            {
               
                    ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerClickHandler);
               
            }
        }
       
        }



    public void PointerEnter()
    {
        gazedAt = true;
        if (materialInc)
            mat.color = new Color32(0, 100, 10, 100);
            
    
    }

    public void PointerExit()
    {
        gazedAt = false;
     
        timer = 0f;
       // transform.localScale = new Vector3(x, y, z);
        
        if (materialInc)
            mat.color = new Color32(255, 255, 255, 255);
    }

    public string PointerClick()
    {
     
        string pass = GetComponentInChildren<TextMesh>().text;
        Debug.Log(GetComponentInChildren<TextMesh>().text);
        gazedAt = !gazedAt;
        
        return pass;
    }

    public void interactObj()
        {
        SceneManager.LoadScene(1);
           

        }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ClearPass()
    {
        pass.text = "";
    }
}
