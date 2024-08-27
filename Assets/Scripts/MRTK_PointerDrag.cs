using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using TMPro;

public class MRTK_PointerDrag : MonoBehaviour
{
    public GameObject rightarm;
    public GameObject rightarmconnect;
    public GameObject rightarmmessage;
    [SerializeField] TMP_Text m_Text;

    public GameObject leftarm;
    public GameObject leftarmconnect;
    public GameObject leftarmmessage;
    [SerializeField] TMP_Text m_Text2;

    public void DetachRightArm()
    {
        rightarmmessage.SetActive(true);
        m_Text.text = "Right Arm De-Attached";
        rightarm.transform.SetParent(null);
    }

    public void DetachLeftArm()
    {
        leftarmmessage.SetActive(true);
        m_Text2.text = "Left Arm De-Attached";
        leftarm.transform.SetParent(null);
    }

    void Update()
    {
        if (rightarm.transform.parent == rightarmconnect.transform)
        {
            m_Text.text = "Right Arm Attached";
        }

        if (leftarm.transform.parent == leftarmconnect.transform)
        {
            m_Text2.text = "Left Arm Attached";
        }
    }
}
