using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            //gameObject.transform.Translate(Vector3.forward * 0.5f * Time.deltaTime);

            Debug.Log("aget barh");
        }
    }
}
