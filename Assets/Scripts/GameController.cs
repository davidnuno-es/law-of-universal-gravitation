using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject prefab;

    [Range(2, 60)]
    public int count = 2;
    [Range(10, 1000)]
    public float radiusLength = 10;

    [Range(1, 100)]
    public float commonMass = 5;

    // Start is called before the first frame update
    void OnEnable()
    {
        for(int i = 0; i < count; i++)
        {
            CreateGraviton(Random.Range(0.1f, commonMass));
        }
    }

    private void CreateGraviton(float mass = 1)
    {
        Vector3 position = new Vector3(Random.Range(-radiusLength, radiusLength), Random.Range(-radiusLength, radiusLength), Random.Range(-radiusLength, radiusLength));
        GameObject o = Instantiate(prefab, position, Quaternion.identity);
        o.GetComponent<Graviton>().mass = mass;
        o.transform.parent = transform;
    }
}
