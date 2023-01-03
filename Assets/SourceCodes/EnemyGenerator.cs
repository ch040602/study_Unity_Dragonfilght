using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster
{
    int monster_type;
    int hp;
    //int look;
}

public class EnemyGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPrefab0;
    public GameObject enemyPrefab1;
    Vector3 startPos;
    float span = 1f;
    float delta = 0;
    float[] x_pos = new float[] { -2.0f, -1.0f, 0, 1.0f, 2.0f };
    float[] MonsterType = new float[] { -2.0f, -1.0f, 0, 1.0f, 2.0f };
    int[,] monster = { { 0, 100 }, { 1, 200 } };
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
            int strongest_monster = Random.Range(0, 5);
            for(int i=0; i<5; i++)
            {
                GameObject monster; 
                if (i == strongest_monster)
                {
                     monster = Instantiate(enemyPrefab1);
                }
                else
                {
                     monster = Instantiate(enemyPrefab0);
                }
                monster.transform.position = new Vector3(x_pos[i], 15, 8);
            } 
        }
    }
}
