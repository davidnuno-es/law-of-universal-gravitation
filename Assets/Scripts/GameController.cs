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
    
    // Start is called before the first frame update
    void OnEnable()
    {
        for(int i = 0; i < count; i++)
        {
            CreateGraviton();
        }
    }

    private void CreateGraviton()
    {
        Vector3 position = new Vector3(Random.Range(-radiusLength, radiusLength), Random.Range(-radiusLength, radiusLength), Random.Range(-radiusLength, radiusLength));
        GameObject o = Instantiate(prefab, position, Quaternion.identity);
        o.transform.parent = transform;
    }
}
