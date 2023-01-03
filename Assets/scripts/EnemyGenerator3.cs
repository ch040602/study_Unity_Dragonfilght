using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPrefab;
    Vector3 startPos;
    float span = 1f;
    float delta = 0;

    // Update is called once per frame
    private void Start()
    {
    }
    void Update()
    {
        //GameObject go = Instantiate(arrow)
        this.delta += Time.deltaTime;   
        if(this.delta > this.span)
        {
            this.delta = 0;

                GameObject go = Instantiate(enemyPrefab);
                go.transform.position = new Vector3(1, 15, 8);
            
        }
    }
}
