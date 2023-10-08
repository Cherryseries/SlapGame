using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoubleHand : MonoBehaviour
{   
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("slapped");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Rotate_DoubleHand()
    {
        List<float> RotationList = new List<float>();
        //top  transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(120f, 0f, 0f), 1f);
        //bottom  transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(60f, 0f, 0f), 1f);
        //normal  transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(90f, 0f, 0f), 1f);
    }

}
