using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour {
    public float m_Speed;
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x + (m_Speed * Time.deltaTime), transform.position.y, transform.position.z);
	}
}
