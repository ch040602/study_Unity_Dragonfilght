using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Coin1 : MonoBehaviour
{

    public float rotateSpeed = 180f;
    public float xPos;
    public float yPos;
    public float fallSpeed;

    [System.NonSerialized]
    public int one_coin = 100;
    public int total_coin = 0;

    string fullpth = "Assets/totalMoney";
    StreamWriter sw;

    // Start is called before the first frame update
    void Start()
    {

        if (false == File.Exists(fullpth))
        {
            sw = new StreamWriter(fullpth + ".txt");
        }

        sw.WriteLine(total_coin);

        sw.Flush();
        sw.Close();
    }

    public void SetCoinValue(int total_coin)
    {
        this.total_coin = total_coin;
    }

    private void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            //col.gameObject.GetComponent<weDragon>().AddMoney();
        }

    }

    public void SetPosition(float xPos, float yPos, float fallSpeed)
    {
        this.xPos = xPos;
        this.yPos = yPos;
        this.fallSpeed = fallSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        SetPosition(2, 7, 1);
        transform.position = new Vector3(xPos, yPos, 8);
        yPos = yPos - fallSpeed;

        if (yPos < -1f) //¸ø¸ÔÀ¸¸é ÆÄ±«
        {
            Destroy(gameObject);
        }
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }
}