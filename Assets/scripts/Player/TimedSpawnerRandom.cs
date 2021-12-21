using Photon.Pun;
using System.Collections;
using UnityEngine;

/**
 * This component instantiates a given prefab at random time intervals and random bias from its object position.
 */
public class TimedSpawnerRandom: MonoBehaviourPunCallbacks
{
    [SerializeField] GameObject prefabToSpawn;
    [SerializeField] Vector3 velocityOfSpawnedObject;
    [Tooltip("Minimum time between consecutive spawns, in seconds")] [SerializeField] float minTimeBetweenSpawns = 1f;
    [Tooltip("Maximum time between consecutive spawns, in seconds")] [SerializeField] float maxTimeBetweenSpawns = 3f;
    [Tooltip("Maximum distance in X between spawner and spawned objects, in meters")] [SerializeField] float maxXDistance = 0.5f;
    [SerializeField] private int timeToDestroy;
    void Start() {
        this.StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine() {
        while (true) {
            float timeBetweenSpawns = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            yield return new WaitForSeconds(timeBetweenSpawns);
            Vector3 positionOfSpawnedObject = new Vector3(
                transform.position.x + Random.Range(-maxXDistance, +maxXDistance),
                transform.position.y,
                transform.position.z + Random.Range(-maxXDistance, +maxXDistance));
            GameObject newObject = PhotonNetwork.Instantiate(prefabToSpawn.name, positionOfSpawnedObject, Quaternion.identity);
            yield return new WaitForSeconds(timeToDestroy);
            if (newObject != null)
                Destroy(newObject);


        }
    }
}
