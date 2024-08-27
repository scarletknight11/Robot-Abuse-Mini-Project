using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit
{
    public class MRTK_Hover : MonoBehaviour, IMixedRealityFocusHandler
    {
        //Get gameobject
        public GameObject gb;

        //Get Material
        public Material color;

        //Original Material
        public Material Originalcolor;

        //Utilizes MRTK On focus method built in to the library similar as a cursor from mouse
        public void OnFocusEnter(FocusEventData eventData)
        {
            //Renders the material when pointer focus on the object
            gb.GetComponent<MeshRenderer>().material = color;
            //Find all gameobjects within the hierachy and change there color when I hover my mouse over torso
            GameObject game = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Hips/Robot_Thigh_Left/");
            game.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game2 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Hips/Robot_Thigh_Left/Robot_Shin_Left");
            game2.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game3 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Hips/Robot_Thigh_Left/Robot_Shin_Left/Robot_Foot_Left");
            game3.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game4 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Hips/Robot_Thigh_Right");
            game4.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game5 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Hips/Robot_Thigh_Right/Robot_Shin_Right");
            game5.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game6 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Hips/Robot_Thigh_Right/Robot_Shin_Right/Robot_Foot_Right");
            game6.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game7 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Neck/Robot_Head");
            game7.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game8 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Neck/Robot_Head/Robot_Eye_Left");
            game8.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game9 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Neck/Robot_Head/Robot_Eye_Right");
            game9.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game10 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Neck/");
            game10.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game11 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Neck/Robot_Jaw");
            game11.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game12 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Hips");
            game12.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game13 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Upperarm_Left");
            game13.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game14 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Upperarm_Left/Robot_Lowerarm_Left");
            game14.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game15 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Upperarm_Left/Robot_Lowerarm_Left/Robot_Hand_Left");
            game15.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game16 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Upperarm_Right/");
            game16.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game17 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Upperarm_Right/Robot_Lowerarm_Right");
            game17.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game18 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Upperarm_Right/Robot_Lowerarm_Right/Robot_Hand_Right");
            game18.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
        }

        public void OnFocusExit(FocusEventData eventData)
        {
            // Reset the color of the GameObject back to normal
            gb.GetComponent<MeshRenderer>().material = Originalcolor;
            //Find all gameobjects within the hierachy and change there color when I exit my mouse from torso
            GameObject game = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Hips/Robot_Thigh_Left");
            game.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game2 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Hips/Robot_Thigh_Left/Robot_Shin_Left");
            game2.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game3 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Hips/Robot_Thigh_Left/Robot_Shin_Left/Robot_Foot_Left");
            game3.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game4 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Hips/Robot_Thigh_Right");
            game4.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game5 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Hips/Robot_Thigh_Right/Robot_Shin_Right");
            game5.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game6 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Hips/Robot_Thigh_Right/Robot_Shin_Right/Robot_Foot_Right");
            game6.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game7 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Neck/Robot_Head");
            game7.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game8 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Neck/Robot_Head/Robot_Eye_Left");
            game8.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game9 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Neck/Robot_Head/Robot_Eye_Right");
            game9.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game10 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Neck/");
            game10.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game11 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Neck/Robot_Jaw");
            game11.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game12 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Hips");
            game12.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game13 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Upperarm_Left");
            game13.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game14 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Upperarm_Left/Robot_Lowerarm_Left");
            game14.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game15 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Upperarm_Left/Robot_Lowerarm_Left/Robot_Hand_Left");
            game15.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game16 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Upperarm_Right");
            game16.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game17 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Upperarm_Right/Robot_Lowerarm_Right");
            game17.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
            GameObject game18 = GameObject.Find("/Robot_Toy/Robot_Torso/Robot_Upperarm_Right/Robot_Lowerarm_Right/Robot_Hand_Right");
            game18.GetComponent<MeshRenderer>().material = gb.GetComponent<MeshRenderer>().material;
        }

    }
}
