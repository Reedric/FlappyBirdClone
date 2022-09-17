using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnTime = 1.25F;

    float spawnTimer;
    public float pipeRange = 4.5F;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0) {
            spawnTimer = spawnTime;
            GameObject newPipe = Instantiate(pipePrefab, this.transform.position, Quaternion.identity);
            newPipe.transform.position += new Vector3(7, Random.Range(-pipeRange, pipeRange), 7);
        }
    }
}
