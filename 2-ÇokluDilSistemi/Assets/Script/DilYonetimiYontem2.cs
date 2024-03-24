using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DilYonetimiYontem2 : MonoBehaviour
{
    public Dropdown DiltercihiDrop;

    public List<Text> Butonlar;
    public List<Text> GenelYazilar;

    List<string> TurkceDilVerileri = new List<string>();
    List<string> IngDilVerileri = new List<string>();

    void Start()
    {
        TurkceDilVerileri.Add("OYNA");
        TurkceDilVerileri.Add("AYARLAR");
        TurkceDilVerileri.Add("ÇIKIŞ");
        TurkceDilVerileri.Add("Oynayalım");
        TurkceDilVerileri.Add("Oyun çok zor");
        TurkceDilVerileri.Add("Oyunu bitirebilecek misin ?");

        IngDilVerileri.Add("PLAY");
        IngDilVerileri.Add("SETTINGS");
        IngDilVerileri.Add("QUIT");
        IngDilVerileri.Add("Let's play");
        IngDilVerileri.Add("The game is very difficult");
        IngDilVerileri.Add("Can you finish the game ?");

        if (!PlayerPrefs.HasKey("dilTercihi2"))
        {
            PlayerPrefs.SetInt("dilTercihi2", 1);
            DiltercihiDrop.value = PlayerPrefs.GetInt("dilTercihi2");
            DilKontrol(PlayerPrefs.GetInt("dilTercihi2"), false);
        }
        else
        {
            DiltercihiDrop.value = PlayerPrefs.GetInt("dilTercihi2");
            DilKontrol(PlayerPrefs.GetInt("dilTercihi2"), false);
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
            for (int i = 0; i < TurkceDilVerileri.Count; i++)
            {
                if (i > 2)
                {
                    int sayi = 3;
                    for (int j = 0; j < 3; j++)
                    {
                        GenelYazilar[j].text = TurkceDilVerileri[sayi];
                        //GenelYazilar[0]         // 3
                        sayi++;
                    }
                }
                else
                {
                    Butonlar[i].text = TurkceDilVerileri[i];
                }
            }
            if (dropmu)
            {
                PlayerPrefs.SetInt("dilTercihi2", 0);
            }
        }
        else
        {
            for (int i = 0; i < IngDilVerileri.Count; i++)
            {
                if (i > 2)
                {
                    int sayi = 3;
                    for (int j = 0; j < 3; j++)
                    {
                        GenelYazilar[j].text = IngDilVerileri[sayi];
                        //GenelYazilar[0]         // 3
                        sayi++;
                    }
                }
                else
                {
                    Butonlar[i].text = IngDilVerileri[i];
                }
            }
            if (dropmu)
            {
                PlayerPrefs.SetInt("dilTercihi2", 1);
            }
        }
    }
}
