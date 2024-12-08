using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollisionDetect : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score = 0;
    public Transform[] spawnSepet;
    public GameObject sepetPrefab;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("apple"))
        {
            Destroy(other.gameObject);
            score ++;
            scoreText.SetText(score.ToString());
            SpawnSepet();
        }
    }
    public void SpawnSepet()
    {
        int index = Random.Range(0, spawnSepet.Length);
        Instantiate(sepetPrefab, spawnSepet[index].position, Quaternion.identity);
    }
}




