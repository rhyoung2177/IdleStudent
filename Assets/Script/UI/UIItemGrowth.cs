using UnityEngine;
using UnityEngine.UI;
using PolyAndCode.UI;

public class UIItemGrowth : MonoBehaviour, ICell
{
    //Model
    private ContactInfo _contactInfo;
    private int _cellIndex;
    //This is called from the SetCell method in DataSource
    public void ConfigureCell(ContactInfo contactInfo, int cellIndex)
    {
        _cellIndex = cellIndex;
        _contactInfo = contactInfo;
    }
}