using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using ArtemisNS;

public class CardDisplay : MonoBehaviour
{
    public Card cardData;

    public Image cardImage;

    public TMP_Text nameText;
    public TMP_Text healthText;
    public TMP_Text damageText;

    public Image[] typeImages;

    private Color[] cardColors = {
        //colors must be the same order as the types in cardType enum in card script

        Color.red,//fire
        new Color(0.8f, 0.52f, 0.24f), //earth
        Color.blue, //water
        Color.cyan //air
    
    };
    private Color[] typeColors = {
        //colors must be the same order as the types in cardType enum in card script

        Color.red,//fire
        new Color(0.8f, 0.52f, 0.24f), //earth
        Color.blue, //water
        Color.cyan //air
    
    };

    void Start()
    {
        UpdateCardDisplay();    
    }


    public void UpdateCardDisplay()
    {

        cardImage.color = cardColors[(int)cardData.cardType[0]];


        nameText.text = cardData.cardName;
        healthText.text = cardData.health.ToString();
        damageText.text = $"{cardData.damageMin}";

        for (int i = 0; i < typeImages.Length; i++)
        {
            if (i < cardData.cardType.Count)
            {
                typeImages[i].gameObject.SetActive(true);
                typeImages[i].color = typeColors[(int)cardData.cardType[i]];
            }
            else
            {
                typeImages[i].gameObject.SetActive(false);
            }
        }

    }
    
}
