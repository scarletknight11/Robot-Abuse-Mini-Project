using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRTK_LeftArm : MonoBehaviour
{

    //Get gameobject
    public GameObject gb;

    //Get Material
    public Material color;

    //Original Material
    public Material Originalcolor;

    public void OnFocusEnter(FocusEventData eventData)
    {
        gb.GetComponent<MeshRenderer>().material = color;
        GameObject game = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Upperarm_Left/Robot_Lowerarm_Left/");
        game.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
        GameObject game2 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Upperarm_Left/Robot_Lowerarm_Left/Robot_Hand_Left");
        game2.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
    }

    public void OnFocusExit(FocusEventData eventData)
    {
        gb.GetComponent<MeshRenderer>().material = Originalcolor;
        GameObject game = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Upperarm_Left/Robot_Lowerarm_Left/");
        game.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
        GameObject game2 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Upperarm_Left/Robot_Lowerarm_Left/Robot_Hand_Left");
        game2.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
    }
}
