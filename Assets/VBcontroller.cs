using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBcontroller : MonoBehaviour, IVirtualButtonEventHandler
{
    public int scale = 0;
    public int translate = 0;
    public int rotate = 0;
    public int Xaxis = 0;
    public int Yaxis = 0;
    public int Zaxis = 0;
    public GameObject DSCGTBIT;
    public GameObject UnityStAmb;
    public GameObject PikachuM;
    public GameObject VBscale, VBrotate, VBtranslate, VBXaxis, VBYaxis, VBZaxis;

    public Vector3 temp;



    void Start()
    {
        VBscale = GameObject.Find("VBscale");
        VBscale.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("pressed........");

        if (vb.VirtualButtonName == "VBscale")
        {
            scale = 1;
            rotate = 0;
            translate = 0;
            temp = PikachuM.transform.localScale;
            Debug.Log("scale is pressed" + temp);
        }
        if (scale == 1)
        {
            if (vb.VirtualButtonName == "Xaxis")
            {
                Debug.Log("X is pressed");
                Xaxis = 1;
                Yaxis = 0;
                Zaxis = 0;
 }
            if (vb.VirtualButtonName == "Y")
            {
                Debug.Log("Y is pressed");
                Yaxis = 1;
                Zaxis = 0;
                Xaxis = 0;

            }
            if (vb.VirtualButtonName == "Z")
            {
                Debug.Log("Z is pressed");
                Zaxis = 1;
                Xaxis = 0;
                Yaxis = 0;

            }
        }
        if (Xaxis == 1)
        {
            if (vb.VirtualButtonName == "UnityStAmb")
            {
                Debug.Log("plus is pressed");
                temp.x = temp.x + 0.3f;
                PikachuM.transform.localScale = temp;
            }
            if (vb.VirtualButtonName == "DSCGTBIT")
            {
                Debug.Log("minus is pressed");
                temp.x = temp.x - 0.3f;
                PikachuM.transform.localScale = temp;
            }
        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("button released");

    }
}