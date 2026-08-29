using UnityEngine;

public class UnitSpawner : MonoBehaviour
{
    private void Start()
    {
        UnitData[] allUnits = Resources.LoadAll<UnitData>("");

        foreach (var unit in allUnits)
        {
            SpawnUnit(unit);
        }
    }

    private void SpawnUnit(UnitData data)
    {
        Debug.Log($"Спавним {data.unitName} | HP: {data.health} | Speed: {data.speed}");
    }
}