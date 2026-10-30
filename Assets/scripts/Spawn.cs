using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject SpawnPrefab;
    public Vector2 spawnPosition;
    public float delay = 2f;
    public float TiempoRepeticion = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     InvokeRepeating("CrearObstaculo", delay, TiempoRepeticion);
    }

    // Update is called once per frame
    void CrearObstaculo()
    {
       Instantiate(SpawnPrefab, spawnPosition, Quaternion.identity);
    }
}
