using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandsMomet : MonoBehaviour
{
    [SerializeField] private GameObject leftHand;
    [SerializeField] private GameObject rightHand;
    [SerializeField] private DoubleHand doubleHand;
 
   public void Rotate_LeftHand() 
    {
        leftHand.transform.rotation = Quaternion.Lerp(leftHand.transform.rotation, Quaternion.Euler(270f, 0f, 60f),1f);
        doubleHand.Rotate_DoubleHand(); 
        // load the next scene
    }
    public void Rotate_LeftHand_Top()
    {
        leftHand.transform.rotation = Quaternion.Lerp(leftHand.transform.rotation, Quaternion.Euler(320f, 0f, 60f), 1f);
        doubleHand.Rotate_DoubleHand();
        //load the next scene
    }
    public void Rotate_LeftHand_Bottom()
    {
        leftHand.transform.rotation = Quaternion.Lerp(leftHand.transform.rotation, Quaternion.Euler(220f, 0f, 60f), 1f);
        doubleHand.Rotate_DoubleHand();
        // load the next scene
    }
    public void Rotate_RightHand()
    {
        rightHand.transform.rotation = Quaternion.Lerp(leftHand.transform.rotation, Quaternion.Euler(270f, 0f, -60f), 1f);
        doubleHand.Rotate_DoubleHand();
        // load the next scene
    }
    public void Rotate_RightHand_Top()
    {
        rightHand.transform.rotation = Quaternion.Lerp(leftHand.transform.rotation, Quaternion.Euler(320f, 0f, -60f), 1f);
        doubleHand.Rotate_DoubleHand();
        //load the next scene
    }
    public void Rotate_RighttHand_Bottom()
    {
        rightHand.transform.rotation = Quaternion.Lerp(leftHand.transform.rotation, Quaternion.Euler(220f, 0f, -60f), 1f);
        doubleHand.Rotate_DoubleHand();
        // load the next scene
    }
}
