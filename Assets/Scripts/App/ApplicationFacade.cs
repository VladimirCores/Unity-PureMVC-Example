using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using Assets.Scripts.App.Consts.Commands;

public class ApplicationFacade : Facade {
    
    override protected void InitializeController()
    {
        base.InitializeController();
        this.RegisterCommand(ApplicationCommands.STARTUP,  typeof(StartupCommand));
        this.RegisterCommand(ApplicationCommands.READY,    typeof(ReadyCommand));
    }

    public void startup(Application app)
    {
        this.SendNotification(ApplicationCommands.STARTUP, app);
    }

}
