using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBJETOMANAGER : MonoBehaviour
{
    public int index = 0;
    public objetoBehaviour[] objetos;
    void Start()
    {
        deactivateAll();
        InvokeRepeating(nameof(activateNext), 1, 3);
    }
    public void deactivateAll()
    {
        foreach (objetoBehaviour objeto in objetos)
        {
            objeto.gameObject.SetActive(false);
        }
    }

    public void activateNext()
    {
        deactivateAll();
        objetos[index].gameObject.SetActive(true);
        index++;
        if (index == objetos.Length)
        {
            index = 0;
        }
    }
}
