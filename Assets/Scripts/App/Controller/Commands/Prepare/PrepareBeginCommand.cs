using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using PureMVC.Interfaces;

public class PrepareBeginCommand : SimpleCommand
{
    public override void Execute(INotification notification)
    {
        Debug.Log("PureMVC > StartupCommand > executes > PrepareBeginCommand");
    }
}
