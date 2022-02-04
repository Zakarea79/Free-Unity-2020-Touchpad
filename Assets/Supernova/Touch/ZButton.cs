using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static ListButtonData;

public class ZButton : MonoBehaviour
{
    private EventTrigger Et;
    [SerializeField] private string Keycode;
    [SerializeField] private KeyCode XKeyCode;
    public Color PressColor = new Color32(130 , 130 , 130 , 255) , normalColor = new Color32(255,255,255, 255);
    public Sprite PressButton , UpButton;
    private Image BaseColor;

    private void Awake() 
    {
        if(Keycode != "")
        {
            Button_Down.Add(Keycode , false);   
            Button_Up.Add(Keycode , false);   
            Button_Press.Add(Keycode , false);  
        }
        //--------------------------------
        if(XKeyCode != KeyCode.None)
        {
            Button_Down_KeyCode.Add(XKeyCode , false);   
            Button_Up_KeyCode.Add(XKeyCode , false);   
            Button_Press_KeyCode.Add(XKeyCode , false);   
        }
    }
    void Start()
    {
        BaseColor = GetComponent<Image>();
        Et = gameObject.AddComponent<EventTrigger>();
        EventTrigger.Entry entryUp = new EventTrigger.Entry();
        entryUp.eventID = EventTriggerType.PointerUp;
        entryUp.callback.AddListener((data) => 
        {
            if(Keycode != "")
            {
                Button_Up[Keycode] = true;
                Button_Press[Keycode] = false;
            }
            if(XKeyCode != KeyCode.None)
            {
                Button_Up_KeyCode[XKeyCode] = true;
                Button_Press_KeyCode[XKeyCode] = false;
            }
            BaseColor.color = normalColor;
            BaseColor.sprite = UpButton;
        });

        EventTrigger.Entry entryDown = new EventTrigger.Entry();
        entryDown.eventID = EventTriggerType.PointerDown;
        entryDown.callback.AddListener((data) => 
        {
            if(Keycode != "")
            {
                Button_Down[Keycode] = true;
                Button_Press[Keycode] = true;
            }
            if(XKeyCode != KeyCode.None)
            {
                Button_Down_KeyCode[XKeyCode] = true;
                Button_Press_KeyCode[XKeyCode] = true;
            }
            BaseColor.color = PressColor;
            BaseColor.sprite = PressButton;
        });

        Et.triggers.Add(entryDown);
        Et.triggers.Add(entryUp);
    }
}
