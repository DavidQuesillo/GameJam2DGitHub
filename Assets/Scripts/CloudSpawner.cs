using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public float SpawnTimer;
    public float TimerMin;
    public float TimerMax;
    public GameObject PrefabCloud;
    private Vector3 SpawnPosition = new Vector3 (0, -6.5f, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTimer -= Time.deltaTime;
        if (SpawnTimer <= 0)
        {
            SpawnPosition.x = Random.Range(-3f, 3f);
            Instantiate(PrefabCloud, SpawnPosition, new Quaternion (0f, 0f, 0f, 0f));
            SpawnTimer = Random.Range(TimerMin, TimerMax);
        }
    }
}
