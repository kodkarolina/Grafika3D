using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO.Ports;

public class FindComPorts : MonoBehaviour {

    Dropdown mDropdown;
    string[] ports;
    List<string> portsToList = new List<string>();

    private void Start()
    {
        ports = Ports();
        foreach (string arrItem in ports)
        {
            portsToList.Add(arrItem);
        }

        mDropdown = GetComponent<Dropdown>();
        //Clear all option
        mDropdown.ClearOptions();
        //add found options
        mDropdown.AddOptions(portsToList);
    }



    public string[] Ports () {
       ports = SerialPort.GetPortNames();
       return ports;
    }




}
