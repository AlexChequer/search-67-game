using UnityEngine;

public class CollectableSpawner : MonoBehaviour
{
    public GameObject collectablePrefab;
    public int totalCollectables = 8;

    public float minX = -4f;
    public float maxX = 4f;
    public float minY = -2f;
    public float maxY = 2f;

    void Start()
    {
        for (int i = 0; i < totalCollectables; i++)
        {
            float x = Random.Range(minX, maxX);
            float y = Random.Range(minY, maxY);
            Instantiate(collectablePrefab, new Vector3(x, y, 0), Quaternion.identity);
        }
    }
}