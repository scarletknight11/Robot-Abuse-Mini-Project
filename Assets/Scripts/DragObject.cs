using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DragObject : MonoBehaviour {

    public float dragSpeed = 1f;
    public GameObject leftarm;
    public GameObject leftarmconnect;
    public GameObject leftarmmessage;
    Vector3 lastMousePos;
    [SerializeField] TMP_Text m_Text;


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

        leftarmmessage.gameObject.SetActive(true);
        m_Text.text = "Left Arm De-Attached";
        leftarm.transform.SetParent(null);
    }

    void Update()
    {
        if (leftarm.transform.parent == leftarmconnect.transform)
        {
            m_Text.text = "Left Arm Attached";
        }
    }
}