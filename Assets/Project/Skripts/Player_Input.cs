using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input : MonoBehaviour {

	void Update () {
		Muwer.rid.muve = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
        Muwer.rid.rut = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Stwol.rid.WatterSize(true);
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Stwol.rid.WatterSize(false);
        }
        if (Input.GetKeyDown(KeyCode.Escape)|| Input.GetKeyDown(KeyCode.Tab))
        {
            Interface.rid.Menu();
        }
    }
}
