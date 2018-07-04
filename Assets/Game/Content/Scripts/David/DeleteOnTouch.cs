using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnTouch : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        Destroy(other.gameObject);
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.name + "Stay");
        Destroy(other.gameObject);
    }
}
