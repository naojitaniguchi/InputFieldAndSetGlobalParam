using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPlayerName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text = GlobalVariable.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        // gameObject.GetComponent<Text>().text = GlobalVariable.playerName;
    }

    public void setName()
    {
        Debug.Log("SetName");
        gameObject.GetComponent<Text>().text = GlobalVariable.playerName;
    }
}
