using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//[CreateAssetMenu(fileName = "SnipersState", menuName = "State", order =4)]
[CreateAssetMenu(fileName = "ShootersConfig", menuName = "CreateShooters", order = 4)]
public class State : ScriptableObject
{
    public bool isFinished { get; protected set; }
    public float shootPause;
    public virtual void Init() { }
   // public abstract void Shoot();

}

[SerializeField]
public class StateSniper: State
{
    public State state;
    public override void Init()
    {
        shootPause = 1f;
    }
  //  public override void Shoot()
  //  {
  //      if (isFinished)
  //      {
  //          return;
  //      }
  //  }

}
