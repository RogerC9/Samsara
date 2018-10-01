using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlapCube : MonoBehaviour {

    public Vector3 position;
    public Vector3 halfbox;
    public LayerMask mask;

    private void FixedUpdate()
    {
        Collider[] hitColliders = Physics.OverlapBox(transform.position+position, halfbox, Quaternion.identity, mask);
        if (hitColliders.Length > 0)
        {
            Debug.Log(hitColliders[0].name);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireCube(transform.position+position,halfbox*2);
    }
}
