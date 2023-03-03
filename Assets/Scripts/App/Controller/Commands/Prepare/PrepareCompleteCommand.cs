using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using PureMVC.Interfaces;
using Assets.Scripts.App.Consts.Commands;

public class PrepareCompleteCommand : SimpleCommand
{
    public override void Execute(INotification notification)
    {
        Debug.Log("PureMVC > StartupCommand > executes > PrepareCompleteCommand");

        this.SendNotification(ApplicationCommands.READY);

        this.Facade.RemoveCommand(ApplicationCommands.STARTUP);
        this.Facade.RemoveCommand(ApplicationCommands.READY);
    }
}
