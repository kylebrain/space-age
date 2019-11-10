using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TerrainManager : MonoBehaviour
{
    public GameObject TerrainParent;
    public Camera CombatCamera;
    public GameObject AsteroidPrefab;

    float minX;
    float maxX;
    float minZ;
    float maxZ;
    Vector3 prevPos;
    List<GameObject> spawnedTerrain;
    int maxSpawnedTerrain;

    float seed;

    void Awake()
    {
        seed = System.DateTime.Now.Millisecond;
    }

    void Start()
    {
        maxX = CombatCamera.orthographicSize * (16f / 9f) / 2.0f + 20f;
        minX = -maxX;
        maxZ = CombatCamera.orthographicSize + 20f;
        minZ = -maxZ;
        prevPos = Vector3.zero;
        spawnedTerrain = new List<GameObject>();
        maxSpawnedTerrain = 10000;
    }


    public void OnMove(Vector3 pos)
    {
        Vector3 diff = pos - prevPos;
        prevPos = pos;
        const int density = 999;
        if (pos.x + CombatCamera.orthographicSize * (16f / 9f) / 2 > maxX)
        {
            maxX += diff.x;
            int numPoints = (int)(5 * (maxZ - minZ) / CombatCamera.orthographicSize);
            for (int i = 0; i < numPoints; ++i)
            {
                float curZ = Mathf.Lerp(minZ, maxZ, (float)i / numPoints);
                if (Random.Range(0, 1000) >= density)
                {
                    GameObject cur = Instantiate(AsteroidPrefab, new Vector3(maxX, 0, curZ), Quaternion.Euler(90, Random.Range(-180, 180), 0), TerrainParent.transform);
                    spawnedTerrain.Add(cur);
                    while (spawnedTerrain.Count > maxSpawnedTerrain)
                    {
                        Destroy(spawnedTerrain.ElementAt(0));
                        spawnedTerrain.RemoveAt(0);
                    }
                }
            }
        }
        else if (pos.x - CombatCamera.orthographicSize * (16f / 9f) / 2 < minX)
        {
            minX += diff.x;
            int numPoints = (int)(5 * (maxZ - minZ) / CombatCamera.orthographicSize);
            for (int i = 0; i < numPoints; ++i)
            {
                float curZ = Mathf.Lerp(minZ, maxZ, (float)i / numPoints);
                if (Random.Range(0, 1000) >= density)
                {
                    GameObject cur = Instantiate(AsteroidPrefab, new Vector3(minX, 0, curZ), Quaternion.Euler(90, Random.Range(-180, 180), 0), TerrainParent.transform);
                    spawnedTerrain.Add(cur);
                    while (spawnedTerrain.Count > maxSpawnedTerrain)
                    {
                        Destroy(spawnedTerrain.ElementAt(0));
                        spawnedTerrain.RemoveAt(0);
                    }
                }
            }
        }
        if (pos.z + CombatCamera.orthographicSize > maxZ)
        {
            maxZ += diff.z;
            int numPoints = (int)(5 * (maxX - minX) / (CombatCamera.orthographicSize * (16f / 9f) / 2));
            for (int i = 0; i < numPoints; ++i)
            {
                float curX = Mathf.Lerp(minX, maxX, (float)i / numPoints);
                if (Random.Range(0, 1000) >= density)
                {
                    GameObject cur = Instantiate(AsteroidPrefab, new Vector3(curX, 0, maxZ), Quaternion.Euler(90, Random.Range(-180, 180), 0), TerrainParent.transform);
                    spawnedTerrain.Add(cur);
                    while (spawnedTerrain.Count > maxSpawnedTerrain)
                    {
                        Destroy(spawnedTerrain.ElementAt(0));
                        spawnedTerrain.RemoveAt(0);
                    }
                }
            }
        }
        else if (pos.z - CombatCamera.orthographicSize < minZ)
        {
            minZ += diff.z;
            int numPoints = (int)(5 * (maxX - minX) / (CombatCamera.orthographicSize * (16f / 9f) / 2));
            for (int i = 0; i < numPoints; ++i)
            {
                float curX = Mathf.Lerp(minX, maxX, (float)i / numPoints);
                if (Random.Range(0, 1000) >= density)
                {
                    GameObject cur = Instantiate(AsteroidPrefab, new Vector3(curX, 0, minZ), Quaternion.Euler(90, Random.Range(-180, 180), 0), TerrainParent.transform);
                    spawnedTerrain.Add(cur);
                    while (spawnedTerrain.Count > maxSpawnedTerrain)
                    {
                        Destroy(spawnedTerrain.ElementAt(0));
                        spawnedTerrain.RemoveAt(0);
                    }
                }
            }
        }
    }



}

