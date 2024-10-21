using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

    public class Greedy : IVehicle
    {
    public TMP_Text Speak(TMP_Text text)
    {
        text.text = "Stop being greedy";
        return text;
    }
}

    public class Job : IVehicle
    {
    public TMP_Text Speak(TMP_Text text)
    {
        text.text = "get a job";
        return text;
    }
}

public class Become : IVehicle
{
    public TMP_Text Speak(TMP_Text text)
    {
        text.text =  "Become an influencer";
        return text; 
    }
}
    public class Spirit : IVehicle
    {
    public TMP_Text Speak(TMP_Text text)
    {
        text.text = "Go on a spiritual journey";
        return text;

    }
 }
