using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DilYonetimiYontem3a : MonoBehaviour
{
    public Dropdown DiltercihiDrop;

    public List<Text> Butonlar;
    public List<Text> GenelYazilar;

    DilYonetimiYontem3b dilYonetimiYontem3b;

    void Start()
    {
        dilYonetimiYontem3b = GetComponent<DilYonetimiYontem3b>();

        if (!PlayerPrefs.HasKey("dilTercihi3"))
        {
            PlayerPrefs.SetInt("dilTercihi3", 1);
            DiltercihiDrop.value = PlayerPrefs.GetInt("dilTercihi3");
            DilKontrol(PlayerPrefs.GetInt("dilTercihi3"), false);
        }
        else
        {
            DiltercihiDrop.value = PlayerPrefs.GetInt("dilTercihi3");
            DilKontrol(PlayerPrefs.GetInt("dilTercihi3"), false);
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
            for (int i = 0; i < dilYonetimiYontem3b.TRDilVerileri.Count; i++)
            {
                if (i > 2)
                {
                    int sayi = 3;
                    for (int i2 = 0; i2 < 3; i2++)
                    {
                        GenelYazilar[i2].text = dilYonetimiYontem3b.TRDilVerileri[sayi];
                        //GenelYazilar[0]         // 3
                        sayi++;
                    }
                }
                else
                {
                    Butonlar[i].text = dilYonetimiYontem3b.TRDilVerileri[i];
                }
            }
            if (dropmu)
            {
                PlayerPrefs.SetInt("dilTercihi3", 0);
            }
        }
        else
        {
            for (int i = 0; i < dilYonetimiYontem3b.ENDilVerileri.Count; i++)
            {
                if (i > 2)
                {
                    int sayi = 3;
                    for (int i2 = 0; i2 < 3; i2++)
                    {
                        GenelYazilar[i2].text = dilYonetimiYontem3b.ENDilVerileri[sayi];
                        //GenelYazilar[0]         // 3
                        sayi++;
                    }
                }
                else
                {
                    Butonlar[i].text = dilYonetimiYontem3b.ENDilVerileri[i];
                }
            }
            if (dropmu)
            {
                PlayerPrefs.SetInt("dilTercihi3", 1);
            }
        }
    }
}
