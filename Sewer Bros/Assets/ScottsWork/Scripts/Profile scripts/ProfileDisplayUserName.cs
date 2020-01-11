using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileDisplayUserName : MonoBehaviour
{
    public Text txtUserName;

    public void SetUserName(string username)
    {
        txtUserName.text = username;
    }

    public void LoadUserProfile()
    {
        GameManager.LoadandSetUserProfile(txtUserName.text);
    }
}
