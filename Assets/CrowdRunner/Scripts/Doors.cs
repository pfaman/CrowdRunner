using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Doors : MonoBehaviour
{
   

    enum BonusType { Addition, Difference}

    [Header("Elements")]
    [SerializeField] private SpriteRenderer rightDoorRender;
    [SerializeField] private SpriteRenderer leftDoorRender;

    [SerializeField] private TextMeshPro leftDoorText;
    [SerializeField] private TextMeshPro rightDoorText;

    [Header("Settings")]
    [SerializeField] private BonusType rightDoorBonusType;
    [SerializeField] private int rightDoorBonusAmount;

    [SerializeField] private BonusType leftDoorBonusType;
    [SerializeField] private int leftDoorBonusAmount;

    [SerializeField] public Color bonusColor;
    [SerializeField] public Color penalityColor;

    // Start is called before the first frame update
    void Start()
    {
        ConfigureDoors();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ConfigureDoors()
    {
        // Configure Right Door

        if(rightDoorBonusType == BonusType.Addition)
        {
            rightDoorRender.color = bonusColor;
            rightDoorText.text = "+" + rightDoorBonusAmount;
        }
        else if(rightDoorBonusType == BonusType.Difference)
        {
            rightDoorRender.color = penalityColor;
            rightDoorText.text = "-" + rightDoorBonusAmount;
        }

        // Configure Left Door

        if (leftDoorBonusType == BonusType.Addition)
        {
            leftDoorRender.color = bonusColor;
            leftDoorText.text = "+" + leftDoorBonusAmount;
        }
        else if (leftDoorBonusType == BonusType.Difference)
        {
            leftDoorRender.color = penalityColor;
            leftDoorText.text = "-" + leftDoorBonusAmount;
        }
    }
}
