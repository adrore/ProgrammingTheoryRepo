using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class FeatureButton : PawsButton
{
    public string feature;

    public override void PushButton()
    {
        base.PushButton();
        FeatureToText();
    }

    protected override void FeatureToText()
    {
        featureText.text = feature;
    }
}
