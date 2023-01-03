using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class weDragonMove : MonoBehaviour
{
    Vector3 clickPoint; //마우스를 클릭한 위치
    float Speed = 0.5f; //움직이는 속도

    private TextMeshProUGUI myCoin;
    public int get_coin = 0; //한 게임 도중 얻은 코인 값
    public int one_coin = 100; //코인 1개당 100원

    void Start()
    {
        myCoin = GameObject.Find("coin").GetComponent<TextMeshProUGUI>();
        myCoin.text = "[Get Coin]: " + get_coin.ToString();
    }

    void OnMouseDown()
    {
        clickPoint = Input.mousePosition;
    }

    void OnMouseDrag()
    {
        Vector3 differ = Input.mousePosition - clickPoint; //처음에 클릭한 위치와 드래그한 위치의 차이
        Vector3 pos = transform.position; //해당위치로 이동

        pos.x += differ.x * Time.deltaTime * Speed; //이동거리 보정하기 (거리=속력*시간 느낌...)
        transform.position = pos; //transform.position에 위치를 대입하면 해당 위치로 이동한다.

        clickPoint = Input.mousePosition;
    }

    private void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Coin")
        {
            get_coin += one_coin;
            Debug.Log(get_coin);
        }

    }

    void SetCountText()
    {
        myCoin.text = "[Get Coin]: " + get_coin.ToString();
    }

    void Update()
    {
        SetCountText();
    }
}