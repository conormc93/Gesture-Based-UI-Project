using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectOnInput : MonoBehaviour {

    public EventSystem es;
    public GameObject go;

    private bool buttonSelected;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxisRaw("Vertical") != 0 && buttonSelected == false)
        {
            es.SetSelectedGameObject(go);
            buttonSelected = true;
        }
	}

    private void onDisable()
    {
        buttonSelected = false;
    }
}
