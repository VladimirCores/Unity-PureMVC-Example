using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using PureMVC.Interfaces;

public class ReadyCommand : SimpleCommand
{
    public override void Execute(INotification notification)
    {
        Debug.Log("PureMVC > ReadyCommand > executes");
    }
}