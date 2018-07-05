using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastForward : MonoBehaviour {
    [SerializeField] GManager m_GameManager;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            m_GameManager.m_CurrentCrate.GetComponent<BoxManager>().FastForward();
        }
    }
}
