using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour {
    [SerializeField] private string m_CurrentCountry;
    [SerializeField] private List<GameObject> m_ItemsInCrate;
    private List<bool> m_IsIllegal;
    private List<bool> m_ItemPassed;
    private void Start()
    {
        for (int i = 0; i < m_ItemsInCrate.Count; i++)
        {
            CheckIfIllegal(m_ItemsInCrate[i], i);
        }
    }

    private void CheckWhatPassed()
    {
        for (int i = 0; i < m_IsIllegal.Count; i++)
        {
            if(m_ItemsInCrate[i] != null)
            {
                m_ItemPassed[i] = true;
            }
            else
            {
                m_ItemPassed[i] = false;
            }
        }

        for (int i = 0; i < m_IsIllegal.Count; i++)
        {
            if(m_IsIllegal[i] == true && m_ItemPassed[i] == true)
            {
                Debug.Log(m_ItemsInCrate[i].name + "Caused 23 deaths in France");
            }
        }
    }
    
    private void CheckIfIllegal(GameObject currentItem, int itemInList)
    {
        if(m_CurrentCountry == "Netherlands")
        {
            if (currentItem.name == "M4" || currentItem.name == "Pistol" || currentItem.name == "Revolver" || currentItem.name == "AK-47" || currentItem.name == "Bomb")
            {
                m_IsIllegal[itemInList] = true;
            }
            else
            {
                m_IsIllegal[itemInList] = false;
            }
        }
        else
        {
            if(currentItem.name == "M4" || currentItem.name == "Pistol" || currentItem.name == "Revolver" || currentItem.name == "AK-47" || currentItem.name == "Bomb")
            {
                m_IsIllegal[itemInList] = true;
            }
            else
            {
                m_IsIllegal[itemInList] = false;
            }
        }
    }

    private void OnDestroy()
    {
        CheckWhatPassed();
    }
}
