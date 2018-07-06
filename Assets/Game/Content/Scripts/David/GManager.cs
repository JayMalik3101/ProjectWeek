using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour {
    [SerializeField] private List<GameObject> m_Crates;
    
    private Animator m_CurrentCrateAnimator;
    public GameObject m_CurrentCrate;
    private bool m_StartTimer;
    [SerializeField] private List<string> m_SpawnedCrates;
    // Use this for initialization
    void Start () {
        m_SpawnedCrates = new List<string>();
        m_CurrentCrate = Instantiate(m_Crates[Random.Range(0,m_Crates.Count)], this.transform.position, this.transform.rotation);
        m_CurrentCrateAnimator = m_CurrentCrate.GetComponent<Animator>();
        m_CurrentCrateAnimator.SetTrigger("Activate");
        m_SpawnedCrates.Add(m_CurrentCrate.name);
        for (int i = 0; i < m_SpawnedCrates.Count; i++)
        {
            Debug.Log(m_SpawnedCrates[i]);
        }
    }
	
	// Update is called once per frame
	void Update () {
		if(m_CurrentCrate == null)
        {
            m_CurrentCrate = Instantiate(m_Crates[Random.Range(0, m_Crates.Count)], this.transform.position, this.transform.rotation);
            m_CurrentCrateAnimator = m_CurrentCrate.GetComponent<Animator>();
            m_CurrentCrateAnimator.SetTrigger("Activate");
            m_SpawnedCrates.Add(m_CurrentCrate.name);
            for (int i = 0; i < m_SpawnedCrates.Count; i++)
            {
                Debug.Log(m_SpawnedCrates[i]);
            }
        }
	}
}
