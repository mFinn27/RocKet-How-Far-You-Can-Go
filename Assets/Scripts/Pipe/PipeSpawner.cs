using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float spawnRate;
    private float timer = 0;

    private void Start()
    {
        Spawner();
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            Spawner();
            timer = 0f;
        }
    }

    private void Spawner()
    {
        float minY = -2f;
        float maxY = 0.5f;
        Vector3 randomPos = new Vector3(transform.position.x, Random.Range(minY, maxY), transform.position.z);
        Instantiate(pipePrefab, randomPos, Quaternion.identity);
    }
}
