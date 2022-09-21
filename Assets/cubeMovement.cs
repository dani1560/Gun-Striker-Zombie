using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cubeMovement : MonoBehaviour
{
    float runing;
    public float a;
    Rigidbody rg;
    public GameObject PlayerWalkAudio;
    public GameObject PlayerRunAudio;
    AudioSource playerAudio;
    public float m_Thrust = 0.01f;
    public int playerWalkStatus = 0;
    int audiostatus = 0;

    // Start is called before the first framwwwe update
    void Start()
    {
        runing = 2.8f;
        rg = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        //Player Movement
        if (Input.GetKey(KeyCode.W)) {

          
            if (a == 1) {

                gameObject.transform.Translate(Vector3.forward * 20f * Time.deltaTime, Space.Self);
                playerWalkStatus = 2;
                RunAudioFunc();
            }
            else
            {
                gameObject.transform.Translate(Vector3.forward * 12f * Time.deltaTime, Space.Self);
                playerWalkStatus = 1;
                WalkAudioFunc();
            }
   
        }



            if (Input.GetKey(KeyCode.S))
        {

            if (a == 1)
            {
                gameObject.transform.Translate(Vector3.back * 20f * Time.deltaTime, Space.Self);
                playerWalkStatus = 2;
                RunAudioFunc();
            }
            else
            {
                gameObject.transform.Translate(Vector3.back * 12f * Time.deltaTime, Space.Self);
                playerWalkStatus = 1;
                WalkAudioFunc();
            }

        }
     
        if (Input.GetKey(KeyCode.D))
        {

            if (a == 1)
            {
                gameObject.transform.Translate(Vector3.right * 20f * Time.deltaTime, Space.Self);
                playerWalkStatus = 2;
                RunAudioFunc();
            }
            else
            {
                gameObject.transform.Translate(Vector3.right * 12f * Time.deltaTime, Space.Self);
                playerWalkStatus = 1;
                WalkAudioFunc();
            }

        }
     
        if (Input.GetKey(KeyCode.A))
        {

            if (a == 1)
            {
                gameObject.transform.Translate(Vector3.left * 20f * Time.deltaTime, Space.Self);
                playerWalkStatus = 2;
                RunAudioFunc();
            }
            else
            {
                gameObject.transform.Translate(Vector3.left * 12f * Time.deltaTime, Space.Self);
                playerWalkStatus = 1;
                WalkAudioFunc();
            }


        }

        //on Mouse Up by pressing W
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        {
            PlayerWalkAudio.SetActive(false);
            PlayerRunAudio.SetActive(false);
            audiostatus = 0;
        }
        //-------------------------------

        if (Input.GetKey(KeyCode.LeftShift))
        {

            a = 1;
            audiostatus = 1;


        }
        else {

            a = 0;
          
        }

     /*  if(playerWalkStatus == 1)
        {
            PlayerWalkAudio.SetActive(true);
            playerWalkStatus = 3;
        }*/
       
    }

    void WalkAudioFunc()
    {
        if (audiostatus == 0)
        {
            PlayerRunAudio.SetActive(false);
            PlayerWalkAudio.SetActive(true);
            audiostatus = 1;
        }
    }

    void RunAudioFunc()
    {
        if (audiostatus == 1)
        {
            PlayerWalkAudio.SetActive(false);
            PlayerRunAudio.SetActive(true);
            audiostatus = 0;
        }
    }
}
