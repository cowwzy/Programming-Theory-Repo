using UnityEngine;

public class Larry : Shape //INHERITANCE
{

    private void Start()
    {
        m_shapeName = "Larry";
        m_shapeColor = Color.yellow;
    }
    public override void DisplayText() //POLYMORPHISM
    {
        display.text = "I am " + m_shapeName;
    }
}
