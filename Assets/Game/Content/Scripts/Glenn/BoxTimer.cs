using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxTimer : MonoBehaviour
{
   [SerializeField] private float m_SecondRemaining = 15f; // Timer aanmaken en naar de goede waarde zetten.
    public GameObject m_NewsPaper; // Newspaper Prefab kunnen aangeven
      void Update()
      {
           m_SecondRemaining -= Time.deltaTime;
           if (m_SecondRemaining < 0) // Als de timer 0 is...
           {
              NewsPaperPopup(); // Roep dan de Newspaper functie aan           if (m_SecondRemaining < 0) // Als de timer 0 is...

           }
      }
      private void NewsPaperPopup()
      {
         
      }
    
}
