using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle_Passcode : MonoBehaviour
{
    public static string passcode = "45545"; // Temporary number here
    
    void Start()
    {
        // Generate random passcode
        int pass = Random.Range(11111111,99999999);
        
        string tmp_passcode = pass.ToString();
        passcode = "";
        for (int i = 0; i < tmp_passcode.Length; i++) {
            if (tmp_passcode[i] == '0') 
                passcode += '1';
            else
                passcode += tmp_passcode[i];
        }
        GameObject.Find("Code").GetComponent<Text>().text = passcode;
        Debug.Log(passcode);
    }
}
