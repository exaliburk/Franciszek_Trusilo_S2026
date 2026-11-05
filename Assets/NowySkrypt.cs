using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NowySkrypt : MonoBehaviour
{
    public List<GameObject> lista_obiektów = new List<GameObject>();
    public Gradient gr;
    public List<SpriteRenderer> lista_spritów = new List<SpriteRenderer>();
    public List<GameObject> lista_spin = new List<GameObject>();

    public void Cube(Transform transformCube)
    {
        transformCube.rotation = Quaternion.Euler(transformCube.position.x*36, 0, 0);
    }


    //Funkcja do zmiany koloru gradientu
    void SpriteColorChange(SpriteRenderer sprite)
    {
        sprite.color = gr.Evaluate(sprite.gameObject.transform.position.y/100);
    }
   
    //Funkcja SortObj, która sortuje obiekty (2d/3d) i wykorzystuje funkcje Debug2d/Debug3d do printowania wyniku
    void SortObj()
    {
        foreach (GameObject go in lista_obiektów)

        {
            if (go.GetComponent<SpriteRenderer>() != null)
            {
                Debug2d(go.GetComponent<SpriteRenderer>());
            }
            else if (go.GetComponent<MeshRenderer>() != null)
            {
                Debug3d(go.GetComponent<Transform>());
            }
        }
    }
    
    //Funkcja Debug3d która printuje, ¿e obiekt jest 3d
    public void Debug3d(Transform obiekt3d)
    {
        Debug.Log("Obiekt " + obiekt3d.name + " jest 3D");
    }

    //Funkcja Debug2d która printuje, ¿e obiekt jest 2d
    public void Debug2d(SpriteRenderer obiekt2d)
    {
        Debug.Log("Obiekt " + obiekt2d.name + " jest 2D");
    }


    //void Start
    void Start()
    {
        SortObj();
    }

    //void Update
    void Update()
    {
        foreach (GameObject GO in lista_spin)
        {
         Cube(GO.transform);
        }
    }
}
