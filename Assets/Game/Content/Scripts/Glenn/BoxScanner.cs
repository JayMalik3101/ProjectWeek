using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScanner : MonoBehaviour
{
    private Animator m_BoxAnimator;                     // Animator Aanroepen
    private bool m_BoxState = false;                    // De default state van de box op false zetten
    public bool BoxState
    {
        set
        {
            m_BoxState = value;
            if (value == true)
                m_BoxAnimator.SetTrigger("Activate");   // Activeer de Scanning Animation
            else
                m_BoxAnimator.SetTrigger("Deactivate"); // Activeer de Scanning Animation
        }
    }

    void OnTriggerEnter(Collider col)
    {
        m_BoxAnimator = col.GetComponent<Animator>();  // Op het enteren van een trigger...
        BoxState = true;                               // Zet de Boxstate dan op true
    }
}
