using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graviton : MonoBehaviour
{

    List<Graviton> gravitons = new List<Graviton>();

    // Start is called before the first frame update
    void OnEnable()
    {
        Graviton[] tmp = FindObjectsOfType<Graviton>();
        foreach(Graviton graviton in tmp)
        {
            if(graviton != this)
            {
                gravitons.Add(graviton);
            }
        }
    }

    void FixedUpdate()
    {
        foreach(Graviton graviton in gravitons)
        {
            Attract(graviton);
        }
    }

    private void Attract(Graviton graviton)
    {
       
    }
}
