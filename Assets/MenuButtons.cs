using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour {
    [SerializeField] private GameObject m_GameManager;
    [SerializeField] private GameObject m_MenuButtons;
    [SerializeField] private GameObject m_Info;
	public void StartGame()
    {
        m_Info.SetActive(true);
        m_GameManager.SetActive(true);
        m_MenuButtons.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
