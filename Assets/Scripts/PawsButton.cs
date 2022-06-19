using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// INHERITANCE
public class PawsButton : ClassButton
{
    public string paws;
    public override void PushButton()
    {
        base.PushButton();
        PawsToText();
    }

    // POLYMORPHISM
    protected override void PawsToText()
    {
        pawsText.text = paws;
    }
}
