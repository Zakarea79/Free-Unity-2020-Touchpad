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
    public static bool EnableWarning = true;
    public static bool GetKeyDown(string key)
    {
        if (Button_Down.ContainsKey(key) == true)
        {
            bool temp = Button_Down[key];
            Button_Down[key] = false;
            return temp;
        }
        else if (EnableWarning == true)
        {
            Debug.LogWarning($"Supernova Message : Key {key} Not Fund");
        }
        return false;
    }

    public static bool GetKeyUp(string key)
    {
        if (Button_Up.ContainsKey(key) == true)
        {
            bool temp = Button_Up[key];
            Button_Up[key] = false;
            return temp;
        }
        else if (EnableWarning == true)
        {
            Debug.LogWarning($"Supernova Message : Key {key} Not Fund");
        }
        return false;
    }

    public static bool GetKeyPress(string key)
    {
        if (Button_Press.ContainsKey(key) == true)
        {
            return Button_Press[key];
        }
        else if (EnableWarning == true)
        {
            Debug.LogWarning($"Supernova Message : Key {key} Not Fund");
        }
        return false;
    }
    //-----------------------------------------------------------
    public static bool GetKeyDown(KeyCode key)
    {
        if (Button_Down_KeyCode.ContainsKey(key) == true)
        {
            bool temp = Button_Down_KeyCode[key];
            Button_Down_KeyCode[key] = false;
            return temp;
        }
        else if (EnableWarning == true)
        {
            Debug.LogWarning($"Supernova Message : Key {key} Not Fund");
        }
        return false;
    }

    public static bool GetKeyUp(KeyCode key)
    {
        if (Button_Up_KeyCode.ContainsKey(key) == true)
        {
            bool temp = Button_Up_KeyCode[key];
            Button_Up_KeyCode[key] = false;
            return temp;
        }
        else if (EnableWarning == true)
        {
            Debug.LogWarning($"Supernova Message : Key {key} Not Fund");
        }
        return false;
    }

    public static bool GetKeyPress(KeyCode key)
    {
        if (Button_Press_KeyCode.ContainsKey(key) == true)
        {
            return Button_Press_KeyCode[key];
        }
        else if (EnableWarning == true)
        {
            Debug.LogWarning($"Supernova Message : Key {key} Not Fund");
        }
        return false;
    }
    //------------------------------------------------

    public static float GetAxis(string AxisName)
    {
        if (Axis.ContainsKey(AxisName) == true)
        {
            return Axis[AxisName];
        }
        else if (EnableWarning == true)
        {
            Debug.LogWarning($"Supernova Message : Axis {AxisName} Not Fund");
        }
        return 0;
    }
    public static Quaternion Get_3D_Direction(string Direction)
    {
        if (Direction3D.ContainsKey(Direction) == true)
        {
            return Direction3D[Direction];
        }
        else if (EnableWarning == true)
        {
            Debug.LogWarning($"Supernova Message : Direction 2D {Direction} Not Fund");
        }
        return new Quaternion();
    }
    public static Quaternion Get_2D_Direction(string Direction)
    {
        if (Direction2D.ContainsKey(Direction) == true)
        {
            return Direction2D[Direction];
        }
        else if (EnableWarning == true)
        {
            Debug.LogWarning($"Supernova Message : Direction 2D {Direction} Not Fund");
        }
        return new Quaternion();
    }
}