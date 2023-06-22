using System;

public class Enemy 
{
    private String name; 
    private int hp;


    public Enemy(String name, int hp)  // »ý¼ºÀÚ
    {
        this.name = name;
        this.hp = hp;
    }
    public void GetEnemyInfo()
    {
        UnityEngine.Debug.Log($"name : {this.name} attack: {this.hp}");
    }

}
