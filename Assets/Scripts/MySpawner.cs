using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySpawner : MonoBehaviour
{
   public Enemy enemyPrefab;
   public List<Transform> spawnPoint = new List<Transform>();
   //public Transform[] spawnPoints;
   
   private void Start()
   {
      for (int i = 0; i < 10; i++)
      {
         SpawnAtRandomPos();
      }
   }

   private void SpawnAtRandomPos()
   {
      Vector3 randomPos = spawnPoint[UnityEngine.Random.Range(0, spawnPoint.Count)].position;
      
      Enemy enemy = Instantiate(enemyPrefab, randomPos, Quaternion.identity);
      enemy.onDeath += SpawnAtRandomPos;
   }
}
