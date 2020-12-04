using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTextFromInputField : MonoBehaviour
{
    public string globalPlayerName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        globalPlayerName = GlobalVariable.playerName;    
    }

    public void getTextAndSetToGlobal()
    {
        Debug.Log("getTextAndSetToGlobal");
        Debug.Log(gameObject.GetComponent<InputField>().text);
        GlobalVariable.playerName = gameObject.GetComponent<InputField>().text;
    }
}
