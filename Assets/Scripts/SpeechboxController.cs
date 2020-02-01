using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeechboxController : MonoBehaviour
{
    public Text textField;
    public Image image;
    public Sprite sprite1;
    public Sprite sprite2;
    private int counter = 0;
    private string fullText;

    void Start()
	{
        image.sprite = sprite1;
        fullText = textField.text;
        textField.text = "";
        InvokeRepeating("TypeText", 0, 0.1f);
    }

    void TypeText() 
    {
        if (image.sprite == sprite1) {
            image.sprite = sprite2;
        } else {
            image.sprite = sprite1;
        }

        textField.text += fullText.Substring(counter, 1);
        if (textField.text == fullText) {
            CancelInvoke("TypeText");
            Invoke("hideSpeechbox", 3);
        }
        counter++;
    }

    public void showSpeechbox() 
    {
        gameObject.SetActive(true);
    }

    public void hideSpeechbox()
    {
        gameObject.SetActive(false);
    }
}
