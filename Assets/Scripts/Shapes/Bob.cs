using UnityEngine;

public class Bob : Shape //INHERITANCE
{

    private void Start()
    {
        m_shapeName = "Bob";
        m_shapeColor = Color.blue;
    }

    //POLYMORPHISM
    public override void DisplayText()
    {
        display.text = "My name is " + m_shapeName;
    }
}
