using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using PureMVC.Interfaces;

public class PrepareViewCommand : SimpleCommand
{
    public override void Execute(INotification notification)
    {
        Debug.Log("PureMVC > StartupCommand > executes > PrepareViewCommand");

        //Facade.RegisterMediator(PlayFieldMediator.NAME, new PlayFieldMediator());
    }
}