using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour {
    [SerializeField] private string m_CurrentCountry;
    [SerializeField] private List<GameObject> m_ItemsInCrate;

    private void CheckItems()
    {
        for (int i = 0; i < m_ItemsInCrate.Count; i++)
        {
            CheckIfIllegal(m_ItemsInCrate[i]);
        }
    }

    private void CheckIfIllegal(GameObject CurrentItem)
    {
        if(m_CurrentCountry == "Netherlands")
        {

        }
        else
        {

        }
    }
}
