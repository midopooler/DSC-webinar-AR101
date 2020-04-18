using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BCVB : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject QR, Email, Phone, Linkedin, Portfolio;
    // Start is called before the first frame update
    void Start()
    {
        QR = GameObject.Find("QR");
        QR.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        Email = GameObject.Find("Email");
        Email.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        Phone = GameObject.Find("Phone");
        Phone.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        Linkedin = GameObject.Find("Linkedin");
        Linkedin.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        Portfolio = GameObject.Find("Portfolio");
        Portfolio.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("pressed........");

        if (vb.VirtualButtonName == "QR")
        {
            Application.OpenURL("https://google.com");
            Debug.Log("QR trigerred");
        }
       else if (vb.VirtualButtonName == "Email")
        {
            Application.OpenURL("https://pulkitmidha.com/email");
            Debug.Log("Email trigerred");
        }
       else if (vb.VirtualButtonName == "Phone")
        {
            Application.OpenURL("https://pulkitmidha.com/call");
            Debug.Log("Phone trigerred");
        }
       else if (vb.VirtualButtonName == "Linkedin")
        {
            Application.OpenURL("https://pulkitmidha.com");
            Debug.Log("Linkedin trigerred");
        }
       else if (vb.VirtualButtonName == "Portfolio")
        {
            Application.OpenURL("https://google.com");
            Debug.Log("Portfolio trigerred");
        }
    }
   
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
       // throw new System.NotImplementedException();
        Debug.Log("Button released");
    }
}

