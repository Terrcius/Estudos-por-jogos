using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoZumbi : MonoBehaviour
{
    public GameObject Jogador;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition
            (GetComponent<Rigidbody>().position + Jogador.transform.position);
    }
}
