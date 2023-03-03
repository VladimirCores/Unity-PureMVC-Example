using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using PureMVC.Interfaces;
using System.Collections.Generic;

public class PlayFieldMediator : Mediator {

    static public readonly string NAME = "PlayFieldMediator";

	public PlayFieldMediator(GameObject playfield):base(NAME, playfield)
    {

    }

    public void HandleNotification(INotification notification)
    {

    }

    public IList<string> ListNotificationInterests()
    {
        return new List<string>() {

        };
    }
    public void OnRegister()
    {

    }
}
