using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DilYonetimiYontem4b : MonoBehaviour
{
    public string TR;
    public string EN;

    public void TextDurumunuGuncelle(int tercihNedir)
    {
        if (tercihNedir == 0)
        {
            GetComponent<Text>().text = TR;
        }
        else
        {
            GetComponent<Text>().text = EN;
        }
    }
}
