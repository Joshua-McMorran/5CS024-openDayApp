using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PD_DBConnect : MonoBehaviour
{

    public TMPro.TMP_InputField F_Name;
    public TMPro.TMP_InputField S_Name;
    public TMPro.TMP_InputField Email;
    public TMPro.TMP_InputField Phone_No;
    public TMPro.TMP_InputField Post_Code;
    public Toggle Phone;
    public Toggle Email_Toggle;
    public Toggle No_Contact;

    public void Submit()
    {
        Debug.Log(F_Name.text);
        Debug.Log(S_Name.text);
        Debug.Log(Email.text);
        Debug.Log(Phone_No.text);
        Debug.Log(Post_Code.text);


        if (Phone.isOn)
        {
            Debug.Log("Wants to be Texted");
        } else
        {
            Debug.Log("Doesn't want to be Texted");
        }

        if (Email_Toggle.isOn)
        {
            Debug.Log("Wants to be Emailed");
        } else
        {
            Debug.Log("Doesn't want to be Emailed");
        }

        if (No_Contact.isOn)
        {
            Debug.Log("Doesn't want to be contacted");
        } else
        {
            Debug.Log("Wants to be contacted");
        }
    }
}
