using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LOGINMANAGER : MonoBehaviour
{
    public string Contras = "prit";
    public InputField IngresarContraseña;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Contra()
    {
        if(IngresarContraseña.text == Contras)
        {
            Debug.Log("Access granted");
        }
        else
        {
            Debug.Log("Access Denied");
        }
    }
}
