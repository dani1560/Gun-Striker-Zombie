using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Zombie"))
        {
            if (collision.collider.gameObject.name.Contains("Head"))
            {
                collision.gameObject.GetComponent<MoveTowards>().head_zombie++;

                if (collision.gameObject.GetComponent<MoveTowards>().head_zombie == 1)
                {
                    Debug.Log(collision.gameObject.name + " - head - ");
                    collision.gameObject.GetComponent<MoveTowards>().a = 1;
                    collision.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.SetActive(true);
                    collision.gameObject.GetComponent<Animator>().Play("Z_FallingBack");
                    collision.gameObject.GetComponent<MoveTowards>().body_zombbie = 11;
                }
                    
            }
            else if (collision.collider.gameObject.name.Contains("Body"))
            {
                collision.gameObject.GetComponent<MoveTowards>().body_zombbie++;

                if (collision.gameObject.GetComponent<MoveTowards>().body_zombbie <= 10)
                {
                    collision.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                    collision.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(true);
                }

                if (collision.gameObject.GetComponent<MoveTowards>().body_zombbie == 10)
                {
                    Debug.Log(collision.gameObject.name + " - body - ");
                    collision.gameObject.GetComponent<MoveTowards>().a = 1;
                    collision.gameObject.GetComponent<Animator>().Play("Z_FallingForward");
                }
               
            }
        }

    }
}

