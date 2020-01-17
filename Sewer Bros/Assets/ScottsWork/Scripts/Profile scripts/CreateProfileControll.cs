using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CreateProfileControll : MonoBehaviour
{
    public InputField txtUsername;
    public Color selechtedColor = Color.white;
    public string SelechtedImage = "test";

    bool hasusername = false;
    bool hasProfileColor = false;
    bool hasProfileImage = false;


    GameManager manager;

    public void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    bool CanCreateProfile()
    {
        return hasProfileColor && hasProfileImage && hasusername;
    }

    public void CreateProfile()
    {

        if (!string.IsNullOrEmpty(txtUsername.text))
        {
            hasusername = true;

            if (CanCreateProfile())
            {
                GameManager.CreateUserProfile(
                    txtUsername.text,
                    selechtedColor,
                    SelechtedImage);
            }
            else
            {
                manager.ShowPopUp("Please enter all profile details to contiune ");

            }

        }
        else
        {
            manager.ShowPopUp("you must enter a username ");
        }
        Debug.Log(CanCreateProfile());
        Debug.Log(hasProfileColor);
        Debug.Log(hasProfileImage);
        Debug.Log(hasusername);
    }

    public void UpdateProfileColor()
    {
        Button Btn = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        selechtedColor = Btn.image.color;

        hasProfileColor = true;
        Debug.Log(selechtedColor);
    }

    public void UpdateProfileImage()
    {
        Button Btn = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        SelechtedImage = Btn.image.sprite.name;

        hasProfileImage = true;
        Debug.Log(SelechtedImage);
    }

    private T GetComponentFromControl<T>()
    {
        return EventSystem.current.currentSelectedGameObject.GetComponent<T>();
    }
}

