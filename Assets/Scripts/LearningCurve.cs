using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// This is a summary
/// <summary>
public class LearningCurve : MonoBehaviour
{
    /* Example multi-
       line comment */
    public int integerEx; // example single line comment
    public float floatEx;
    public string stringEx = "myString";
    private List<string> stringList = new List<string>();
    public bool boolEx;
    // private int num1 = 5;
    // private int num2 = 16;
    private Transform camTransform;
    public GameObject directionLight;
    private Transform lightTransform; 



    int add(int num1, int num2) {
        return num1 + num2;
    }

    bool isBigger(int num1, int num2) {
        if (num1 > num2) {
            return true;
        }
        else if (num2 > num1) {
            return false;
        }
        else {
            return false;
        }
    }

    void exampleSwitch() {
        string characterAction = "Attack";

        switch(characterAction) {
            case "Heal":
                Debug.Log("Potion sent.");
                break;
            case "Attack":
                Debug.Log("To arms!");
                break;
            default:
                Debug.Log("Shields up.");
                break;
        }
    }


    

    // Start is called before the first frame update
    void Start()
    {

        // stringList.Add(stringEx);
        // for (int i = 0; i < 0; i++) {
        //     Debug.Log(stringList[i]);
        // }
        // foreach (string item in stringList) {
        //     Debug.Log(item);
        // }
        // Dictionary<string, int> itemInventory = new Dictionary<string, int>() {
        //     {"potion", 6},
        //     {"arrows", 17},
        //     {"gold", 3}
        // };

        // foreach (KeyValuePair<string, int> kvp in itemInventory) {
        //     Debug.LogFormat("{0}: {1}", kvp.Key, kvp.Value);
        // }


        // Chap 5
        Character hero = new Character();
        hero.PrintStatsInfo();
        Character heroine = new Character("Agatha");
        heroine.PrintStatsInfo();
        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        Character hero2 = new Character();
        hero2.PrintStatsInfo(); 
        hero2.name = "Sir Krane the Brave";
        Weapon warBow = huntingBow;
        warBow.name = "War Bow";
        warBow.damage = 155;
        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();
        camTransform = this.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition); 
        // directionLight = GameObject.Find("Directional Light"); 
        lightTransform = directionLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
