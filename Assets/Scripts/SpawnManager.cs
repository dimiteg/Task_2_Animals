
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnRangeX = 20;
    public float spawnRangeZ = 20;
    private float startDelay = 2f;
    private float spawnIneterval = 1.5f;
    
    void Start(){
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnIneterval);
    }

    void SpawnRandomAnimal(){
        
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX), 0, spawnRangeZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
