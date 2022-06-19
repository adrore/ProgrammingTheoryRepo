using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClassButton : MonoBehaviour
{
    protected TextMeshProUGUI nameText;
    protected TextMeshProUGUI pawsText;
    protected TextMeshProUGUI featureText;
    private string nameButton;
    protected string Name
    {
        get { return nameButton; }
        set { nameButton = value; }
    }

    protected virtual void Start()
    {
        nameText = GameObject.Find("Name").GetComponent<TextMeshProUGUI>();
        pawsText = GameObject.Find("Paws").GetComponent<TextMeshProUGUI>();
        featureText = GameObject.Find("Caracterist").GetComponent<TextMeshProUGUI>();
        Name = gameObject.GetComponentInChildren<TextMeshProUGUI>().text;
    }

    void NameToText()
    {
        nameText.text = Name;
    }

    protected virtual void PawsToText()
    {
        pawsText.text = " ";
    }

    protected virtual void FeatureToText()
    {
        featureText.text = " ";
    }

    public virtual void PushButton()
    {
        NameToText();
        PawsToText();
        FeatureToText();     
    }
}
