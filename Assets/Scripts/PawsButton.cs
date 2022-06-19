using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PawsButton : ClassButton
{
    public string paws;
    public override void PushButton()
    {
        base.PushButton();
        PawsToText();
    }

    protected override void PawsToText()
    {
        pawsText.text = paws;
    }
}
