using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown("w"))
        {
            Vector3 position = this.transform.position;
            position.y= position.y+10;
            this.transform.position = position;
        }
        if (Input.GetKeyDown("a"))
        {
            Vector3 position = this.transform.position;
            position.x = position.x - 10;
            this.transform.position = position;
        }
        if (Input.GetKeyDown("s"))
        {
            Vector3 position = this.transform.position;
            position.y = position.y - 10;
            this.transform.position = position;
        }
        if (Input.GetKeyDown("d"))
        {
            Vector3 position = this.transform.position;
            position.x = position.x + 10;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.z = position.z + 10;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.z = position.z - 10;
            this.transform.position = position;
        }
        

    }
}
