using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBJETOMANAGER : MonoBehaviour
{
    int index = -1;
    public objetoBehaviour[] objetos;
    void Start()
    {
        deactivateAll();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            activateNext();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            activatePrevious();
        }
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
        index++;
        if (index == objetos.Length)
        {
            index = 0;
        }
        objetos[index].gameObject.SetActive(true); 
    }

    public void activatePrevious()
    {
        deactivateAll();
        index--;
        if (index < 0)
        {
            index = objetos.Length - 1;
        }
        objetos[index].gameObject.SetActive(true);
    }
}
