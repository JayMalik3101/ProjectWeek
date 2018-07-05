using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour {
    [SerializeField] private string m_CurrentCountry;
    [SerializeField] private List<GameObject> m_ItemsInCrate;
    [SerializeField] private float m_OriginalTime;
    [SerializeField] private float m_CurrentTime;

    private Animator m_CameraAnimator;
    private Animator m_CrateAnimator;
    private List<bool> m_IsIllegal;
    private List<bool> m_ItemPassed;
    private void Start()
    {
        m_CameraAnimator = GameObject.Find("Main Camera").GetComponent<Animator>();
        m_CameraAnimator.SetTrigger(null);
        m_CrateAnimator = GetComponent<Animator>();
        m_CurrentTime = m_OriginalTime;
        m_IsIllegal = new List<bool>();
        m_ItemPassed = new List<bool>();
        for (int i = 0; i < m_ItemsInCrate.Count; i++)
        {
            CheckIfIllegal(m_ItemsInCrate[i], i);
        }
    }
    private void Update()
    {
        if (m_CurrentTime <= 0)
        {
            m_CameraAnimator.SetTrigger("Deactivate");
            m_CrateAnimator.SetTrigger("Deactivate");
            m_CurrentTime = m_OriginalTime;
        }
        if (m_CurrentTime != m_OriginalTime)
        {
            m_CurrentTime -= Time.deltaTime;
        }
    }
    public void CheckWhatPassed()
    {
        for (int i = 0; i < m_IsIllegal.Count; i++)
        {
            if(m_ItemsInCrate[i].activeSelf)
            {
                m_ItemPassed.Add(true);
            }
            else
            {
                m_ItemPassed.Add(false);
            }
        }

        for (int i = 0; i < m_IsIllegal.Count; i++)
        {
            if(m_IsIllegal[i] == true && m_ItemPassed[i] == true)
            {
                Debug.Log(m_ItemsInCrate[i].name + " Caused 23 deaths in France");
            }
            else
            {
                Debug.Log("Great job you didnt indirectly participate at murdering people !");
            }
        }
        Destroy(gameObject);
    }
    
    private void CheckIfIllegal(GameObject currentItem, int itemInList)
    {
        if(m_CurrentCountry == "Netherlands")
        {
            if (currentItem.name == "M4" || currentItem.name == "Pistol" || currentItem.name == "Revolver" || currentItem.name == "AK-47" || currentItem.name == "Bomb")
            {
                m_IsIllegal.Add(true);
            }
            else
            {
                m_IsIllegal.Add(false);
            }
        }
        else
        {
            if(currentItem.name == "M4" || currentItem.name == "Pistol" || currentItem.name == "Revolver" || currentItem.name == "AK-47" || currentItem.name == "Bomb")
            {
                m_IsIllegal.Add(true);
            }
            else
            {
                m_IsIllegal.Add(false);
            }
        }

        
    }

    private void StartTimer()
    {
        m_CameraAnimator.SetTrigger("Activate");
        m_CurrentTime -= Time.deltaTime;
    }
}
