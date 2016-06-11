using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class TextController : MonoBehaviour {

    public Text text;
    enum States {cell, mirror, sheets_0, locks_0, cell_mirror, sheets_1, lock_1, freedom};
    private States myState;

	// Use this for initialization
	void Start () {
        myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
        print(myState);
        if (myState == States.cell)
        {
            State_Cell();
        } else if (myState == States.sheets_0)
        {
            State_Sheets_0();
        }
	}

    void State_Cell()
    {
        text.text = "You are in a prison cell and you wan to escape. " +
                    "There are some dirty sheets on the bed, " +
                    "a mirror on the wall. " +
                    "and the door is locked from the outside. \n\n" +
                    "Press S to view Sheets, M to view Mirror, L to view Lock.";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_0;
        }
    }

    private void State_Sheets_0()
    {
        text.text = "These sheets really need a wash. " +
                    "They have the same stain the first day I got in here. " +
                    "Can't wait to leave! \n\n" +
                    "Press R to return to roaming your cell.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }
}
