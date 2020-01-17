using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileDisplay : MonoBehaviour
{

    public Text txtusername;
    public Image imgProfile;
    public Image imgBackground;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.ProfileLoaded += OnGameManager_profileLoaded;

    }
    private void OnGameManager_profileLoaded()
    {
        initaliseProfile(GameManager.Profile);
    }
   public void initaliseProfile(UserProfile profile)
    {
        txtusername.text = profile.Username;
        imgBackground.color = profile.Color;

        imgProfile.sprite = GameManager.LoadAssetsFromResources<Sprite>("Profile Icons/" + profile.ImageName);
    }
}
