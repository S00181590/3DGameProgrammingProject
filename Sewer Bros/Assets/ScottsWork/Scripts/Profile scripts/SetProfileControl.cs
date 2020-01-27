using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetProfileControl : MonoBehaviour
{

    public GameObject ProfileDisplayButton;
    public RectTransform ListProfiles;
   
    void Start()
    {
        LoadProfilesList();
    }

    public void LoadProfilesList()
    {
        string[] profiles = GameManager.GetAllProfileName();
        foreach (string username in profiles)
        {
            GameObject button = Instantiate(ProfileDisplayButton, ListProfiles);

            button.GetComponent<ProfileDisplayUserName>().SetUserName(username);
        }
    }
}
