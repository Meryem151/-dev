using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Spawnapplemanager : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject applePrefab;
    public float spawnDelay;
    private float timer;
    private void Update()
    {
        timer += Time.deltaTime;
        //print(timer);
        if(timer > spawnDelay)
        {
            SpawnApple();
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            SpawnApple();
        }
    }
    //public void metodismi
    //private void metodismi
    public void SpawnApple()
    {
        int index = Random.Range(0, spawnPoint.Length);
        Instantiate(applePrefab, spawnPoint[index].position, Quaternion.identity);
        timer = 0;
    }
}
