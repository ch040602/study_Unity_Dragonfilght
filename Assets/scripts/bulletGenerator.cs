using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class bulletGenerator : MonoBehaviour
{
    float delta = 0f;
    float span = 0.10f;

    public GameObject bulletPrefab;
    //float speed = 3.0f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.transform.position = new Vector3(GameObject.Find("weDragon").transform.position.x, 7.5f, 8.0f);
            
        }
    }
}
