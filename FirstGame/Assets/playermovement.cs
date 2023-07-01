using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class playermovement : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
         Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         mousePosition.z = transform.position.z;
         //transform.position = Vector3.MoveTowards(transform.position, mousePosition, 1);
         transform.position = mousePosition;
    }
}
