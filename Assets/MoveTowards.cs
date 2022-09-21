using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    GameObject player;
    [SerializeField]
    float distance;
    public int a;
    public int body_zombbie = 0;
    public int head_zombie = 0;
    Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        anim = gameObject.GetComponent<Animator>();
        //zombieBlood = this.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {


        distance = Vector3.Distance(player.transform.position, gameObject.transform.position);

        if (a == 0)
        {

            if (distance < 1.5f)
            {
                transform.LookAt(player.transform);
                anim.StopPlayback();
                anim.Play("Z_Attack");
            }
            else if (distance < 40f)
            {
                transform.LookAt(player.transform);
                gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, player.transform.position, 9.5f * Time.deltaTime);
                anim.StopPlayback();
                anim.Play("Z_Run");
            }
            else
            {
                anim.StopPlayback();
                anim.Play("Z_Walk1");
                gameObject.transform.Translate(Vector3.forward * 0.4f * Time.deltaTime, Space.Self);

            }
    

        }
        /*if (a == 1)
         {
             bodyZombie.SetActive(true);
             anim.StopPlayback();
             anim.Play("Z_FallingForward");
             a = 3;
             body = 11;

         }
         else if (a == 2)
         {
             headZombie.SetActive(true);
             anim.StopPlayback();
             anim.Play("Z_FallingBack");
             a = 3;
             body = 11;
         }
        */
    }

  
    private void OnCollisionEnter(Collision collision)
    {
        /*if (collision.gameObject.name.Contains("bullet"))
        {
            *//*if (BulletCollision.zom.name == gameObject.name)
            {
                a = 1;

                Debug.Log(gameObject.name + "Zombie Destroy - " + anim);
            }*//*
            //BulletCollision.zom.GetComponent<Animator>().Play("Z_FallingBack");
            //Destroy(BulletCollision.zom);

        }*/

    }
}
