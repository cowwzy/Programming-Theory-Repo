using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    [SerializeField] private Text display;
    private string shapeName;
    private Color shapeColor;

    public string m_shapeName
    {
        get { return shapeName; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                shapeName = value;
            }
        }
    }

    public Color m_shapeColor
    {
        get { return shapeColor; }
        set { shapeColor = value; }
    }


    public virtual void DisplayText()
    {
        display.text = "I am a shape!";
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked on " + shapeName);
        DisplayText();
    }
}
