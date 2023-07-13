using Godot;
using System;

public partial class ToadRes : Resource
{
    public enum FrogState
    {
        Normale,
        PreparingForJumping
    }

    [Export]
    public float JumpForce=100;

    [Export]
    public float Gravity=ProjectSettings.GetSetting("physics/2d/default_gravity").As<float>();
    [Export]
    public float HorizentalSpeed=300;

    [Export(PropertyHint.Range,"0,1")]
    public float Friction=1;

    [Export]
    public float HorizentalSpeedAir=100;
   public float JumpScale { get; set; }=0;
   public FrogState FrogSate { get; set; }=FrogState.Normale;
   public float Direction { get; set; }=0;

   
   public bool IsMax()
   {
      return  JumpScale>=1;
   }

   
   
}
