using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetEsfera : MonoBehaviour
{

    Vector3 posicionInicial;
    private void Awake()
    {
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger)) { 
            transform.position = posicionInicial;
        }
    }
}
