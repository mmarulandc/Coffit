using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol : MonoBehaviour {
    public Vector3 startPosition;
    public int cont = 0;

    void OnTriggerEnter (Collider other) {
        if (cont == 0) {
            print ("Reset");
            startPosition = new Vector3 (0f, 2f, 5f);
            transform.position = startPosition;
            cont++;
        }

    }
    void OnTriggerExit (Collider other) {
      
        cont = 0;
    }
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }
}