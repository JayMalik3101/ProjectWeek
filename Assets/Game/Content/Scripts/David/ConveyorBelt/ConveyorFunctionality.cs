using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorFunctionality : MonoBehaviour {
    [SerializeField] private Transform m_SpawnPoint;
    [SerializeField] private float m_SpawnTimer;
    [SerializeField] private Rigidbody m_Platform;
    private float m_OriginalSpawnTimer;

    private void Start()
    {
        m_OriginalSpawnTimer = m_SpawnTimer;
    }

    // Update is called once per frame
    void Update () {
        m_SpawnTimer -= Time.deltaTime;
        if(m_SpawnTimer <= 0)
        {
            Rigidbody newProjectile = Instantiate(m_Platform, m_SpawnPoint.position, m_SpawnPoint.rotation);
            m_SpawnTimer = m_OriginalSpawnTimer;
        }
	}
}
