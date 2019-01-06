using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTextValue : MonoBehaviour {

    static string choosenPort;
    Dropdown mDropdown;
    int mDropdownValue;

	// Use this for initialization
	void Start () {
        mDropdown = GetComponent<Dropdown>();
       
    }

    // Update is called once per frame
    void Update()
    {
        mDropdownValue = mDropdown.value;
        choosenPort = mDropdown.options[mDropdownValue].text;
        PlayerPrefs.SetString("choosenPort", choosenPort);
        Debug.Log(PlayerPrefs.GetString("choosenPort"));

    }
}
