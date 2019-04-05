using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_Passcode : MonoBehaviour
{
    public static string passcode = "45545"; // Temporary number here
    
    void Start()
    {
        // Generate random passcode
        int pass = Random.Range(1111,9999);
        string tmp_passcode = pass.ToString();
        passcode = "";
        for (int i = 0; i < tmp_passcode.Length; i++) {
            if (tmp_passcode[i] == '0') 
                passcode += '1';
            else
                passcode += tmp_passcode[i];
        }
        Debug.Log("pass: " + passcode);
        
    }
}
