using UnityEngine;

public class Pipe_Spawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 5.0f; //nb of time between each spawn
    public float timer = 0;
    public float pipeHightOffset = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }

    }
    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - pipeHightOffset;
        float hightestPoint = transform.position.y + pipeHightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range (lowestPoint,hightestPoint), 0), transform.rotation);
    }
}
