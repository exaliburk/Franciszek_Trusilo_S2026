using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ĆwiczenieAxis : MonoBehaviour
{
    bool follow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            follow = !follow;
        }

        if (follow)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) - Vector3.back * 10;
        }
    }
}
