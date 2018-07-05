using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAnimationController : MonoBehaviour {
    private Animator m_BoxAnimator;
    public bool m_BoxState = true;

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
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
