using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpBox : MonoBehaviour
{
    public Text txtMeassage;
    public Button btnContiune;

    public void IntailzeProjecht(string meassage)
    {
        txtMeassage.text = meassage;
    }

    public void closePopUp()
    {
        Destroy(gameObject);
    }
}
