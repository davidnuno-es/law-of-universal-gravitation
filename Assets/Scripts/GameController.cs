using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject prefab;

    // Start is called before the first frame update
    void OnEnable()
    {
        for(int i = 0; i < SceneInfo.objectsCount; i++)
        {
            CreateGraviton(Random.Range(0.1f, SceneInfo.commonMass));
        }
    }

    private void CreateGraviton(float mass = 1)
    {
        GameObject o = Instantiate(prefab, GetRandomPosition(), Quaternion.identity);
        o.GetComponent<Graviton>().mass = mass;
        o.transform.parent = transform;
    }

    private Vector3 GetRandomPosition()
    {
        return new Vector3(GetPosition(), GetPosition(), GetPosition());
    }

    private float GetPosition()
    {
        return Random.Range(-SceneInfo.spawnRadius, SceneInfo.spawnRadius);
    }
}
