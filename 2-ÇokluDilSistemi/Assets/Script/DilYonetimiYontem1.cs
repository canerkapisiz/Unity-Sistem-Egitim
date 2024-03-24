using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DilYonetimiYontem1 : MonoBehaviour
{
    public Dropdown dilTercihiDrop;

    public List<Text> Butonlar;
    public List<Text> GenelYazilar;
    // OYUN BAŞLADIĞINDA MEVCUT DİL TERCİHİ NE İSE, YAZILAR ONA GÖRE YÜKLENECEK

    void Start()
    {
        if (!PlayerPrefs.HasKey("dilTercihi1"))
        {
            PlayerPrefs.SetInt("dilTercihi1", 1);
            dilTercihiDrop.value = PlayerPrefs.GetInt("dilTercihi1");
            DilKontrol(PlayerPrefs.GetInt("dilTercihi1"), false);
        }
        else
        {
            dilTercihiDrop.value = PlayerPrefs.GetInt("dilTercihi1");
            DilKontrol(PlayerPrefs.GetInt("dilTercihi1"), false);
        }
    }

    void Update()
    {

    }

    public void SecilenNedir(int Gelendeger)
    {
        DilKontrol(Gelendeger, true);
    }

    void DilKontrol(int dilIndex, bool dropmu)
    {
        if (dilIndex == 0)
        {
            Butonlar[0].text = "OYNA";
            Butonlar[1].text = "AYARLAR";
            Butonlar[2].text = "CIKIS";

            GenelYazilar[0].text = "Oynayalim";
            GenelYazilar[1].text = "Oyun cok zor";
            GenelYazilar[2].text = "Oyunu bitirebilecek misin?";

            if (dropmu)
            {
                PlayerPrefs.SetInt("dilTercihi1", 0);
            }
        }
        else
        {
            Butonlar[0].text = "PLAY";
            Butonlar[1].text = "SETINGS";
            Butonlar[2].text = "QUIT";

            GenelYazilar[0].text = "Let's Play";
            GenelYazilar[1].text = "The game is very difficult";
            GenelYazilar[2].text = "Can you finish the game?";

            if (dropmu)
            {
                PlayerPrefs.SetInt("dilTercihi1", 1);
            }
        }
    }
}
