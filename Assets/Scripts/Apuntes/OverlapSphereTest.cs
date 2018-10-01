using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlapSphereTest : MonoBehaviour {

    public Vector3 position;
    public float radius;
    public LayerMask mask;

    private void FixedUpdate()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position + position, radius, mask);
        if (hitColliders.Length > 0)
        {
            Debug.Log(hitColliders[0].name);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position + position, radius);
    }
}
