using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platform_Prefab;
    public GameObject spike_Platform_Prefab;
    public GameObject breakable_Platform_Prefab;
    public GameObject[] moving_Platforms;


    public float spawn_Timer = 2f;

    private float current_Platform_Timer;

    private int platform_Spawn_Count;

    public float min_X = -2.6f, max_X = 2.6f ;


    public void Start()
    {
        current_Platform_Timer = spawn_Timer;
    }


    public void Update()
    {
        SpawnPlatforms();
    }

    private void SpawnPlatforms()
    {
        current_Platform_Timer += Time.deltaTime;

        if (current_Platform_Timer >= spawn_Timer)
        {
            platform_Spawn_Count++;

            Vector3 temp  = transform.position;
            temp.x = UnityEngine.Random.Range(min_X, max_X);

            GameObject newPlatform = null;

            if (platform_Spawn_Count < 2)
            {
                newPlatform = Instantiate(platform_Prefab, temp, Quaternion.identity);
            }
            else if (platform_Spawn_Count == 2)
            {
                if (UnityEngine.Random.Range(0, 2) > 0)
                {
                    newPlatform = Instantiate(platform_Prefab, temp, Quaternion.identity);
                }

                else
                {
                    newPlatform = Instantiate(moving_Platforms[UnityEngine.Random.Range(0, moving_Platforms.Length)], temp, Quaternion.identity);
                }
            }

            else if (platform_Spawn_Count == 3)
            {

                if (UnityEngine.Random.Range(0, 2) > 0)
                {
                    newPlatform = Instantiate(platform_Prefab, temp, Quaternion.identity);
                }

                else
                {
                    newPlatform = Instantiate(spike_Platform_Prefab, temp, Quaternion.identity);
                }
            }


            else if (platform_Spawn_Count == 4)
            {

                if (UnityEngine.Random.Range(0, 2) > 0)
                {
                    newPlatform = Instantiate(platform_Prefab, temp, Quaternion.identity);
                }

                else
                {
                    newPlatform = Instantiate(breakable_Platform_Prefab, temp, Quaternion.identity);
                }

                platform_Spawn_Count = 0;
            }

            newPlatform.transform.parent = transform;
            current_Platform_Timer = 0f;
        }
    }
}

