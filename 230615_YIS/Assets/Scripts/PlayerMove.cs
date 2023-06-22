using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    int step = 0;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (step == 1)
        {
            if (this.transform.position.x >= 2f)
            {

            }
            else
            {
                player.transform.position += new Vector3(3 * Time.deltaTime, 0, 0);
            }
        }
        if (step == 2)
            if (player.transform.position.x <= 2f)
            {
                player.transform.position += new Vector3(3 * Time.deltaTime, 0, 0);
            }
    }

    public void LeftMove()
    {
        step = 1;
    }

    public void RightMove()
    {


        step = 2;
    }
}