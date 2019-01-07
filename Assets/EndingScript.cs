using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingScript : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "mPlayer")
        {
            Destroy(gameObject);
        }
    }
}
