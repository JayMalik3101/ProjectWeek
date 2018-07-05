using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxTimer : MonoBehaviour
{
   [SerializeField] private float m_SecondRemaining = 15f;                   // Timer aanmaken en naar de goede waarde zetten.
    public GameObject m_NewsPaper;                                           // Newspaper Prefab kunnen aangeven
    private void Start()
    {
        StartCoroutine(SpawnPaper());                                        // Start de Timer b
    }
    private IEnumerator SpawnPaper()
    {
        yield return new WaitForSeconds(m_SecondRemaining);                  // Wacht voor x hoeveelheid seconden
        Instantiate(m_NewsPaper, new Vector3(1, 1, 3), Quaternion.identity); // Instatiate de Newspaper
    }
}
