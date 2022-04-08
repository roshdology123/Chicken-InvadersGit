using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    private RectTransform bar;
    // Start is called before the first frame update
    void Start()
    {
        bar = GetComponent<RectTransform>();
    }

    public void Damage(float damage)
    {
        if ((Health.TotalHealth -= damage) >= 0f)
        {
            Health.TotalHealth -= damage;
        }
        else
        {
            Health.TotalHealth = 0f;
        }
        SetSize(Health.TotalHealth);
    }
    public void SetSize(float size)
    {
        bar.localScale = new Vector3(size, 1f);
    }
}
