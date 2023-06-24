using System.Collections.Generic;
using UnityEngine;
using static ListButtonData;

public static class ListButtonData
{
    public static Dictionary<string, bool> Button_Press = new Dictionary<string, bool>();
    public static Dictionary<string, bool> Button_Down = new Dictionary<string, bool>();
    public static Dictionary<string, bool> Button_Up = new Dictionary<string, bool>();
    //------------------------------------------------------------------------------------
    public static Dictionary<KeyCode, bool> Button_Press_KeyCode = new Dictionary<KeyCode, bool>();
    public static Dictionary<KeyCode, bool> Button_Down_KeyCode = new Dictionary<KeyCode, bool>();
    public static Dictionary<KeyCode, bool> Button_Up_KeyCode = new Dictionary<KeyCode, bool>();
    //-----------------------------------------------------------------------------------
    public static Dictionary<string, float> Axis = new Dictionary<string, float>();
    //-----------------------------------------------------------------------------------
    public static Dictionary<string, Quaternion> Direction3D = new Dictionary<string, Quaternion>();
    public static Dictionary<string, Quaternion> Direction2D = new Dictionary<string, Quaternion>();
}

public static class ZInput
{

    public static bool GetKeyDown(string key)
    {
        try
        {
            bool temp = Button_Down[key];
            Button_Down[key] = false;
            return temp;
        }
        catch (System.Exception)
        {
            throw new System.Exception($"Supernova Message : Key {key} Not Fund");
        }
    }

    public static bool GetKeyUp(string key)
    {
        try
        {
            bool temp = Button_Up[key];
            Button_Up[key] = false;
            return temp;
        }
        catch
        {
            throw new System.Exception($"Supernova Message : Key {key} Not Fund");
        }
    }

    public static bool GetKeyPress(string key)
    {
        try
        {
            return Button_Press[key];
        }
        catch
        {
            throw new System.Exception($"Supernova Message : Key {key} Not Fund");
        }
    }
    //-----------------------------------------------------------
    public static bool GetKeyDown(KeyCode key)
    {
        try
        {
            bool temp = Button_Down_KeyCode[key];
            Button_Down_KeyCode[key] = false;
            return temp;
        }
        catch
        {
            throw new System.Exception($"Supernova Message : Key {key} Not Fund");
        }
    }

    public static bool GetKeyUp(KeyCode key)
    {
        try
        {
            bool temp = Button_Up_KeyCode[key];
            Button_Up_KeyCode[key] = false;
            return temp;
        }
        catch
        {
            throw new System.Exception($"Supernova Message : Key {key} Not Fund");
        }

    }

    public static bool GetKeyPress(KeyCode key)
    {
        try
        {
            return Button_Press_KeyCode[key];
        }
        catch
        {
            throw new System.Exception($"Supernova Message : Key {key} Not Fund");
        }
    }
    //------------------------------------------------

    public static float GetAxis(string AxisName)
    {
        try
        {
            return Axis[AxisName];
        }
        catch
        {
            throw new System.Exception($"Supernova Message : Axis {AxisName} Not Fund");
        }
    }
    public static Quaternion Get_3D_Direction(string Direction) 
    {
        try
        {
            return Direction3D[Direction];
        }
        catch
        {
            throw new System.Exception($"Supernova Message : DirAxis {Direction} Not Fund");
        }
    }
    public static Quaternion Get_2D_Direction(string Direction) 
    {
        try
        {
            return Direction2D[Direction];
        }
        catch
        {
            throw new System.Exception($"Supernova Message : Direction 2D {Direction} Not Fund");
        }
    }
}