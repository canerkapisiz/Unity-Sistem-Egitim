using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DilYonetimiYontem4a : MonoBehaviour
{
    public Dropdown DiltercihiDrop;

    public List<Text> TextObjeleri;

    void Start()
    {
        if (!PlayerPrefs.HasKey("dilTercihi4"))
        {
            PlayerPrefs.SetInt("dilTercihi4", 1);
            DiltercihiDrop.value = PlayerPrefs.GetInt("dilTercihi4");
            DilKontrol(PlayerPrefs.GetInt("dilTercihi4"), false);
        }
        else
        {
            DiltercihiDrop.value = PlayerPrefs.GetInt("dilTercihi4");
            DilKontrol(PlayerPrefs.GetInt("dilTercihi4"), false);
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
            for (int i = 0; i < TextObjeleri.Count; i++)
            {
                TextObjeleri[i].GetComponent<DilYonetimiYontem4b>().TextDurumunuGuncelle(Dil_Index);
            }
            if (dropmu)
            {
                PlayerPrefs.SetInt("dilTercihi4", 0);
            }
        }
        else
        {
            for (int i = 0; i < TextObjeleri.Count; i++)
            {
                TextObjeleri[i].GetComponent<DilYonetimiYontem4b>().TextDurumunuGuncelle(Dil_Index);
            }
            if (dropmu)
            {
                PlayerPrefs.SetInt("dilTercihi4", 1);
            }
        }
    }
}
