using UnityEngine;

public class Rick : Shape //INHERITANCE
{

    private void Start()
    {
        m_shapeName = "Rick";
        m_shapeColor = Color.red;
    }
    public override void DisplayText() //POLYMORPHISM
    {
        display.text = "What's up, I'm " + m_shapeName + "!";
    }
}

