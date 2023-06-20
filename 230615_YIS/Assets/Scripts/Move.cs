using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    bool isChange = false;
    bool isChange1= false;
    bool isChange2= false;
    bool isChange3 = false;

    void Update()
    {
        float posY = this.transform.position.y; //this는 sqaure 객체를 불러옴 transform은 말 그대로 바꾼다 무엇을? position(위치)
        float posX = this.transform.position.x;

        if (this.transform.position.y >= 2f)
        {
            isChange = true;
        }
        else if (this.transform.position.y <= -2f)
        {
            isChange = false;
        }

        if (isChange)
        {
            this.transform.position += new Vector3(2f * Time.deltaTime, 0, 0);
        }
        else
        {
            this.transform.position += new Vector3(0, 2f * Time.deltaTime, 0);
        }







        if (this.transform.position.x >= 2f)
        {
            isChange1 = true;
        }
        else if(this.transform.position.x <= -2f)
        {
            isChange1 = false;
        }

        if (isChange1)
        {
            this.transform.position += new Vector3(0, -2f * Time.deltaTime, 0);
        }
        else
        {

        }

    }
}
