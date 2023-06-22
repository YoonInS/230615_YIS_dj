using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    int a;

    int[] ary = new int[10];

    Enemy[] enemyList = new Enemy[10]; //배열

    List<int> listNum = new List<int>(); // 리스트

    List<Enemy> eList = new List<Enemy>();

    private void Start()
    {
       // eList[0] = new Enemy("name", 10); // 1번쨰 방법

       // eList.Add(new Enemy("name", 10)); // 2번째 방법

      //  Enemy e = new Enemy("test", 1); // 3번쨰 방법 가장 많이 씀 
        //eList.Add(e);
        //eList[0] = e;


        for(int i = 0; i<enemyList.Length; i++) //배열
        {
            Enemy e = new Enemy("elf", i);
            e.GetEnemyInfo();
         //  enemyList[0] = new Enemy($"ai_{i}", i + 10);

         //  enemyList[i].GetEnemyInfo();              
        }
        Enemy e1 = new Enemy("elf", 10);
        Enemy e2 = new Enemy("dragon", 100);

        e1.GetEnemyInfo();
        e2.GetEnemyInfo();
    }
    
}
