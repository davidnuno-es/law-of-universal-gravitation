using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graviton : MonoBehaviour
{

    float G = 667.4f;

    List<Graviton> gravitons = new List<Graviton>();

    Rigidbody rb;

    // Start is called before the first frame update
    void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
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
        Rigidbody target = graviton.rb;
        Vector3 direction = rb.position - target.position;
        float distance = direction.magnitude;
        if(distance == 0)
        {
            return;
        }
        float forceMagnitude = G * (rb.mass * target.mass) / Mathf.Pow(distance, 2);
        target.AddForce(direction.normalized * forceMagnitude);
    }
}
