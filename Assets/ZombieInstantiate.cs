using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieInstantiate : MonoBehaviour
{
    public GameObject zombie;
    public GameObject zombieParent;
    int a = 0;
    // Start is called before the first frame update
    void Start()
    {

        // InvokeRepeating("zombieInstantiate", 2f, 3f);
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Invoke("zombieInstantiate", 2f);
        }
    }

    void zombieInstantiate()
    {
        var obj = Instantiate(zombie, gameObject.transform.position, gameObject.transform.rotation);
        obj.name = "Zombie" + a;
        a++;
    }
}
