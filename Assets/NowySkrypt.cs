using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NowySkrypt : MonoBehaviour
{
    public List<GameObject> lista_obiektów = new List<GameObject>();
    
    

    // Start is called before the first frame update
    void Start()
    {
        SortObj();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SortObj()
    {
        foreach (GameObject go in lista_obiektów)

        {
            if (go.GetComponent<SpriteRenderer>() != null)
            {
                Debug.Log(go.name + " 2D");
            }
            else if (go.GetComponent<MeshRenderer>() != null)
            {
                Debug.Log(go.name + " 3D");
            }
        }
    }
}
