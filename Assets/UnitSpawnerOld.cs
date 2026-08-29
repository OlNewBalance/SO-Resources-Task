using UnityEngine;

public class UnitSpawnerOld : MonoBehaviour
{
    private readonly string[] unitTypesToSpawn = { "warrior", "archer", "mage", "rogue" };

    private void Start()
    {
        foreach (var type in unitTypesToSpawn)
        {
            SpawnUnit(type);
        }
    }

    private void SpawnUnit(string unitType)
    {
        string name;
        int health;
        float speed;

        if (unitType == "warrior")
        {
            name = "Воин";
            health = 150;
            speed = 3f;
        }
        else if (unitType == "archer")
        {
            name = "Лучник";
            health = 80;
            speed = 5f;
        }
        else if (unitType == "mage")
        {
            name = "Маг";
            health = 60;
            speed = 4f;
        }
        else if (unitType == "rogue")
        {
            name = "Вор";
            health = 70;
            speed = 7f;
        }
        else
        {
            Debug.LogError($"Неизвестный тип юнита: {unitType}");
            return;
        }

        Debug.Log($"Спавним {name} | HP: {health} | Speed: {speed}");
        // Представим, что здесь Instantiate
    }
}