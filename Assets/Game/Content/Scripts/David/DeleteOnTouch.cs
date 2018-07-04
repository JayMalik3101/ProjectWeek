using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnTouch : MonoBehaviour {
    [SerializeField] BoxManager m_BoxManager;
    private void OnTriggerEnter(Collider other)
    {
        m_BoxManager.CheckWhatPassed();
    }
    private void OnTriggerStay(Collider other)
    {
        m_BoxManager.CheckWhatPassed();
    }
}
