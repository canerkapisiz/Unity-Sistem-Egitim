using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DilYonetimiYontem3b : MonoBehaviour
{
    public List<string> TRDilVerileri;
    public List<string> ENDilVerileri;

    void Start()
    {
        TRDilVerileri.Add("OYNA");
        TRDilVerileri.Add("AYARLAR");
        TRDilVerileri.Add("ÇIKIŞ");
        TRDilVerileri.Add("Oynayalım");
        TRDilVerileri.Add("Oyun çok zor");
        TRDilVerileri.Add("Oyunu bitirebilecek misin ?");

        ENDilVerileri.Add("PLAY");
        ENDilVerileri.Add("SETTINGS");
        ENDilVerileri.Add("QUIT");
        ENDilVerileri.Add("Let's play");
        ENDilVerileri.Add("The game is very difficult");
        ENDilVerileri.Add("Can you finish the game ?");
    }
}
