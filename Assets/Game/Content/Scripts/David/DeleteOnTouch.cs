using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnTouch : MonoBehaviour {
    [SerializeField] GManager m_GameManager;
    private void OnTriggerEnter(Collider other)
    {
        m_GameManager.m_CurrentCrate.GetComponent<BoxManager>().CheckWhatPassed();
    }
}
