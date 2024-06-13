using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personajeScript : MonoBehaviour
{
    public int nivelHambre;
    
    void tomarAlimento(int valorAlimentario)
    {
        nivelHambre -= valorAlimentario;
    }

    private void OnTriggerEnter(Collider other)
    {
        alimentoScript alimento = other.GetComponent<alimentoScript>();
        if (alimento)
        {
            tomarAlimento(alimento.valorAlimentario);
            Destroy(other.gameObject);
        }
    }
}
