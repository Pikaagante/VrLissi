using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DropDownScript : MonoBehaviour
{
    [SerializeField] private Canvas canvasToControl;

    public void TurnProviderSelect(int index)
    {
        switch (index)
        {
            case 0:
                canvasToControl.enabled = false;
                break;
            case 1:
                canvasToControl.enabled = true; 
                break;
        }
    }
}