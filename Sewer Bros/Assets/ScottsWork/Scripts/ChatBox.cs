using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChatBox : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{

    public InputField txtMessage;
    public CanvasGroup canvasGroup;
    public GameObject chatMessage;
    public string Username = "";

    public void OnPointerEnter(PointerEventData eventData)
    {
        canvasGroup.alpha = 1;
        CancelInvoke("HideChatbox");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Invoke("HideChatBox", 3);
    }

    void HideChatBox()
    {
        canvasGroup.alpha =0;
    }

    public void SendChatMessage()
    {
        if (txtMessage != null)
            if (!string.IsNullOrEmpty(txtMessage.text))
            {
                Debug.Log(txtMessage.text);
                txtMessage.text = "";
            }
    }
}
