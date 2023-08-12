using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "plantData", menuName = "Plant Data", order = 51)]
public class PlantData : ScriptableObject
{
  public enum THREAT { NONE, LOW, MODERATE, HIGH }
  [SerializeField] private string plantName;
  [SerializeField] private THREAT plantThreat;
  [SerializeField] private Texture icon;

  public string Name { get { return plantName; } }
  public THREAT Threat { get { return plantThreat; } }
  public Texture Icon { get { return icon; } }
}
