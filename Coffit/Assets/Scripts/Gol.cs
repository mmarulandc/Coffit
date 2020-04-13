using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gol : MonoBehaviour {
    public Vector3 startPosition;
    public int cont = 0;
    public Text puntuacion;

    void OnTriggerEnter (Collider other) {

            print ("Reset");
            startPosition = new Vector3 (0f, 2f, 5f);
            transform.position = startPosition;
            cont++;
            puntuacion.text = "Puntuacion: "+ cont;

    }
    void OnTriggerExit (Collider other) {


    }
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }
}