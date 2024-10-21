using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

    public class None : IVehicle
    {
    public TMP_Text Speak(TMP_Text text)
    {
        text.text = "Do you have any goals?";
        return text;
    }
}

public class Dice : IVehicle
{
    public TMP_Text Speak(TMP_Text text)
    {
        text.text = "The blood of a wild goose";
        return text;
    }
}
    public class Skull : IVehicle
    {
    public TMP_Text Speak(TMP_Text text)
    {
        text.text = "Out pizza the Hut";
        return text;
    }
}
