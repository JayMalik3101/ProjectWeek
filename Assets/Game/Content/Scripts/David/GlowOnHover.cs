using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowOnHover : MonoBehaviour {
    [SerializeField] private Material m_HoverMaterial;
    [SerializeField] private Material m_ClickMaterial;
    private Material m_OriginalMaterial;
    private MeshRenderer m_ObjectMesh;

    private void Start()
    {
        m_ObjectMesh = this.GetComponent<MeshRenderer>();
        m_OriginalMaterial = m_ObjectMesh.material;
    }

    private void OnMouseEnter()
    {
        m_ObjectMesh.material = m_HoverMaterial;
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            m_ObjectMesh.material = m_ClickMaterial;
            Destroy(gameObject);
        }
    }

    private void OnMouseExit()
    {
        m_ObjectMesh.material = m_OriginalMaterial;
    }
}
