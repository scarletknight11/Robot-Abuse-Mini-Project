using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoulderCollision : MonoBehaviour {


    public GameObject orignalObject;
    public GameObject[] targetObject;
    public GameObject[] childobject;
    GameObject newObject;
    GameObject newObject2;

    public GameObject parentObject;


    public void AttachLeftArm()
    {
        newObject = Instantiate(orignalObject, targetObject[0].transform.position, orignalObject.transform.rotation);
        newObject = GameObject.Find("Robot_Upperarm_Left");
        newObject.transform.parent = parentObject.transform;
        newObject.transform.position = childobject[0].transform.position;
    }

    public void AttachRightArm()
    {
        newObject2 = Instantiate(orignalObject, targetObject[1].transform.position, orignalObject.transform.rotation);
        newObject2 = GameObject.Find("Robot_Upperarm_Right");
        newObject2.transform.parent = parentObject.transform;
        newObject2.transform.position = childobject[1].transform.position;
    }

}
