using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravitymodifier : MonoBehaviour
{
 
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) {
            Physics.gravity = new Vector3(0, 9.8f, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Physics.gravity = new Vector3(0, -9.8f, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Physics.gravity = new Vector3(0,0 , 9.8f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Physics.gravity = new Vector3(0, 0, -9.8f);
        }
    }
}
