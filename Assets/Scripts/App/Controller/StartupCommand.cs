using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using PureMVC.Interfaces;

public class StartupCommand : MacroCommand {

    public StartupCommand()
    {
        this.AddSubCommand(typeof(PrepareBeginCommand));
        this.AddSubCommand(typeof(PrepareModelCommand));
        this.AddSubCommand(typeof(PrepareControllerCommands));
        this.AddSubCommand(typeof(PrepareViewCommand));
        this.AddSubCommand(typeof(PrepareCompleteCommand));
    }

    override public void Execute(INotification notification)
    {
        Debug.Log("PureMVC > StartupCommand > executes");
        base.Execute(notification);
    }

}
