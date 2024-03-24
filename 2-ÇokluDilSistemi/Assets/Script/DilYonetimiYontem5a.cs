using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DilYonetimiYontem5a : MonoBehaviour
{
    public Dropdown DiltercihiDrop;
    GameObject[] objeler;

    void Start()
    {
        objeler = GameObject.FindGameObjectsWithTag("Dil");

        if (!PlayerPrefs.HasKey("dilTercihi5"))
        {
            if (Application.systemLanguage == SystemLanguage.Turkish)
            {
                PlayerPrefs.SetInt("dilTercihi5", 0);
            }
            else
            {
                PlayerPrefs.SetInt("dilTercihi5", 1);
            }
            DiltercihiDrop.value = PlayerPrefs.GetInt("dilTercihi5");
            DilKontrol(PlayerPrefs.GetInt("dilTercihi5"), false);
        }
        else
        {
            DiltercihiDrop.value = PlayerPrefs.GetInt("dilTercihi5");
            DilKontrol(PlayerPrefs.GetInt("dilTercihi5"), false);
        }
    }

    void TextlerinKontrolu(int Dil_Index)
    {
        foreach (var item in objeler)
        {
            item.GetComponent<DilYonetimiYontem5b>().TextDurumunuGuncelle(Dil_Index);
        }
    }

    public void SecilenNedir(int Gelendeger)
    {
        DilKontrol(Gelendeger, true);
    }

    void DilKontrol(int Dil_Index, bool dropmu)
    {
        if (Dil_Index == 0)
        {
            TextlerinKontrolu(Dil_Index);
            if (dropmu)
            {
                PlayerPrefs.SetInt("dilTercihi5", 0);
            }
        }
        else
        {
            TextlerinKontrolu(Dil_Index);

            if (dropmu)
            {
                PlayerPrefs.SetInt("dilTercihi5", 1);
            }
        }
    }
}
