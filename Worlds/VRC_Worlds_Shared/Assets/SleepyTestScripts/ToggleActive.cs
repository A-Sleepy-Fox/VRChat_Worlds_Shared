
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class ToggleActive : UdonSharpBehaviour
{
    public GameObject target;

    public override void Interact()
    {
        target.SetActive(!target.activeSelf);
    }
}
