using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpRules : MonoBehaviour
{
    public GameObject m_instrucbook;

    public void Show()
    {
        m_instrucbook.SetActive(true);
    }

    public void Hide()
    {
        m_instrucbook.SetActive(false);
    }


}
