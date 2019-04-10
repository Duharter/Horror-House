using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle_Passcode : MonoBehaviour
{
    public static string passcode1 = "4554"; // Temporary number here
    public static string passcode2 = "4554"; // Temporary number here
    public static string passcode = "4554"; // Actual concatenated code
    
    void Start()
    {
        // Generate random passcode
        int pass = Random.Range(11111111,99999999);
        
        string tmp_passcode = pass.ToString();
        
        passcode1 = "";
        passcode2 = "";
        passcode = "";
        for (int i = 0; i < tmp_passcode.Length / 2; i++) {
            if (tmp_passcode[i] == '0') {
                passcode1 += '1';
                passcode += '1';
            }
            else {
                passcode1 += tmp_passcode[i];
                passcode += tmp_passcode[i];
            }
        }
        for (int i = 4; i < tmp_passcode.Length; i++) {
            if (tmp_passcode[i] == '0') {
                passcode2 += '1';
                passcode += '1';
            }
            else {
                passcode2 += tmp_passcode[i];
                passcode += tmp_passcode[i];
            }
        }
        GameObject.Find("first").GetComponent<Text>().text = passcode1;
        GameObject.Find("second").GetComponent<Text>().text = passcode2;
    }
}
