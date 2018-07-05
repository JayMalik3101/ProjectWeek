using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour {
    [SerializeField] private List<GameObject> m_Crates;
    
    private Animator m_CurrentCrateAnimator;
    private GameObject m_CurrentCrate;
    private bool m_StartTimer;

    // Use this for initialization
    void Start () {
        m_CurrentCrate = Instantiate(m_Crates[Random.Range(0,m_Crates.Count)], this.transform.position, this.transform.rotation);
        m_CurrentCrateAnimator = m_CurrentCrate.GetComponent<Animator>();
        m_CurrentCrateAnimator.SetTrigger("Activate");
    }
	
	// Update is called once per frame
	void Update () {
		if(m_CurrentCrate == null)
        {
            m_CurrentCrate = Instantiate(m_Crates[Random.Range(0, m_Crates.Count)], this.transform.position, this.transform.rotation);
            m_CurrentCrateAnimator = m_CurrentCrate.GetComponent<Animator>();
            m_CurrentCrateAnimator.SetTrigger("Activate");
        }
	}
}
