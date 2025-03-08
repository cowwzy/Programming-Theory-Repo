using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    [SerializeField] protected Text display;
    // ENCAPSULATION
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

    //POLYMORPHISM
    public virtual void DisplayText()
    {
        display.text = "I am a shape!";
    }

    public virtual void ClickReaction()
    {
        Debug.Log("Clicked on " + shapeName);
        DisplayText();
        gameObject.gameObject.GetComponent<Renderer>().material.color = m_shapeColor;
    }

    private void OnMouseDown()
    {
        ClickReaction(); // ABSTRACTION
    }
}
