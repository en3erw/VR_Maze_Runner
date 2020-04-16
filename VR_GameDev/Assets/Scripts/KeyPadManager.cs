using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KeyPadManager : MonoBehaviour {

	// Use this for initialization
	public List<GameObject> keys = new List<GameObject>();
	 
	string keyNumb;
	public TextMesh pass;
	void Start () {
		
		
		AddRandomNumb();
	}
	
	// Update is called once per frame

	void AddRandomNumb()
	{
		foreach(GameObject key in keys)
		{
			
            key.AddComponent(typeof(EventTrigger));
			EventTrigger trigger = key.GetComponent<EventTrigger>();
			EventTrigger.Entry entry = new EventTrigger.Entry();
			entry.eventID = EventTriggerType.PointerClick;
			entry.callback.AddListener( (eventData) => {
				
				
				
				pass.text += key.GetComponent<playerScript>().PointerClick();	
				
				if (pass.text.Length == 4)
				{
					//check if the pass is correct
				}
			});
			trigger.triggers.Add(entry);
			TextMesh keyChild = key.GetComponentInChildren<TextMesh>();
			keyChild.text = Random.Range(0, 9).ToString();
			
			//Debug.Log(number);
		}

	}


	void Update () {
		
	}
}
