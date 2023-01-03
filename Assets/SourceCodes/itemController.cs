using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemController : MonoBehaviour
{
    Rigidbody rb;
    float power = 30f;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(Random.Range(-100, 100), 200, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<=-2 || transform.position.x >= 2)
        {
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
        }
        if (this.transform.position.y < -15)
        {
            Destroy(gameObject);
        }
         
    }
        private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "weDragon")
        {
            //효과 발동
            Destroy(gameObject);
        }
    }
}
