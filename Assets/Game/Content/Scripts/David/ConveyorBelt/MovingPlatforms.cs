using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour {
    public float m_Speed;
    private Rigidbody m_PlatformRB;

    private void Start()
    {
        m_PlatformRB = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update () {
        m_PlatformRB.MovePosition(new Vector3(transform.position.x + (m_Speed * Time.deltaTime), transform.position.y, transform.position.z));
	}
}
