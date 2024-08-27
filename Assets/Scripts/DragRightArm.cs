using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DragRightArm : MonoBehaviour {

    public float dragSpeed = 1f;

    public GameObject rightarm;
    public GameObject rightarmconnect;
    public GameObject rightarmmessage;
    Vector3 lastMousePos;
    [SerializeField] TMP_Text m_Text;

    void OnMouseDown()
    {
        lastMousePos = Input.mousePosition;
        rightarmmessage.gameObject.SetActive(true);
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

        m_Text.text = "Right Arm De-Attached";
        rightarm.transform.SetParent(null);
    }

    void Update()
    {
        if(rightarm.transform.parent == rightarmconnect.transform)
        {
            m_Text.text = "Right Arm Attached";
        }
    }
}
