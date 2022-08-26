using UnityEngine;


public class OnLifeDown : MonoBehaviour
{
    private static float lifes = -1;

    private void Start()
    {
        var resource = PlayerResource.Find("life");
        if (lifes == -1)
        {
            lifes = resource.GetValue();
        } else
        {
            resource.ChangeValue(lifes - resource.GetValue());
        }
        resource.ValueChangeEvent += OnChangeLife;
    }
    private void OnChangeLife(float value)
    {
        lifes = value;
    }
}

