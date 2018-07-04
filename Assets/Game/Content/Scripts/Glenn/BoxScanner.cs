using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScanner : MonoBehaviour
{
     public Material m_ScannerMaterial;
    void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
    }
}
