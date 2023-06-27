using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private string name;
    private string job;
    private int hp;
    private int atk;

    public Character(string v1, string v2, int v3, int v4)
    {
        this.name = v1;
        this.job = v2;
        this.hp = v3;
        this.atk = v4;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
