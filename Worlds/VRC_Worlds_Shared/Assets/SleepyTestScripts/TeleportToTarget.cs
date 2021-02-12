
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class TeleportToTarget : UdonSharpBehaviour
{
    public GameObject target;
    public bool onInteract;
    public bool onTriggerEnter;


    void Start()
    {

    }

    public override void Interact()
    {
        if (onInteract)
            Networking.LocalPlayer.TeleportTo(target.transform.position, target.transform.rotation);
    }

    public override void OnPlayerTriggerEnter(VRCPlayerApi player)
    {
        if (onTriggerEnter)
            Networking.LocalPlayer.TeleportTo(target.transform.position, target.transform.rotation);
    }
}
