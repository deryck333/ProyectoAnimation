using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camaras : MonoBehaviour
{
    public GameObject[] listaCamaras;
    // Start is called before the first frame update
    void Start()
    {
        listaCamaras[0].gameObject.SetActive(true);
        listaCamaras[1].gameObject.SetActive(false);
        listaCamaras[2].gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            listaCamaras[0].gameObject.SetActive(true);
            listaCamaras[1].gameObject.SetActive(false);
            listaCamaras[2].gameObject.SetActive(false);
            Debug.Log("Tecla 1");
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            listaCamaras[0].gameObject.SetActive(false);
            listaCamaras[1].gameObject.SetActive(true);
            listaCamaras[2].gameObject.SetActive(false);
            Debug.Log("Tecla 2");
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            listaCamaras[0].gameObject.SetActive(false);
            listaCamaras[1].gameObject.SetActive(false);
            listaCamaras[2].gameObject.SetActive(true);
            Debug.Log("Tecla 3");
        }
    }
}
