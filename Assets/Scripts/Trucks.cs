using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Truck : IVehicle
{
    public TMP_Text Speak(TMP_Text text)
    {
        text.text = "Choose a different goal";
        return text;
    }
}

public class Settle : IVehicle
{
    public TMP_Text Speak(TMP_Text text)
    {
        text.text = "Be content with what you have";
        return text;
    }
}
