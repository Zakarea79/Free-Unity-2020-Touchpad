using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using static ListButtonData;

[HelpURL(@"https://github.com/Zakarea79/Free-Unity-Touchpad")]
public class ZJoystoke : MonoBehaviour
{
    private EventTrigger Et;
    [SerializeField] private string AxisName_H , AxisName_V;
    public Color PressColor = new Color32(130 , 130 , 130 , 255) , normalColor = new Color32(255,255,255, 255);
    public Sprite PressButton , UpButton;
    public bool BlockX , BlockY; 
    private Image BaseColor;
    
    private void Awake() 
    {
        if(AxisName_H != "")
            Axis.Add(AxisName_H , 0);
        if(AxisName_V != "")
            Axis.Add(AxisName_V , 0);
    }

    void Start()
    {
        BaseColor = GetComponent<Image>();
        Et = gameObject.AddComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.Drag;
        entry.callback.AddListener((dtat) => 
        {
            DragEvent((PointerEventData)dtat);
        });

        EventTrigger.Entry entryUp = new EventTrigger.Entry();
        entryUp.eventID = EventTriggerType.PointerUp;
        entryUp.callback.AddListener((data) => 
        {
            BaseColor.color = normalColor;
            BaseColor.sprite = UpButton;
            transform.position = transform.parent.position;
            Axis[AxisName_H] = 0;
            Axis[AxisName_V] = 0;
        });

        EventTrigger.Entry entryDown = new EventTrigger.Entry();
        entryDown.eventID = EventTriggerType.PointerDown;
        entryDown.callback.AddListener((data) => 
        {
            BaseColor.color = PressColor;
            BaseColor.sprite = PressButton;
        });

        Et.triggers.Add(entry);
        Et.triggers.Add(entryDown);
        Et.triggers.Add(entryUp);
    }

    public void DragEvent(PointerEventData data)
    {
        transform.position = data.position;
        float X = Mathf.Clamp(transform.localPosition.x , -80 , 80);
        float Y = Mathf.Clamp(transform.localPosition.y , -80 , 80);
        transform.localPosition = new Vector2(BlockX == true ? 0 : X , BlockY == true ? 0 : Y);

        if(AxisName_H != "")
            Axis[AxisName_H] = Mathf.Clamp(transform.localPosition.x , -80f , 80f) / 80;
        else
            Debug.LogError("AxisName_H Equals Null");
        if(AxisName_V != "")
            Axis[AxisName_V] = Mathf.Clamp(transform.localPosition.y , -80f , 80f) / 80;
        else
            Debug.LogError("AxisName_V Equals Null");
    }
}
