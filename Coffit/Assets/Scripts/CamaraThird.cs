using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraThird : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 offset; // distance btwn camera and player
    private Transform target;
    [Range (0, 1)]public float lerpValue;
    void Start()
    {
        target = GameObject.Find("Player").transform;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, lerpValue);
        transform.LookAt(target);
    }
}
