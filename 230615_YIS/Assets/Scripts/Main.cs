using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    int a;

    int[] ary = new int[10];

    Enemy[] enemyList = new Enemy[10]; //�迭

    List<int> listNum = new List<int>(); // ����Ʈ

    List<Enemy> eList = new List<Enemy>();

    private void Start()
    {
       // eList[0] = new Enemy("name", 10); // 1���� ���

       // eList.Add(new Enemy("name", 10)); // 2��° ���

      //  Enemy e = new Enemy("test", 1); // 3���� ��� ���� ���� �� 
        //eList.Add(e);
        //eList[0] = e;


        for(int i = 0; i<enemyList.Length; i++) //�迭
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
