using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    /* Document for C# Milestones
     * Author: Paige Johnson
     * DIG 250
     */


    public int CurrentGold = 32;

    public bool PureOfHeart = true;
    public bool HasSecretIncantation = false;
    public string RareItem = "Relic Stone";

    public Transform CamTransform;
    public GameObject DirectionLight;
    public Transform LightTransform;

    Weapon huntingBow = new Weapon("Hunting Bow", 105);


    // Start is called before the first frame update
    /// <summary>
	/// runs at before start
	/// </summary>
    void Start()
    {

        Thievery();
        OpenTreasureChamber();

        DirectionLight = GameObject.Find("Directional Light");
        LightTransform = DirectionLight.GetComponent<Transform>();
        Debug.Log(LightTransform.localPosition);

    }

    public void OpenTreasureChamber()
    {
        if(PureOfHeart && RareItem == "Relic Stone")
        {
            if (!HasSecretIncantation)
            {
                Debug.Log("You have the spirit, but not the knowledge.");
            }
            else
            {
                Debug.Log("The treasue is yours, worthy hero!");
            }
        }
        else
        {
            Debug.Log("Come back when you have what it takes.");
        }

    }

    public void Thievery()
    {
        //public method with no return value
        if (CurrentGold > 50)
        {
            Debug.Log("You're rolling in it!");
        }
        else if (CurrentGold < 15)
        {
            Debug.Log("Not much there to steal...");
        }
        else
        {
            Debug.Log("Looks like your purse is in the sweet spot.");
        }
    }


    // Update is called once per frame
    /// <summary>
	/// updates game scene
	/// </summary>
    void Update()
    {
        
    }
}
