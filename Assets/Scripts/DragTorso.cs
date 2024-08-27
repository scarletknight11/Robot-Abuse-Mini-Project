using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DragTorso : MonoBehaviour
{
    public float dragSpeed = 1f;
    Vector3 lastMousePos;


    void OnMouseDown()
    {
        lastMousePos = Input.mousePosition;
    }

    void OnMouseDrag()
    {
        Vector3 delta = Input.mousePosition - lastMousePos;
        Vector3 pos = transform.position;
        pos.y += delta.y * dragSpeed;
        transform.position = pos;
        lastMousePos = Input.mousePosition;

        Vector3 pos2 = transform.position;
        pos2.x += delta.x * dragSpeed;
        transform.position = pos2;
        lastMousePos = Input.mousePosition;

    }
}
