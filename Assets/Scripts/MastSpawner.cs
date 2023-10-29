using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MastSpawner : MonoBehaviour
{
    [SerializeField] private GameObject mastPrefab;
    [SerializeField] private Transform player, lastMast, ship;
    private Transform obstacleTransform;
    private Transform coinTransform;
    // Update is called once per frame
 
    private void Start()
    {
    }

    void Update()
    {
        if (Vector2.Distance(new Vector2(0, player.position.y),
            new Vector2(0, lastMast.position.y)) <= 5f)
        {
            GameObject spawnMast = Instantiate(mastPrefab,
                new Vector2(0, lastMast.GetChild(0).position.y),
                Quaternion.identity);
            spawnMast.transform.parent = ship;
            SetTransformCoin(spawnMast);
            SetTransformObstacle(spawnMast);
            lastMast = spawnMast.transform;
        }
    }

    private void SetTransformObstacle(GameObject spawnMast)
    {
        int randomNumber = Random.Range(0, 2) * 2 - 1;

        obstacleTransform = spawnMast.transform.Find("Obstacle");
        if (obstacleTransform)
        {
            obstacleTransform.transform.position = new Vector3(obstacleTransform.position.x * randomNumber, obstacleTransform.position.y,
                obstacleTransform.position.z);
        }
    }
    private void SetTransformCoin(GameObject spawnMast)
    {

        int randomNumber = Random.Range(0, 2) * 2 - 1;
        coinTransform = spawnMast.transform.Find("Coin");
        if (coinTransform)
        {
            coinTransform.transform.position = new Vector3(coinTransform.position.x* randomNumber, coinTransform.position.y,
                coinTransform.position.z);
        }
    }
}
