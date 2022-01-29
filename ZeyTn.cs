using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeyTn : MonoBehaviour
{
    // Start is called before the first frame update



    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            { 
               Debug.Log("Hello Grybbbb!");
            }
        }
    }

}
