using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject prefab;
    public GameObject infoPanel;

    // Start is called before the first frame update
    void OnEnable()
    {
        for(int i = 0; i < SceneInfo.objectsCount; i++)
        {
            CreateGraviton(Random.Range(0.1f, SceneInfo.commonMass));
        }
    }

    private void OnDisable()
    {
       Graviton [] gos = FindObjectsOfType<Graviton>();
       foreach(Graviton g in gos)
        {
            Destroy(g);
        }
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.I))
        {
            if(infoPanel.active == true)
            {
                FindObjectOfType<InfoPanel>().Close();

            }
            else
            {
                FindObjectOfType<InfoPanel>().Open();
            }
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            FindObjectOfType<ReturnToMainScene>().ReturnToMainMenu();
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
