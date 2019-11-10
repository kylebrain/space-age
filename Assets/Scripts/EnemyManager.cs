using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject EnemyParent;
    public Camera CombatCamera;
    public GameObject EnemyPrefab;

    public float spawnRate;
    float timeAccumulator;

    void Start()
    {
        spawnRate = 1f;
        timeAccumulator = 0.0f;
    }

    void FixedUpdate()
    {
        timeAccumulator += Time.fixedDeltaTime;
        while (timeAccumulator > 1.0f / spawnRate)
        {
            timeAccumulator -= 1.0f / spawnRate;
            Vector3 newPos = Pilot.instance.transform.position + Quaternion.Euler(0, Random.Range(-180f, 180f), 0) * new Vector3(0, 0, 2 * CombatCamera.orthographicSize);
            GameObject cur = Instantiate(EnemyPrefab, newPos, Quaternion.Euler(90, 0, 0), EnemyParent.transform);
            cur.GetComponent<EnemyDamageable>().maxHealth = 10 + (int)(Time.timeSinceLevelLoad / 15f);
        }
    }
}
