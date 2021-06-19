using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public string SurName { get; set; }
    public string Name { get; set; }    
    public enum Gender
    {
        male,
        female
    }
    public int Age { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public enum Health
    {
        healthy,
        neutral,
        nonHealthy
    }
    public enum Analysis
    {
        positive,
        neutral,
        nonPositive
    }
}
