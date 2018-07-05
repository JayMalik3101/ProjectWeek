using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScanner : MonoBehaviour
{
    private Animator m_BoxAnimator;                     // Animator Aanroepen


    void OnTriggerEnter(Collider col)
    {
        Debug.Log("OF");
        if (col.CompareTag("Lid"))
        {
            Debug.Log("OOF");
            m_BoxAnimator = col.GetComponent<Animator>();  // Op het enteren van een trigger...
            Debug.Log(m_BoxAnimator);
            m_BoxAnimator.SetTrigger("Activate");                               // Zet de Boxstate dan op true
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Lid"))
        {
            m_BoxAnimator.SetTrigger("Deactivate");  
        }
    }
}
