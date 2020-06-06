using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Suma : MonoBehaviour
{
    public Text sumatxt;
    public int cont = 0;

    public void onClicked_Suma()
    {
        cont++;

        sumatxt.text = cont.ToString();

    }

    public void onClicked_Resta()
    {
        cont--;

        sumatxt.text = cont.ToString();

    }

}
