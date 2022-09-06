using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.gameObject.name == "Z_Body")
        {
            MoveTowards.body++;
            Debug.Log("body =>" + MoveTowards.body);

            if (MoveTowards.body == 10)
            {
                MoveTowards.a = 1;
            }
        }
        else if (collision.collider.gameObject.name == "Z_Head") {

            MoveTowards.a = 2;
        }
    }
}
