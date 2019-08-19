using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float timer;
    private float s_timer;

    public Transform spawnPoint;

    public GameObject whatToSpawn;

    public bool spawnAtStart = true;

    // Start is called before the first frame update
    void Start()
    {
        s_timer = timer;

        if (spawnAtStart)
        {
            Instantiate(whatToSpawn, spawnPoint.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        s_timer -= Time.deltaTime;

        if (s_timer <= 0)
        {
            s_timer = timer;
            Instantiate(whatToSpawn, spawnPoint.position, Quaternion.identity);
        }
    }
}
