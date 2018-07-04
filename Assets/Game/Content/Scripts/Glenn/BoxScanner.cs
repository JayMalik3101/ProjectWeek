using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScanner : MonoBehaviour
{
    private Animator m_BoxAnimator;
    private bool m_BoxState = false;
    public bool BoxState
    {
        set
        {
            m_BoxState = value;
            if (value == true)
                m_BoxAnimator.SetTrigger("Activate");
            else
                m_BoxAnimator.SetTrigger("Deactivate");
        }
    }

    void OnTriggerEnter(Collider col)
    {
        m_BoxAnimator = col.GetComponent<Animator>();
        BoxState = true;
    }
}
