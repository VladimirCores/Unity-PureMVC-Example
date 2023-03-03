using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using PureMVC.Interfaces;
using Assets.Scripts.App.Consts.Commands;

public class PrepareControllerCommands : SimpleCommand
{
    public override void Execute(INotification notification)
    {
        Debug.Log("PureMVC > StartupCommand > executes > PrepareControllerCommands");
      
    }
}
