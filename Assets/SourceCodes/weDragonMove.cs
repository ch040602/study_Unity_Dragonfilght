using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weDragonMove : MonoBehaviour
{
    Vector3 clickPoint; //���콺�� Ŭ���� ��ġ
    float Speed = 0.2f; //�����̴� �ӵ�

    void OnMouseDown()
    {
        clickPoint = Input.mousePosition;
    }

    void OnMouseDrag()
    {
        Vector3 differ = Input.mousePosition - clickPoint; //ó���� Ŭ���� ��ġ�� �巡���� ��ġ�� ����
        Vector3 pos = transform.position;//�ش���ġ�� �̵�

        pos.x += differ.x * Time.deltaTime * Speed;//�̵��Ÿ� �����ϱ� (�Ÿ�=�ӷ�*�ð� ����...)
        transform.position = pos;//transform.position�� ��ġ�� �����ϸ� �ش� ��ġ�� �̵��Ѵ�.

        clickPoint = Input.mousePosition;
    }
}
