using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    /* Document for C# Milestones
     * Author: Paige Johnson
     * DIG 250
     */


    // defining variables
    private int CurrentAge = 30;
    public int AddedAge = 1;

    public float pi = 3.14f;
    public string FirstName = "Paige";
    public bool IsAuthor = true;

    // Start is called before the first frame update
    /// <summary>
	/// runs at before start
	/// </summary>
    void Start()
    {
        //ComputeAge();

 
        int CharacterLevel = 32;
        int NextSkillLevel = GenerateCharacter("Spike", CharacterLevel);

        Debug.Log(NextSkillLevel);
        Debug.Log(GenerateCharacter("Faye", CharacterLevel));

        //Debug.Log($"A string can have variables like {FirstName} inserted directly!");
    }

    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }

    public int GenerateCharacter(string name, int level)
    {
        //Debug.Log("Character: {0} - Level: {1}", name, level);
        return level += 5;
    }


    // Update is called once per frame
    /// <summary>
	/// updates game scene
	/// </summary>
    void Update()
    {
        
    }
}
