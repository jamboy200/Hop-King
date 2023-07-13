using System;
using Godot;

namespace Utilities;
public static class Extenstions 
{
    public static float Lerp(this float variable,float value,float Scale=0.5f)
    {
        return variable*(1-Scale)+value*Scale;
    }
    public static int Sign(this int variable)
    {
        if(variable>0)
        {
            return 1;
        }else if(variable<0)
        {
            return -1;
        }
        return 0;
        
    }
    
     public static int Sign(this float variable)
    {
        if(variable>0)
        {
            return 1;
        }else if(variable<0)
        {
            return -1;
        }
        return 0;
    }
    
}