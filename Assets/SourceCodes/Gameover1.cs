using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit(); // 어플리케이션 종료
            #endif
        }
    }

}
