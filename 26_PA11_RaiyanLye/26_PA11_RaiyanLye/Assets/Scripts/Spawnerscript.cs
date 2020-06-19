using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject SpawnObjectRed;
    public GameObject SpawnObjectGreen;
    public GameObject SpawnObjectBrown;

    public float spawnRate = 2f;

    float nextSpawn = 0f;

    int WhatToSpawn;
    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            WhatToSpawn = Random.Range(1, 4);
            //print(WhatToSpawn);
            nextSpawn = Time.time + spawnRate;
            switch (WhatToSpawn)
            {
                case 1:
                    PositionY = Random.Range(4, -4f);
                    this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
                    Instantiate(SpawnObjectRed, transform.position, transform.rotation);
                    break;

                case 2:
                    PositionY = Random.Range(4, -4f);
                    this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
                    Instantiate(SpawnObjectGreen, transform.position, transform.rotation);
                    break;

                case 3:
                    PositionY = Random.Range(4, -4f);
                    this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
                    Instantiate(SpawnObjectBrown, transform.position, transform.rotation);
                    break;
            }
        }
    }
}
