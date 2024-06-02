using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private Camera _camera;

    void Start()
    {
        _camera = Camera.main;
    }

    void Update()
    {
        Vector2 mousePos = (Vector2)_camera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dirVec = mousePos - (Vector2)transform.position; // ���콺�� �ٶ󺸴� ������ ��Ÿ���� ����

        transform.up = (Vector3)dirVec.normalized;
    }
}
