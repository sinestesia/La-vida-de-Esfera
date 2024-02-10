using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporizadorBola : MonoBehaviour
{
    private Rigidbody rb;
    public float temporizador;
    public float tiempoTranscurrido;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        tiempoTranscurrido += Time.deltaTime;
        if (tiempoTranscurrido > temporizador) {
            rb.useGravity = true;
        }
    }
}
