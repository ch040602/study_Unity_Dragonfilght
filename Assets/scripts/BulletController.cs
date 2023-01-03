using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    Transform bullet;
    float speed = 0.23f;
    // Start is called before the first frame update
    void Start()
    {
        bullet = transform;

        //GetComponent<Rigidbody>().isKinetic = true;       
    }
    
    // Update is called once per frame
    void Update()
    {
        //GetComponent<Rigidbody>().isKinetic = false;
        bullet.Translate(new Vector3(0, speed, 0));

        if (transform.position.y > 15.0f)
        {
            Destroy(gameObject);
        }
    }

    
}
