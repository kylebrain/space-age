using System.Collections;
using System.Collections.Generic;
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
    }


    public void OnMove(Vector3 pos)
    {
        Vector3 diff = pos - prevPos;
        prevPos = pos;
        const float density = 1.0f;
        if (pos.x + CombatCamera.orthographicSize * (16f / 9f) / 2 > maxX)
        {
            maxX += diff.x;
            int numPoints = (int)(100 * (maxZ - minZ) / CombatCamera.orthographicSize);
            for (int i = 0; i < numPoints; ++i)
            {
                float curZ = Mathf.Lerp(minZ, maxZ, (float)i / numPoints);
                if (Mathf.PerlinNoise(seed + maxX, seed + curZ) >= density)
                {
                    Instantiate(AsteroidPrefab, new Vector3(maxX, 0, curZ), Quaternion.Euler(90, Random.Range(-180, 180), 0), TerrainParent.transform);
                }
            }
        }
        else if (pos.x - CombatCamera.orthographicSize * (16f / 9f) / 2 < minX)
        {
            minX += diff.x;
            int numPoints = (int)(100 * (maxZ - minZ) / CombatCamera.orthographicSize);
            for (int i = 0; i < numPoints; ++i)
            {
                float curZ = Mathf.Lerp(minZ, maxZ, (float)i / numPoints);
                if (Mathf.PerlinNoise(seed + minX, seed + curZ) >= density)
                {
                    Instantiate(AsteroidPrefab, new Vector3(minX, 0, curZ), Quaternion.Euler(90, Random.Range(-180, 180), 0), TerrainParent.transform);
                }
            }
        }
        if (pos.z + CombatCamera.orthographicSize > maxZ)
        {
            maxZ += diff.z;
            int numPoints = (int)(100 * (maxX - minX) / (CombatCamera.orthographicSize * (16f / 9f) / 2));
            for (int i = 0; i < numPoints; ++i)
            {
                float curX = Mathf.Lerp(minX, maxX, (float)i / numPoints);
                if (Mathf.PerlinNoise(seed + curX, seed + maxZ) >= density)
                {
                    Instantiate(AsteroidPrefab, new Vector3(curX, 0, maxZ), Quaternion.Euler(90, Random.Range(-180, 180), 0), TerrainParent.transform);
                }
            }
        }
        else if (pos.z - CombatCamera.orthographicSize < minZ)
        {
            minZ += diff.z;
            int numPoints = (int)(100 * (maxX - minX) / (CombatCamera.orthographicSize * (16f / 9f) / 2));
            for (int i = 0; i < numPoints; ++i)
            {
                float curX = Mathf.Lerp(seed + minX, seed + maxX, (float)i / numPoints);
                if (Mathf.PerlinNoise(curX, minZ) >= density)
                {
                    Instantiate(AsteroidPrefab, new Vector3(curX, 0, minZ), Quaternion.Euler(90, Random.Range(-180, 180), 0), TerrainParent.transform);
                }
            }
        }
    }



}

