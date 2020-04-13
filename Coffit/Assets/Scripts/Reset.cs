using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

    public Vector3 startPosition;

    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKey ("r")) {
            print ("Reset");
            startPosition = new Vector3 (0f, 2f, 5f);
            transform.position = startPosition;
        }
    }

    void Inicio () {
        startPosition = transform.position;
    }
}