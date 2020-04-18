using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class VBmaincode : MonoBehaviour, IVirtualButtonEventHandler
{
    public int scale = 0;
    public int rotation = 0;
    public int translate = 0;
    public int XAxis = 0;
    public int YAxis = 0;
    public int ZAxis = 0;
    public GameObject PikachuM;
    public Vector3 temp;

    public GameObject VBtranslate, VBXaxis, VBYaxis, VBZaxis, VBplus, VBminus;
    // Start is called before the first frame update
    void Start()
    {
        VBtranslate = GameObject.Find("VBtranslate");
        VBtranslate.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        VBXaxis = GameObject.Find("VBXaxis");
        VBXaxis.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        VBYaxis = GameObject.Find("VBYaxis");
        VBYaxis.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        VBZaxis = GameObject.Find("VBZaxis");
        VBZaxis.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
       // Debug.Log("pressed........");
        if (vb.VirtualButtonName == "VBtranslate")
        {
            translate = 1;
            rotation = 0;
            scale = 0;
            temp = PikachuM.transform.localPosition;
            Debug.Log("translate is pressed" + temp);
        }
        if (translate == 1)
        {
            if (vb.VirtualButtonName == "VBXaxis")
            {
                Debug.Log("X is pressed");
                XAxis = 1;
                YAxis = 0;
                ZAxis = 0;

            }
            if (vb.VirtualButtonName == "VBYaxis")
            {

                Debug.Log("Y is pressed");
                YAxis = 1;
                XAxis = 0;
                ZAxis = 0;


            }
            if (vb.VirtualButtonName == "VBZaxis")
            {

                Debug.Log("X is pressed");
                ZAxis = 1;
                YAxis = 0;
                XAxis = 0;


            }
        }
        if (XAxis == 1)
        {
            if (vb.VirtualButtonName == "VBplus")
            {
                Debug.Log("plus is pressed");
                temp.x = temp.x + 0.3f;
                PikachuM.transform.localPosition = temp;
            }
            if (vb.VirtualButtonName == "VBminus")
            {
                Debug.Log("minus is pressed");
                temp.x = temp.x - 0.3f;
                PikachuM.transform.localPosition = temp;
            }
        }
        if (YAxis == 1)
        {
            if (vb.VirtualButtonName == "VBplus")
            {
                Debug.Log("plus is pressed");
                temp.y = temp.y + 0.3f;
                PikachuM.transform.localPosition = temp;
            }
            if (vb.VirtualButtonName == "VBminus")
            {
                Debug.Log("minus is pressed");
                temp.y = temp.y - 0.3f;
                PikachuM.transform.localPosition = temp;
            }
        }
        if (ZAxis == 1)
        {
            if (vb.VirtualButtonName == "VBplus")
            {
                Debug.Log("plus is pressed");
                temp.z = temp.z + 0.3f;
                PikachuM.transform.localPosition = temp;
            }
            if (vb.VirtualButtonName == "VBminus")
            {
                Debug.Log("minus is pressed");
                temp.z = temp.z - 0.3f;
                PikachuM.transform.localPosition = temp;
            }
        }

       

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //throw new System.NotImplementedException();
        Debug.Log("button released");
    }
}
